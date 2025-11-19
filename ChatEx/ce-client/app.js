var createError = require('http-errors');
var express = require('express');
var path = require('path');
var cookieParser = require('cookie-parser');
var logger = require('morgan');
var bodyParser = require('body-parser');

// Routers list
var indexRouter = require('./routes/index');  // Main Page
var usersRouter = require('./routes/users');  // Router for getting users (Not using)
var chatApi = require('./routes/chat');       // Dialogflow Routing
var fAppData = require('./routes/food-data'); // Food Database

// Express Engine Module
var app = express();

// view engine setup
app.set('views', path.join(__dirname, 'views'));
app.set('view engine', 'jade');

app.use(logger('dev'));
app.use(express.json());
app.use(express.urlencoded({ extended: false }));
app.use(cookieParser());
app.use(express.static(path.join(__dirname, 'public')));

app.use(bodyParser.json());
app.use(bodyParser.urlencoded({ extended: true }));

// declare using Routers
app.use('/', indexRouter);      // Main Page
app.use('/users', usersRouter); // Router for getting users (Not using)
app.use('/chat', chatApi);      // Dialogflow Routing
app.use('/food', fAppData);     // Food Database

// catch 404 and forward to error handler
app.use(function(req, res, next) {
  next(createError(404));
});

// error handler
app.use(function(err, req, res, next) {
  // set locals, only providing error in development
  res.locals.message = err.message;
  res.locals.error = req.app.get('env') === 'development' ? err : {};

  // render the error page
  res.status(err.status || 500);
  res.render('error');
});

/////

app.locals.pretty= true;    //웹페이지 코드 예쁘게 출력

/////

module.exports = app;
