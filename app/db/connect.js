const sql = require("mssql/msnodesqlv8")

var config = {
  connectionString: 'Driver=SQL Server;Server=DESKTOP-4UIPFLP;Database=EPE;Trusted_Connection=true;'
};
const connect = async () => {
  sql.connect(config, function (err) {
    if (err) {
      console.log(err);
    }
    else {
      console.log("Connected to SQL Server");
    }
  })
}

const disconnectDb = async () => {
  await sql.close()
  console.log("Disconnected from SQL Server")
}

module.exports = {connect, disconnectDb}