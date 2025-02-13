var http = require("http")
var dt = require("./datetime")

http.createServer(function(req, res){
    res.writeHead(200, {"content-type":"text/html"})
    res.write(dt.datetime())
}).listen(8000)