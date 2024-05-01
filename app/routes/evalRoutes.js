const express = require('express')
const { connect } = require('../db/connect.js')
const { evaluateEmployee, evaluateGroup } = require('../controller/evaluations.js')

const router = express.Router()

router.route('/employee').post(evaluateEmployee)
router.route('/group').post(evaluateGroup)

connect()

module.exports = router