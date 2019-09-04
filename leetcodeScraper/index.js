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

        await scrapeData();
        await page.waitFor(timeout);

        // await helper.deleteContentsOfFolder('questions');
        // await page.waitFor(timeout);

        await browser.close();
    };

    const scrapeData = async () => {
        // await getProblems();

        // for (let i = 0; i < questions.length; i++) {
        //     const question = questions[i];

        let question = {
            number: '1',
            title: 'Two Sum',
            url: 'https://leetcode.com/problems/two-sum/',
            difficulty: 'Easy',
            question: null,
            code: null,
        };

        await page.goto(question.url, {
            waitUntil: ['load', 'domcontentloaded'],
        });
        const bodyHTML = await page.evaluate(() => document.body.innerHTML);
        const $ = cheerio.load(bodyHTML);

        console.log($('div.content__u3I1 question-content__JfgR'));
        console.log($('div.content__u3I1 question-content__JfgR').text());


        // }
    };

    const getProblems = async () => {
        await page.goto(config.problemsUrl, {
            waitUntil: ['load', 'domcontentloaded'],
        });

        const bodyHTML = await page.evaluate(() => document.body.innerHTML);
        const $ = cheerio.load(bodyHTML);

        $('div.question-list-table > table > tbody.reactable-data > tr').each(
            (i, element) => {
                questions.push({
                    number: $(element).find('td:nth-child(2)').text(),
                    title: $(element).find('td:nth-child(3) > div > a').text(),
                    url: config.siteUrl + $(element).find('td:nth-child(3) > div > a').attr('href'),
                    difficulty: $(element).find('td:nth-child(6) > span').text(),
                    question: null,
                    code: null,
                });
            }
        );
    };

    init();

    module.exports = app;
}());