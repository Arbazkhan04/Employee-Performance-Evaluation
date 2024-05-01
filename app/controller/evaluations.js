const sql = require("mssql/msnodesqlv8")

// connecting to analysis database
const connectAnalysis = async () => {
    var config = {
        connectionString: 'Driver=SQL Server;Server=DESKTOP-55MSIKV\\SQLEXPRESS;Database=EPE_Analysis;Trusted_Connection=true;'
    };
    sql.connect(config, function (err) {
        if (err) {
            console.log(err);
        }
        else {
            console.log("Connected to SQL Server Analysis Database");
        }
    });
}

const evaluateEmployee = async (req, res) => { 
    await connectAnalysis()
    const { emp_id, metric_id, rating, remarks } = req.body
    const query = `INSERT INTO Evaluation (Employee_id, Metric_id, rating, DateOfEvaluation, Remarks) VALUES (${emp_id}, ${metric_id}, ${rating}, ${new Date()}, '${remarks}')`
    sql.query(query, function (err, result) {
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
    const query = `INSERT INTO GroupEvaluation (Group_id, Metric_id, rating, DateOfEvaluation, Remarks) VALUES (${group_id}, ${metric_id}, ${rating}, ${new Date()}, '${remarks}')`
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
    evaluateEmployee, 
    evaluateGroup
}