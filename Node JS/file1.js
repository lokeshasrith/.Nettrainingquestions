var fs = require("fs")

fs.writeFileSync("file.txt","milestone is a head",
    function(err) {
        if (err) throw err;
        console.log("file successfully created")
    }
)