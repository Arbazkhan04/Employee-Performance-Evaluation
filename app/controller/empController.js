const sql = require("mssql/msnodesqlv8")

const getEmployeeByEmail = async (req, res) => {

}


// send personid as user_id, name, department id and designation id in body
const makeEmployee = async (req, res) => {
    const { user_id, name, department, designation } = req.body
    const query = `INSERT INTO employee VALUES('${user_id}', '${name}', '${department}', '${designation}')`
    new sql.Request().query(query, (err, result) => {
        if (err) {
            console.error("Error executing query:", err);
        } else {
            res.send('Employee added!'); 
        }
    });
}

module.exports = {
    getEmployeeByEmail,
    makeEmployee
}