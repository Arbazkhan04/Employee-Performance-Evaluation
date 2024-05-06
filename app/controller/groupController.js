const sql = require("mssql/msnodesqlv8");

const getAllGroups = async (req, res) => { 
    const query = `SELECT * FROM Groups`
    new sql.Request().query(query, (err, result) => {
        if (err) {
            console.error("Error executing query:", err);
            res.status(500).json({ message: "Error executing query" });
        } else {
            res.status(200).json({ groups: result.recordset });
        }
    });
}


// pass a supervisor id in body for making a group
const makeGroup = async (req, res) => {
    const { name, supervisorId, depart } = req.body;
    const query = `INSERT INTO Groups (Name, Department_id, Supervisor_id, DateCreated, Status_id) VALUES ('${name}', ${depart}, ${supervisorId}, getdate(), ${3})`
    new sql.Request().query(query, (err, result) => {
        if (err) {
            console.error("Error executing query:", err);
            res.status(500).json({ message: "Error executing query" });
        } else {
            res.status(200).json({ message: "Group created successfully" });
        }
    });
}

// pass employee id and group id to add in a group
const addEmployeeToGroup = async (req, res) => { 
    const { empId, groupId } = req.body;
    const query = `INSERT INTO GroupEmployee (Group_id, Employee_id, DateJoined) VALUES (${groupId}, ${empId}, getdate())`
    new sql.Request().query(query, (err, result) => {
        if (err) {
            console.error("Error executing query:", err);
            res.status(500).json({ message: "Error executing query" });
        } else {
            res.status(200).json({ message: "Employee added to group successfully" });
        }
    });
}

// delete employee from group
const deleteEmployeeFromGroup = async (req, res) => { 
    const { empId, groupId } = req.body;
    const query = `DELETE FROM GroupEmployee WHERE Group_id = ${groupId} AND Employee_id = ${empId}`
    new sql.Request().query(query, (err, result) => {
        if (err) {
            console.error("Error executing query:", err);
            res.status(500).json({ message: "Error executing query" });
        } else {
            res.status(200).json({ message: "Employee deleted from group successfully" });
        }
    });
}

module.exports = {
    getAllGroups,
    makeGroup,
    addEmployeeToGroup,
    deleteEmployeeFromGroup
}