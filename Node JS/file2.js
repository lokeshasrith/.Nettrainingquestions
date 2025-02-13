var fs = require("fs")

fs.appendFile("file.txt","this is mee added content",
    function(err){
        if(err)throw err
        console.log("file is added........")
    }
)