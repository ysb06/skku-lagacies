var ws = new WebSocket("ws://localhost:3001");

ws.onopen = function(event) {
    ws.send("Client message: Hi!");
}

ws.onmessage = function(event) {
    console.log('Server message: ', event.data);

    var result = document.getElementById('output');
    var recv = document.createElement('div');
    recv.setAttribute('class', 'chat');
    recv.innerHTML = 'dat: ' + event.data;
    result.appendChild(recv);
}

ws.onerror = function(event) {
    console.log("Server error message: ", event.data);
}

//Websocket 대신 DOM과 XMLHttpRequest를 사용하여 GET, POST 요청 및 콜백 구현
//서버에서는 순수하게 GET, POST 요청 처리 구현
//WebSocket 버려