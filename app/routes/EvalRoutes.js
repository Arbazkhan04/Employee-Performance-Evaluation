const express = require('express')
const { connect } = require('../db/connect.js')
const { evaluateEmployee, evaluateGroup, getEvaluations } = require('../controller/evaluations.js')
const changeDb = require('../middlewares/switchDb.js')

const router = express.Router()

router.route('/employee').get(getEvaluations).post(evaluateEmployee)
router.route('/group').post(evaluateGroup)

connect()

module.exports = router