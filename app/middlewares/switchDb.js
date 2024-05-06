const { connectAnalysis } = require('../db/analysisdb.js')
const { disconnectDb } = require('../db/connect.js')

const changeDb = async (err, req, res, next) => { 
    await disconnectDb()
    await connectAnalysis()
    next()
}

module.exports = changeDb