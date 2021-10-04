import React from 'react'
import ReactDOM from 'react-dom'
import MainScreen from './screens/MainScreen'
import reportWebVitals from './reportWebVitals'

ReactDOM.render(
  <React.StrictMode>
    <MainScreen 
      x = {2} y = {3} 
      person={{name: 'Hoang', email: 'hoang@gmail.com'}}
      products={[
        {
          name: 'dien thoai cam ung x',
          year: 2019
        },
        {
          name: 'iphone 7',
          year: 2017
        },
        {
          name: ' dien thoai iphone 6',
          year: 2016
        }
    ]}
      />
  </React.StrictMode>,
  document.getElementById('root')
);

reportWebVitals();
