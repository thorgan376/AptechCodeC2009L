const express = require('express')
const router = express.Router()
const path = require('path')
const fs = require('fs')
const {
    insertProduct, 
    queryProducts,
    updateProduct,
    doSomething
} = require('../controllers/ProductController')

//http://localhost:3002/api/products/
router.get('/',async (req, res) => {        
    const {nameContain} = req.query    
    const response = await queryProducts({nameContain})    
    const {error, errorMessage, data } = response        
        if(error) {
            res.json({
                data: {},
                message: errorMessage,
                status: "failed"
            })
            return
        } 
        res.json({
            data: response.data,
            message: "Query product successfully",
            status: "ok"
        })        
})
//cac api khac
//them moi 1 san pham
//http://localhost:3002/api/products/
router.post('/', async (req, res) => {        
    const {name, year, description} = req.body    
    debugger
    const response = await insertProduct({ name, year, description })
        const {error, errorMessage, data } = response        
        if(error) {
            res.json({
                data: {},
                message: errorMessage,
                status: "failed"
            })
            return
        } 
        res.json({
            data: data,
            message: "Insert product successfully",
            status: "ok"
        })        
})
//Cap nhat thong tin san pham
//http://localhost:3002/api/products/
router.put('/', async (req, res) => {        
    const {id, name, year, description} = req.body    
    debugger
    const response = await updateProduct({id, name, year, description })
    debugger
    const { error, errorMessage, data } = response
    if (error) {
        res.json({
            data: {},
            message: errorMessage,
            status: "failed"
        })
        return
    }
    res.json({
        data: data,
        message: "Update product successfully",
        status: "ok"
    })        
})
//http://localhost:3002/api/products/getImage?fileName=meocondihoc.jpg
router.get('/getImage', async (req, res) => {
    await doSomething({productId: 3})
    let { fileName } = req.query
    const destination = `${path.join(__dirname, '..')}/uploads/${fileName}`
    try {
        fs.readFile(destination, function (err, data) {
            //if (err) => ?
            res.writeHead(200, { 'Content-Type': 'image/jpeg' });
            res.end(data); // Send the file data to the browser.
        });
    } catch (error) {
        //show error?
    }
})

//http://localhost:3002/api/products/uploads
router.post('/uploads', async (req, res) => {
    //Data is saved in req.files 
    //Insert this code inside try...catch, why?
    try {  
        debugger      
        if (!req.files || !Object.keys(req.files)) {
            //Cannot find files to upload
            return
        }        
        for (const [key, fileObject] of Object.entries(req.files)) {
            const {mv, mimetype, size, name} = fileObject
            let checkImageExist = true
            while(checkImageExist) {    
                const fileName = `${Math.random().toString(36)}`
                const fileExtension = name.split('.').pop()
                const destination = `${path.join(__dirname, '..')}/uploads/${fileName}.${fileExtension}`
                if(fs.existsSync(destination)) {
                    continue;
                }
                checkImageExist = false 
                //`${__dirnampath.dirname(__filename)e.join(__dirname, '..')}/uploads/${fileName}.${fileExtension}`
                let error = await mv(destination) //mv = move 
                debugger
                if (error) {
                    res.json({
                        result: "failed",
                        message: `Cannot upload files. Error: ${error}`
                    })
                    return
                }
            }
                         
        }
        res.json({
            data: {},
            message: "upload images successfully",
            status: "ok"
        })
    }catch(error) {
        res.json({
            data: {},
            message: "upload images failed"+error.toString(),
            status: "failed"
        })
    }
})
/**
 CREATE DATABASE cecomtech;
 use cecomtech
 CREATE TABLE Products(
     id INT PRIMARY KEY AUTO_INCREMENT,
     name VARCHAR(500) NOT NULL,
     year INT NOT NULL,
     description VARCHAR(500)
 );
 INSERT INTO Products(name, year, description)
 VALUES('iphone 6', 2016, 'ip6 cua toi');
 INSERT INTO Products(name, year, description)
 VALUES('iphone 5', 2015, 'ip5 cua toi');
 INSERT INTO Products(name, year, description)
 VALUES('iphone 4', 2014, 'ip4 cua toi');
 --alter table
 ALTER TABLE Products ADD UNIQUE (name); 

 INSERT INTO Products(name, year, description)
 VALUES('iphone 20', 2014, 'ip4 cua toi');
 */
module.exports = router