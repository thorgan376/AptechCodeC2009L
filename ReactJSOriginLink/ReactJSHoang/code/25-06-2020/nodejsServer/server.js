//npm install --save express body-parser cors mysql2 sequelize express-fileupload path fs
const express = require("express")
const bodyParser = require("body-parser")
const fileUpload = require('express-fileupload')

const cors = require("cors")//Cross-Origin Resource Sharing
const app = express()

app.use(cors({origin: "http://localhost:8001"}))
app.use(bodyParser.json()) // parse requests of content-type - application/json
app.use(bodyParser.urlencoded({ extended: true }))
app.use(fileUpload({
	limits: { fileSize: 50 * 1024 * 1024 }, //Maximum = 50 MB 
}))

//routers 
const productRouter = require('./routers/product')
app.use('/api/products', productRouter)

//http://localhost:3002/
//Gui bang POSTMAN 
app.get("/", (req, res) => {// simple route
    const {params, query, body} = req    
    let {name, age } = query    
    age = isNaN(query.age) ? age : parseInt(age)
    debugger
    res.json({ message: "Hello World" })//let debug for testing
})
const PORT = 3002 // set port, listen for requests
app.listen(PORT, () => {
	console.log(`Server is running on port ${PORT}.`)
})
