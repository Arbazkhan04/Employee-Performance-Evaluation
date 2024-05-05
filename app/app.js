const sql = require("mssql/msnodesqlv8")
const express = require("express")
const app = express();



var config = {
  connectionString: 'Driver=SQL Server;Server=DESKTOP-55MSIKV\\SQLEXPRESS;Database=EPE_New;Trusted_Connection=true;'
};

sql.connect(config, function (err) {
    if (err) {
        console.log(err);
    }
    else {
        console.log("Connected to SQL Server");
    }
})


app.get("/", (request, response) => {
    // Execute a SELECT query
    new sql.Request().query("SELECT * FROM Department", (err, result) => {
        if (err) {
            console.error("Error executing query:", err);
        } else {
            response.send(result.recordset); // Send query result as response
            console.dir(result.recordset);
        }
    });
});


const port = 3000
app.listen(port, () => {
    console.log(`Server is listening on port ${port}...`)
});