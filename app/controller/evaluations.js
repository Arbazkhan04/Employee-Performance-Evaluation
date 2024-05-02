const sql = require("mssql/msnodesqlv8")
const { connectAnalysis, disconnectDb } = require('../db/analysisdb.js')


const getEvaluations = async (req, res) => { 
    const query = `SELECT * FROM Evaluation`
    await sql.query(query, function (err, result) {
        if (err) {
            console.log(err)
            res.status(500).send("Internal Server Error")
        }
        else {
            res.status(200).send(result.recordset[0].CurrentDatabase)
        }
    });
    await disconnectDb()
}

const evaluateEmployee = async (req, res) => { 
    await connectAnalysis()
    const { emp_id, metric_id, rating, remarks } = req.body
    const query = `INSERT INTO Evaluation (Employee_id, Metric_id, rating, DateOfEvaluation, Remarks) VALUES (${emp_id}, ${metric_id}, ${rating}, getdate(), '${remarks}')`
    await sql.query(query, function (err, result) {
        if (err) {
            console.log(err)
            res.status(500).send("Internal Server Error")
        }
        else {
            res.status(201).send("Evaluation added successfully")
        }
    });
}

const evaluateGroup = async (req, res) => { 
    await connectAnalysis()
    const { group_id, metric_id, rating, remarks } = req.body
    const query = `INSERT INTO GroupEvaluation (Group_id, Metric_id, rating, DateOfEvaluation, Remarks) VALUES (${group_id}, ${metric_id}, ${rating}, getdate(), '${remarks}')`
    sql.query(query, function (err, result) {
        if (err) {
            console.log(err)
            res.status(500).send("Internal Server Error")
        }
        else {
            res.status(201).send("Group Evaluation added successfully")
        }
    });
}

module.exports = {
    getEvaluations,
    evaluateEmployee, 
    evaluateGroup
}