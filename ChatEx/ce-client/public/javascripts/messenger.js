var xmlHttp = new XMLHttpRequest();
var chatSession = '';

xmlHttp.onreadystatechange = function() {
    if(this.status == 200 && this.readyState == this.DONE) {
        var resbody = JSON.parse(xmlHttp.response);
        appendResponse(resbody.text);
        chatSession = resbody.sessionId;

        console.log('res: ' + resbody.text + ', ' + chatSession)
    }
};

function checkPressedEnter() {
    if(event.keyCode == 13) {
        chatRequest();
    }
}

function chatRequest() {
    var messege = document.getElementById("talk-input");
    var messegeValue = messege.value;

    //메시지 내용이 없을 경우 코드 종료
    if(messegeValue == "") {
        console.log('No text input')
        return;
    }

    //Session ID가 없을 경우 생성
    if(chatSession == '') {
        var charList = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        var now = new Date();

        chatSession += 'cs' + now.toISOString();
        for( var i=0; i < 5; i++ )
            chatSession += charList.charAt(Math.floor(Math.random() * charList.length));
    }
    //언어 인식
    var lenCode = navigator.language || navigator.userLanguage;

    //Request body 생성
    var postBody = JSON.stringify({ 
        queryText: messegeValue,
        sessionId: chatSession,
        language: lenCode
    });

    xmlHttp.open('POST', '/chat', true);
    xmlHttp.setRequestHeader('Content-Type', 'application/json;charset=UTF-8');
    xmlHttp.send(postBody);

    appendRequest(messegeValue);
    messege.value = "";
}

function appendResponse(text) {
    var result = document.getElementById('chat-log');
    var recv = document.createElement('div');
    recv.setAttribute('class', 'agent-response');
    recv.innerHTML = text;
    result.appendChild(recv);
    result.scrollTop = result.scrollHeight;
}

function appendRequest(text) {
    var result = document.getElementById('chat-log');
    var recv = document.createElement('div');
    recv.setAttribute('class', 'client-request');
    recv.innerHTML = text;
    result.appendChild(recv);
    result.scrollTop = result.scrollHeight;
}

//추후 card등 다양한 기능에 대해 대응