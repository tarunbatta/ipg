(function () {
    'use strict';

    const fs = require('fs');

    const config = {
        questionsFolderPath: './questions/',
        siteUrl: 'https://leetcode.com',
        problemsUrl: 'https://leetcode.com/problemset/all/',
    };

    config.log = function (message) {
        const fileName = 'log.txt';
        message = this.getDate() + ' -> ' + message + '\n';

        fs.exists(fileName, function (exists) {
            if (exists) {
                fs.appendFile(fileName, message, function (err) {
                    if (err) throw err;
                });
            } else {
                fs.writeFile(fileName, message, (err) => {
                    if (err) throw err;
                });
            }
        });
    };

    config.getDate = function () {
        const now = new Date();
        const year = '' + now.getFullYear();
        let month = '' + (now.getMonth() + 1);

        if (month.length == 1) {
            month = '0' + month;
        }
        let day = '' + now.getDate();
        if (day.length == 1) {
            day = '0' + day;
        }
        let hour = '' + now.getHours();
        if (hour.length == 1) {
            hour = '0' + hour;
        }
        let minute = '' + now.getMinutes();
        if (minute.length == 1) {
            minute = '0' + minute;
        }
        let second = '' + now.getSeconds();
        if (second.length == 1) {
            second = '0' + second;
        }

        return year + '_' + month + '_' + day + '_' + hour + '_' + minute + '_' + second;
    };

    module.exports = config;
}());