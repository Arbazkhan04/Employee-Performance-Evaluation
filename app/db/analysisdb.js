const sql = require("mssql/msnodesqlv8")

// connecting to analysis database
const connectAnalysis = async () => {
    var config = {
        connectionString: 'Driver=SQL Server;Server=DESKTOP-55MSIKV\\SQLEXPRESS;Database=EPE_Analysis;Trusted_Connection=true;'
    };
    await sql.connect(config, function (err) {
        if (err) {
            console.log(err);
        }
        else {
            console.log("Connected to SQL Server Analysis Database");
        }
    });
}

// disconnect from database
const disconnectAnalysisDb = async () => {
    await sql.close()
}

module.exports = {
    connectAnalysis,
    disconnectAnalysisDb
}