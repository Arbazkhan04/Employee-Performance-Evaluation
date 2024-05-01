const express = require('express')
const { getEmployeeByEmail, makeEmployee } = require('../controller/empController')

const route = express.Router()

// routes
route.route('/').get().post(makeEmployee)
route.route('/:email').get(getEmployeeByEmail)

module.exports = route