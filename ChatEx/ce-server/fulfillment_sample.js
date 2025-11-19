/**
 * Responds to any HTTP request that can provide a "message" field in the body.
 *
 * @param {!Object} req Cloud Function request context.
 * @param {!Object} res Cloud Function response context.
 */
const http = require('http');
 
exports.helloHttp = function helloHttp (request, response) {
	console.log('Dialogflow Fulfilment(Request Info): ');
	console.log(request.body.queryResult);
	let intent = request.body.queryResult.intent.displayName;
	console.log('Dialogflow Fulfilment(Intent): ' + intent);
    var currentDate = new Date();
	
	if(intent == 'attending-test.ask-location') {		//출석고사 위치 문의
		//*
		
		//추후 가능하다면 등록 안된 기수에 따른 에러 발생 부분을 수정할 것(intent 인식에 필요한 부분)
		let locationData = request.body.queryResult.parameters.attendingTest_region;
		let classTime = request.body.queryResult.parameters.attendingTest_classTime;

		console.log('Dialogflow Fulfilment(Intent query): ' + classTime + '(' + typeof(classTime) + '), ' + locationData + '(' + typeof(locationData) + ')');
		
		if(classTime === undefined || classTime == '' || classTime === null) {
			classTime = '2018년 3기'; //추후 최신의 기수를 받아와서 넣을 수 있도록 수정
		}
		
		getTestLocation(locationData, classTime).then((testLocation) => {
			console.log('Dialogflow Fulfilment(User intent): Asking attending test location');
			let text = '예, ' + classTime + ' ' + locationData + '지역의 시험 장소는 ' + testLocation + '입니다.';
			response.json({ fulfillmentText: text });
            response.json({ fulfillmentText: '감사합니다.' });
		}).catch(() => {
			response.json({ fulfillmentText: '죄송합니다. 서버에서 해당 정보가 조회가 되지 않네요. 나중에 다시 물어봐 주세요.' });
		});
		//*/
			
	} else if(intent == 'attending-test.change-date.confirm') {			//출석고사 일정 변경 문의
		
		let className = request.body.queryResult.parameters.className;
		var credit4 = checkCredit(className);
		
		if(credit4) {
			response.json({ fulfillmentText: '출석고사 일정을 변경하기 위해서는 강의를 다른 기수로 연기해야 합니다. 나의 강의실 – 수강 연기/변경– 연기 신청 접수 에서 하실 수 있습니다.' });
		} else {
			response.json({ fulfillmentText: '1~3학점 강좌는 출석고사가 없습니다. 하지만 강의를 연기하기 원하시면 나의 강의실 – 수강 연기/변경– 연기 신청 접수 에서 하실 수 있습니다.' });
		}
		
	} else if(intent == 'attending-test.change-place.confirm') {				//출석고사 장소 변경 문의
		
		let className = request.body.queryResult.parameters.className;
		var credit4 = checkCredit(className);
		
		if(credit4) {
			response.json({ fulfillmentText: '나의 강의실 – 진행연수의 수강하기– 출석고사 –고사장변경 에서 출석고사장을 변경하실 수 있습니다.' });
		} else {
			response.json({ fulfillmentText: '1~3학점 강좌는 출석고사가 없습니다. 나의 강의실 – 진행연수의 수강하기 에서 관련 내용 확인하실 수 있습니다.' });
		}
		
	} else {
		response.json({ fulfillmentText: '죄송합니다. 질문의 의도를 잘 모르겠네요. 제가 모르는 건 챗봇 개발자가 잘못했을 거에요.' });
	}
};

function checkCredit(className) {
	if(className == '알기쉬운 교직 실무' || className == '눈으로 배우고 이야기로 즐기는 한국사') {
		return true;
	} else {
		return false;
	}
}

function getTestLocation (region, classTime) {
	return new Promise((resolve, reject) => {
		//http://10.10.11.39:8080/lecture/api/getAPISearchTestGroundList.edu?semesterCode=TV_2018G_4&areaName= (region)
		
		let locationParam = encodeURIComponent(region);
		let classParam = encodeURIComponent(classTime)
		
		var option = {
			host:'www.teacherville.co.kr',
			path:'/lecture/api/getAPISearchTestGroundList.edu?semesterName=' + classParam + '&areaName=' + locationParam
		};
		
		console.log('Dialogflow Fulfilment(API Request): ' + option.host + option.path);
		console.log('Dialogflow Fulfilment(Final request): ' + classTime + ', ' + region);
		
		http.get(option, (response) => {
			console.log(response);
			let body = '';
			response.on('data', (d) => { body += d; }); // store each response chunk
            response.on('end', () => {
                console.log(body);
				let bodyJSON = JSON.parse(body);
				console.log(bodyJSON);
				let testDate = bodyJSON[0]['scheduleDate'];
				let testLocation = bodyJSON[0]['schoolName'];
				let testLocationGuidance = bodyJSON[0]['trafficMeans'];
				
                resolve(testLocation);
            });
            response.on('error', (error) => {
                console.log('Error calling the API: ${error}');
                reject();
            });
		});
	});
}


function callSampleApi () {
	return new Promise((resolve, reject) => {
		var option = {
			host:'www.teacherville.co.kr',
			path:'/lecture/api/getSearchCourseList.edu?id=peckcho'
		};
		console.log('API Request(Sample): ' + option.host + option.path);
		
		http.get(option, (response) => {
			console.log(response);
			let body = '';
			response.on('data', (d) => { body += d; }); // store each response chunk
            response.on('end', () => {
                console.log('Sample: ' + body);
				let bodyJSON = JSON.parse(body);
				let title = bodyJSON[0]['title'];
				let grade = bodyJSON[0]['grade'];
				let icons = bodyJSON[0]['icons'];
				console.log(title + ', ' + grade);
                resolve(grade);
            });
            response.on('error', (error) => {
                console.log('Error calling the API: ${error}');
                reject();
            });
		});
	});
}