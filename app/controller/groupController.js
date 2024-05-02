const sql = require("mssql/msnodesqlv8");

const getAllGroups = async (req, res) => { 
    const query = `SELECT * FROM Groups`
    new sql.Request().query(query, (err, result) => {
        if (err) {
            console.error("Error executing query:", err);
        } else {
            res.status(200).json({ groups: result.recordset });
        }
    });
}


// pass a supervisor id in body for making a group
const makeGroup = async (req, res) => {
    const { supervisorId } = req.body;
    const query = `INSERT INTO Groups (supervisorId) VALUES (${supervisorId})`
    new sql.Request().query(query, (err, result) => {
        if (err) {
            console.error("Error executing query:", err);
        } else {
            res.status(200).json({ message: "Group created successfully" });
        }
    });
}

// pass employee id and group id to add in a group
const addEmployeeToGroup = async (req, res) => { 
    const { empId, groupId } = req.body;
    const query = `INSERT INTO GroupEmployee (Group_id, Employee_id, DateJoined) VALUES (${groupId}, ${empId}, ${new Date()})`
    new sql.Request().query(query, (err, result) => {
        if (err) {
            console.error("Error executing query:", err);
        } else {
            res.status(200).json({ message: "Employee added to group successfully" });
        }
    });
}

module.exports = {
    getAllGroups,
    makeGroup,
    addEmployeeToGroup
}