$(document).ready(function() {
    //after loaded index.html, come to here    
    var x = 10
    var y = x
    console.log(`gia tri y = ${y}`)
    x = 11
    console.log(`y = ${y}`)
    var person1 = {
        name: 'Hoang',
        age: 18
    }
    //var person2 = person1
    //clone an object 
    var person2 = {...person1}
    var songs = []
    person1.age = 19
    console.log(`person1 = ${JSON.stringify(person1)}`)
    console.log(`person2 = ${JSON.stringify(person2)}`)
    person1 = person2
    console.log('after kill p1')
    console.log(`person1 = ${JSON.stringify(person1)}`)
    console.log(`person2 = ${JSON.stringify(person2)}`)

    console.log(`Gia tri cua x la : ${x}`)
    function sum(x, y) {
        return x + y
    }

    songs.push({
        name: 'Hoa hai duong',
        author: 'Jack',
        year: 2020
    })
    songs.push({
        name: 'Chay ngay di',
        author: 'M-TP',    
        year: 2018
    })
    songs.push({
        name: 'Chay di',
        author: 'M-TP',
        isExist: false,
        year: 2018
    })
    console.log(`cac bai hat la: ${JSON.stringify(songs)}`)
    //JSON = Javascript Object Notation
    /*
    alert(`sum 2 and 3 is : ${sum(2,3)}`)
    alert("sum 2 and 3 is : "+sum(2,3))
    */
    function pressCalculate() {
        let inputX = document.getElementById("x")
        let inputY = document.getElementById("y")
        if(inputX.value == "" 
            || inputY.value == ""
            || isNaN(inputX.value) == true
            || isNaN(inputY.value) == true
            ) {
            alert("Please input x and y")
            return
        }    
        document.getElementById("result").innerText = `${parseInt(inputX.value) + parseInt(inputY.value)}`
        //alert(`tong = ${parseInt(inputX.value) + parseInt(inputY.value)}`)    
    }
    function changeText() {    
        var inputX = document.getElementById("x")
        var inputY = document.getElementById("y")        
        //debugger
        var x = isNaN(parseInt(inputX.value)) ? 0 : parseInt(inputX.value)
        var y = isNaN(parseInt(inputY.value)) ? 0 : parseInt(inputY.value)    
        document.getElementById("result").innerText = `${x + y}`        
    }
    function fetchSongsToTable(){
        //debugger
        let tableSongs = document.getElementById("tableSong") //let, var, const ?    
        for(let i = 0; i < songs.length; i++) {
            let eachSong = songs[i]
            let row = tableSongs.insertRow(i+1)
            let cellSongName = row.insertCell(0)
            let cellAuthor = row.insertCell(1)        
            const {name, author, year} = eachSong //destructuring 1 Object        
            cellSongName.innerText = name
            cellAuthor.innerText = author
        }
    }
    fetchSongsToTable()

})

