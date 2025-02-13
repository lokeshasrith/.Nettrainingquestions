var http = require("http")
var Hi = require("./Hi")

http.createServer(function (req, resp){
    resp.writeHead(200, {"content-type":"text/html"})
    resp.write(Hi.hello());
    resp.end()
}).listen(8000)