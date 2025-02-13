var http = require("http")
var url = require("url")

http.createServer(function(req, res){
    res.writeHead(200, {'Content-Type': 'text/html'});
    var q = url.parse(req.url,true).query
    var text = q.company
    res.write("company is " + text)
}).listen(8000)