'use strict';

const http = require('http');
const functions = require('firebase-functions');
 
exports.dialogflowFirebaseFulfillment = functions.https.onRequest((request, response) => {

    let fulfillment = request.body.queryResult;
    let currentIntent = fulfillment.intent;
    var currentDate = new Date();

    console.log(currentIntent.name);

    if(currentIntent.displayName == 'attending-test.ask-location') {
        console.log('No');
    }
    else if(currentIntent.displayName == 'answer.teasing') {
        console.log(fulfillment);
        response.json({ fulfillmentText: '꺼져' });
    }
});

//exports.helloHttp.call(null, null);
//https://cloud.google.com/dialogflow/docs/fulfillment-how