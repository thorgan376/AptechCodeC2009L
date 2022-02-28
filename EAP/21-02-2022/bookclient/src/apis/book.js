import { SERVER, PORT } from "./constants"
const URL_GET_BOOKS = `https://${SERVER}:${PORT}/api/books`
const axios = require('axios')
async function getAllBooks() {    
    //dung axios    
    try {
        debugger
        const response = await axios.get(URL_GET_BOOKS)
        return response.data
      } catch (error) {          
        console.error(error)
        return []
      }
}
export {
    getAllBooks
}