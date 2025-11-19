//const logger = require('../utils/logger');

const express = require('express');
const router = express.Router();

const database = require('pg');
const database_address = "postgres://postgres:temp1234@35.229.231.94:5432/food_data";
var database_client;
const client = new database.Client(database_address);
client.connect((err) => {
    if(err) {
        //logger.error(err);
        console.log(err);
    }
    else {
        //logger.info('Success to connect to the database');
        console.log('Success to connect to the database');
    }
});

const fs = require('fs');
const {Storage} = require('@google-cloud/storage');
const gcps = new Storage();
const bucket_name = 'csproject-1b085.appspot.com';

router.get('/', function(req, res, next) {
    var sql = "SELECT * FROM food_list WHERE name='" + req.query.name + "'";    //테스트 용, 추후 name->search_text 변경 및 검색 알고리즘 적용

    if(database_client == null) {
        database_client = new database.Client(database_address);
        database_client.connect((err) => {
            if(err) {
                console.log(err);
                res.end('Connection Error');
                return;
            }
            else {
                console.log('Database client initialized');
            }
        });
    }

    console.log("Query: " + sql);
    database_client.query(sql, (error, result) => {
        if(error) {
            console.log(error);
            res.end(error);
        }
        else {
            /*
            var result_text = "Food List Query Result\n"
            result_text += result.command;
            result_text += "\n";
            result_text += "Row count: " + result.rowCount;
            result_text += "\n";
            result_text += "Rows: \n";
            result_text += JSON.stringify(result.rows, null, '\t');
            logger.debug(result_text);
            //*/
            res.json(result.rows);
        }
    });
});

router.get('/image/', function(req, res, next) {
    //var image_src = "../pics/" + req.query.src;
    //var image = fs.readFileSync(image_src);
    var image = storage.bucket(bucket_name).file(req.query.src);

    //logger.debug("Image Request: " + image_src);
    console.log("Image Request: " + image_src);

    //* Request in PC Local
    res.writeHead(200, {'Content-Type': 'image/png'});
    res.end(image, 'binary');
    //*/
});
  
module.exports = router;