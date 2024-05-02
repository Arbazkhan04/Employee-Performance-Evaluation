const {disconnectDb, connectAnalysis} = require('../db/analysisdb.js')

const changeDb = async (err, req, res, next) => { 
    await disconnectDb()
    await connectAnalysis()
    next()
}

module.exports = changeDb