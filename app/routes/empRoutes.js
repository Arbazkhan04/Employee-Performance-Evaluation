const express = require('express')
const { getEmployeeByEmail, makeEmployee, makeEmployeeSupervisor } = require('../controller/empController')

const route = express.Router()

// routes
route.route('/').post(makeEmployee)
route.route('/:email').get(getEmployeeByEmail)
route.route('/supervisor').post(makeEmployeeSupervisor)

module.exports = route