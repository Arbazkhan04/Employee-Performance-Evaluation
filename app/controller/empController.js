const sql = require("mssql/msnodesqlv8")

const getEmployeeByEmail = async (req, res) => {
    const { email } = req.params
    const query = `SELECT * FROM Person WHERE Email='${email}'`
    new sql.Request().query(query, (err, result) => {
        if (err) {
            console.error("Error executing person query:", err);
        } else {
            const personId = result.recordset[0].id
            const query = `SELECT * FROM Employee WHERE User_id='${personId}'`
            new sql.Request().query(query, (err, empresult) => { 
                if (err) {
                    console.error("Error executing employee query:", err);
                } else {
                    console.log(empresult.recordset[0].Empl_id)
                    const supervisorQuery = `select * from supervisor where Employee_id='${empresult.recordset[0].Empl_id}'`
                    new sql.Request().query(supervisorQuery, (err, supervisorResult) => {
                        if (err) {
                            console.error("Error executing supervisor query:", err);
                        } else {
                            if (supervisorResult.recordset.length > 0) {
                                res.json({ emp_id: empresult.recordset[0].Empl_id, Supervisor_id: supervisorResult.recordset[0].Supervisor_id })
                            } else {
                                res.json({ emp_id: empresult.recordset[0].Empl_id });
                            }
                            
                        }
                    });
                }
            });
        }
    });
}

const makeEmployeeSupervisor = async (req, res) => { 
    const { emp_id } = req.body
    const query = `INSERT INTO supervisor VALUES('${emp_id}')`
    new sql.Request().query(query, (err, result) => { 
        if (err) {
            console.error("Error executing query:", err);
        } else {
            res.send('Supervisor added!'); 
        }
    })
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
    makeEmployee,
    makeEmployeeSupervisor
}