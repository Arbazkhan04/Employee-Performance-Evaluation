const express = require('express')
const { getAllGroups, makeGroup, addEmployeeToGroup, deleteEmployeeFromGroup } = require('../controller/groupController')

const router = express.Router()

router.route('/').get(getAllGroups).post(makeGroup).delete(deleteEmployeeFromGroup)
router.route('/:id').post(addEmployeeToGroup)


module.exports = router