const express = require('express')
const { getAllGroups, makeGroup, addEmployeeToGroup } = require('../controller/groupController')

const router = express.Router()

router.route('/').get(getAllGroups).post(makeGroup)
router.route('/:id').post(addEmployeeToGroup)

module.exports = router