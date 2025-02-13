var http = require("http");

http.createServer(function (req, resp) {
    resp.writeHead(200, {'Content-Type': 'text/html'});
    resp.end("Welcome to Node Js...");
}).listen(8080);

/*
This is a simple **Node.js** program that creates a basic web server. Let me break it down for you:

1. **Import HTTP Module**
    ```js
    var http = require("http");
    ```
   - This line loads Node.js’s built-in **http module** so we can create a web server.

2. **Create a Server**
    ```js
    http.createServer(function (req, resp) {
    ```
    - This creates a server that listens for requests (`req`) and sends responses (`resp`).

3. **Set Response Header*
    ```js
    resp.writeHead(200, {'Content-Type': 'text/html'});
    ```
    - This tells the browser that the response will be **HTML** and the status is **200** (which means "OK").

4. **Send Response Data**
    ```js
    resp.end("Welcome to Node Js...");
    ```
    - This sends `"Welcome to Node Js..."` to the browser.

5. **Listen on Port 8080**
    ```js
    }).listen(8080);
    ```
   - This makes the server **listen on port 8080**, meaning you can access it by opening `http://localhost:8080` in a browser.

### What happens when you run this?
- Open your **browser** and go to `http://localhost:8080`
- You will see **"Welcome to Node Js..."** displayed on the page. 🎉
*/