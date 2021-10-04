console.log('haha')
function sum2Numbers(x, y) {
    console.log('this is a sum')
    debugger
    return x + y
}
console.log(`sum 3 and 3 is : ${sum2Numbers(2,3)}`)
//nhan request
//viet thanh cac module
const express = require('express')
const app = express()

// respond with "hello world" when a GET request is made to the homepage
app.get('/hello', function (req, res) {
  res.json({
      x: 10,
      y: 20
  })
})
const PORT = 3000
app.listen(PORT, () => {
    console.log(`Example app listening at http://localhost:${PORT}`)
})


