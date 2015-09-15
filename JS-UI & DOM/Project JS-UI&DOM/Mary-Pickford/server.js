var express = require('express');
var path = require('path');
var app = express();

//app.use(express.static(__dirname)); // Current directory is root
app.use(express.static(path.join(__dirname, 'Source')));
app.use(function(req, res, next) {
  res.header("Access-Control-Allow-Origin", "*");
  res.header("Access-Control-Allow-Headers", "Origin, X-Requested-With, Content-Type, Accept");
  next();
});

app.use(function (req, res, next) {
  res.setHeader('Access-Control-Allow-Origin', '*');
  res.setHeader('Access-Control-Allow-Methods', 'GET, POST, OPTIONS, PUT, PATCH, DELETE');
  res.setHeader('Access-Control-Allow-Headers', 'X-Requested-With,content-type');
  res.setHeader('Access-Control-Allow-Credentials', true);
  next();
});

app.get('/', function(req, res, next) {
    res.send('index.html');
});

app.listen(process.env.PORT ||5000);
console.log('Listening on port 5000!');
