const express = require('express');
const router = express.Router();

const Knex = require('knex');
const knex_database = connectDB();

const fs = require('fs');
const request = require('request');

function connectDB() {
    const config = {
      user: 'food_server',
      password: 'temp1234',
      database: 'food_data', // e.g. 'my-database'
    };
  
    //config.host = '/cloudsql/csproject-1b085:asia-east1:food-list';
    config.host = '127.0.0.1';
  
    // Establish a connection to the database
    const knex = Knex({
      client: 'pg',
      connection: config,
    });

    knex.client.pool.max = 5;
    knex.client.pool.min = 5;
    knex.client.pool.createTimeoutMillis = 30000; // 30 seconds
    knex.client.pool.idleTimeoutMillis = 600000; // 10 minutes
    knex.client.pool.createRetryIntervalMillis = 200; // 0.2 seconds
    knex.client.pool.acquireTimeoutMillis = 600000; // 10 minutes

    return knex;
  }
  

router.get('/', function(req, res, next) {
    var food = req.query.name;
    console.log(food);

    knex_database('food_list').select('id', 'name', 'content', 'pic_src').where({name: food})
    .then(function (result) {
        res.send(result);
    })
    .catch(function (err) {
      res.send('Error!!');
    });
});

router.get('/image/:filename', function(req, res, next) {
  downloadFile('csproject-1b085.appspot.com', 'food001.png', 'food001.png').then(function(result) {
    res.end(result, 'binary');
  });
});
  
module.exports = router;

async function downloadFile(bucketName, srcFilename, destFilename) {
  const {Storage} = require('@google-cloud/storage');
  const storage = new Storage();

  var buffer = await storage
    .bucket(bucketName)
    .file(srcFilename)
    .download();

  //return `gs://${bucketName}/${srcFilename} downloaded to ${destFilename}.`
  //https://storage.googleapis.com/cs-food-image/food001.png
  
  return new Promise();
}