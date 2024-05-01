const sql = require("mssql/msnodesqlv8")


const getAllDepartments = (req, res) => {
    new sql.Request().query("SELECT * FROM Department", (err, result) => {
        if (err) {
            console.error("Error executing query:", err);
        } else {
            res.send(result.recordset); // Send query result as response
            console.dir(result.recordset);
        }
    });
}

module.exports = {getAllDepartments}