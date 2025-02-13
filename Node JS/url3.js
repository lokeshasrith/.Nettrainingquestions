var http = require("http")
var url = require("url")

http.createServer(function(req,res){
    res.writeHead(200, {"content-type":"text/html"})
    var q = url.parse(req.url,true).query;
    var result = q.firstname + " " + q.lastname
    res.write(result)
    res.end();
}).listen(8080)