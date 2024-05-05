const sql = require("mssql/msnodesqlv8")

var config = {
  connectionString: 'Driver=SQL Server;Server=DESKTOP-J0LBO7T;Database=EPE_NEW;Trusted_Connection=true;'
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

module.exports = {connect}