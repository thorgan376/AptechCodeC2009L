const db = require('../database/db')
const {ProductModel} = db

const {sequelize, Sequelize} = db
const {Op, QueryTypes} = Sequelize

const insertProduct = async ({name, year, description}) => {
    try {
        let data = await ProductModel.create({name, year, description})                
        return {
            error: null, 
            errorMessage, 
            data: JSON.parse(JSON.stringify(data))
        }
    }catch(error) {
        const {name} = error
        const errorMessage = error.parent.sqlMessage
        return {error: name, errorMessage, data: {}}
    }    
}
const updateProduct = async ({id, name, year, description}) => {
    try {
        debugger
        let data = await ProductModel.update(
            {name, year, description},
            {
                where: 
                {
                    id: id
                }
            }
        )    
        debugger            
        return {
            error: null, 
            errorMessage: '', 
            data: {}
        }
    }catch(error) {
        debugger
        const {name} = error
        const errorMessage = error.message || error.parent.sqlMessage
        return {error: name, errorMessage, data: {}}
    }    
}
const queryProducts = async ({nameContain}) => {
    try {        
        let data = await ProductModel.findAll({where: {
            name: {
                [Op.like]: `%${nameContain}%`
            }
        }})              
        return {
            error: null, 
            errorMessage: '', 
            data
        }
    }catch(error) {        
        const {errorMessage} = error.parent
        return {error: error.name, errorMessage, data: {}}
    } 
}
const doSomething = async ({productId}) => {
    try {        
        debugger
        let result = await sequelize.query(
            'SELECT * FROM viewGetProduct WHERE id = $id',
            {
                bind: { id: productId },
                type: QueryTypes.SELECT
            }
        )
        debugger
    }catch(error) {        
        debugger
    } 
}
module.exports = {
    insertProduct,
    queryProducts,
    updateProduct, 
    doSomething
}
/**
 CREATE VIEW viewGetProduct AS
 SELECT * FROM Products;
 */