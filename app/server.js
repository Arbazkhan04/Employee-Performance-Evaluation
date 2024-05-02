const express = require('express')
const { connect } = require('./db/connect.js')
const cors = require('cors')

const app = express()
app.use(express.json())
app.use(cors())

app.get("/", (req, res) => {
    res.send("home")
});


app.use('/employee', require('./routes/empRoutes.js'))
app.use('/group', require('./routes/groupRoutes.js'))
app.use('/evaluation', require('./routes/EvalRoutes.js'))

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