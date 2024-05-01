const express = require('express')
const { connect } = require('./db/connect.js')


const app = express()


app.get("/", (req, res) => {
    res.send("home")
});


app.use('/employee', require('./routes/empRoutes.js'))
app.use('/group', require('./routes/groupRoutes.js'))

const port = process.env.PORT || 3000

const start = async () => {
    try {
        await connect()
        app.listen(port, () => {
            console.log(`Server is listening on port ${port}...`)
        });
    }
    catch (err) {
        console.log(err)
    }
}

start()