var http = require("http");
var hello = require("./hello");
http.createServer(function (req, res) {
    res.writeHead(200, { "Content-Type": "text/html" });
    res.write(hello.Hell0());
    res.end();
}).listen(8282);
