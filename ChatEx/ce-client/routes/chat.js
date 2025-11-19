var express = require('express');
var router = express.Router();

// Dialogflow API, 사전에 gcloud 설치 및 project 초기화 그리고 인증 작업까지 마쳐야 작동
const dialogflow = require('dialogflow');
const sessionClient = new dialogflow.SessionsClient();
const projectId = 'csproject-1b085';

/* GET home page. */
router.post('/', function(req, res, next) {  
  //Dialogflow 요청(동기화)
  var sessionIdCode = req.body.sessionId;
  var query = req.body.queryText;
  console.log(req.body);

  //요청 생성
  const request = {
    session: sessionClient.sessionPath(projectId, sessionIdCode),
    queryInput: {
      text: {
        text: query,
        languageCode: req.body.language
      },
    },
  };

  //Dialogflow API, Detect Intent 요청
  console.log('\n----------')
  sessionClient
    .detectIntent(request)
    .then(response => {
      var result = response[0].queryResult;
      console.log('Intent Detected');
      console.log(`    Session ID: ${sessionIdCode}`);
      console.log(`    Query Text: ${query}`);
      console.log(`    Detected Intent: ${result.intent.displayName}`);
      console.log(`    Response: ${result.fulfillmentText}`);

      //카드 등 기능 추가 필요에 대비

      //클라이언트 회신
      var responseBody = JSON.stringify({ 
        text: result.fulfillmentText,
        sessionId: sessionIdCode
      });

      res.send(responseBody);
      console.log('----------')
    })
    .catch(err => {
      //서버 에러 메시지 수신
      console.log(`Intent Detecting Failed: `);
      console.log(`    Session ID: ${sessionIdCode}`);
      console.log(`    Query Text: ${query}`);
      console.log(`Error: `, err);
      console.log(`----------`);
    });
});

module.exports = router;