var http = require("http");
var url = require("url");

http.createServer(function(req, resp) {
    resp.writeHead(200, {"Content-Type": "text/html"});
    var q = url.parse(req.url, true).query;
    var text = q.name + " " + q.city;
    resp.write(text + "<br>");
    resp.end("Node JS.....");
}).listen(8000);

