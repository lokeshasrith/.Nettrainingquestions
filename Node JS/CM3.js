var http = require("http")
var name = require("./var")

http.createServer(function (req,res){
    res.writeHead(200, {"content-type":"text/html"})
    res.write(name.show("Lokesh","Asrith"))
    res.end
}).listen(8000)