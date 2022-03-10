const databaseConfigure = require('./db.config')
const Sequelize = require('sequelize')
debugger
const sequelize = new Sequelize(
    databaseConfigure.DB, 
    databaseConfigure.USER,
    databaseConfigure.PASSWORD,
    {
        host: databaseConfigure.HOST,
        dialect: databaseConfigure.dialect
    },
    
)
const db = {Sequelize, sequelize}
//Tao ra model de mapping
db.ProductModel = require('../models/Product')(Sequelize, sequelize)
//other models
sequelize.sync()
module.exports = db

