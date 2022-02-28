import './BookList.css'
import 'bootstrap/dist/css/bootstrap.min.css'
import React, { useState, useEffect } from 'react'
import { getAllBooks } from '../apis/book'

//quan ly state
function BookList(props) {
    const [books, setBooks] = useState([])
    useEffect(()=>{
        debugger
        getAllBooks().then(responseBooks => {
            setBooks(responseBooks)
        })
    }, [])
    const {x, y} = props
    return <div>            
        <div class="page-header">
            <h1>BookService</h1>
        </div>
        <div class="row">
            <div class="col-md-4">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        <h2 class="panel-title">Books</h2>
                    </div>
                    <div class="panel-body">
                        <ul class="list-unstyled">
                            {books.map(eachBook => <li>
                                <strong><span>{eachBook.AuthorName}</span></strong>: 
                                    <span>{eachBook.Title}</span>
                                <small><a href="#">Details</a></small>
                            </li>)}                            
                        </ul>
                    </div>
                </div>
                <div class="alert alert-danger" data-bind="visible: error"><p data-bind="text: error"></p></div>
            </div>
            <div class="col-md-4">
            </div>
            <div class="col-md-4">
            </div>
        </div>
    </div>
}
export default BookList