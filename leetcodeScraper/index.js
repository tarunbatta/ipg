(function () {
    'use strict';

    const app = {};

    const puppeteer = require('puppeteer');
    const cheerio = require('cheerio');
    const fs = require('fs');
    const http = require('http');

    const config = require('./config');
    const helper = require('./helper');

    let browser = null;
    let page = null;

    const questions = [];
    const timeout = 500;

    const init = async () => {
        browser = await puppeteer.launch({
            headless: false,
            slowMo: 500,
        });
        page = await browser.newPage();
        await page.setViewport({
            width: 1024,
            height: 768,
            deviceScaleFactor: 1,
        });

        await getProblems();
        await page.waitFor(timeout);
        config.writeFile('questions.json', JSON.stringify(questions));
        await page.waitFor(timeout);
        await helper.deleteContentsOfFolder('./questions');
        await page.waitFor(timeout);
        await scrapeData();
        await page.waitFor(timeout);

        await browser.close();
    };

    const scrapeData = async () => {
        for (let i = 0; i < questions.length; i++) {
            const question = questions[i];

            await page.goto(question.url, {
                waitUntil: ['load', 'domcontentloaded'],
            });

            await page.waitFor(timeout * 3);
            const bodyHTML = await page.evaluate(() => document.body.innerHTML);
            const $ = cheerio.load(bodyHTML);
            await page.waitFor(timeout);

            if (i == 0) {
                await page.click('div.ant-select-selection');
                await page.waitFor(timeout);
                await page.click('li[data-cy="lang-select-C#"]');
                await page.waitFor(timeout);
            }

            question.question = $('div.question-content__JfgR > div').html();

            if (question.question != null && question.question.length > 0) {
                question.question = question.question.replace(/<[^>]+>/g, '');
            }

            $('div.CodeMirror-code div').each(function (index, element) {
                question.code += $(element).find('pre').text();
            });

            config.writeFile(config.questionsFolderPath + question.number + '.json', JSON.stringify(question));
            await page.waitFor(timeout);
        }
    };

    const getProblems = async () => {
        await page.goto(config.problemsUrl, {
            waitUntil: ['load', 'domcontentloaded'],
        });

        await page.waitFor(timeout);
        const option = (await page.$x(
            '//select/option[text() = "all"]'
        ))[0];
        const value = await (await option.getProperty('value')).jsonValue();
        await page.select('select.form-control', value);
        await page.waitFor(timeout);

        const bodyHTML = await page.evaluate(() => document.body.innerHTML);
        const $ = cheerio.load(bodyHTML);

        $('div.question-list-table > table > tbody.reactable-data > tr').each(
            (i, element) => {
                questions.push({
                    number: $(element).find('td:nth-child(2)').text(),
                    title: $(element).find('td:nth-child(3) > div > a').text(),
                    url: config.siteUrl + $(element).find('td:nth-child(3) > div > a').attr('href'),
                    difficulty: $(element).find('td:nth-child(6) > span').text(),
                });
            }
        );
    };

    init();

    module.exports = app;
}());