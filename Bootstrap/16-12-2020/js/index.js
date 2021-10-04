$(document).ready(() => {    
    $("#something1").text(`sum 1 and 2 is ${tinhtong(1,2)}`)   
    $("#something2").text(`5 x 2 =  ${multiply(5,2)}`)   
    console.log('chao cac bannnnnnn') 
})
/*
//cach 1 - classical
function sum(x, y) {
    return x + y
}
*/
const tinhtong = (x, y) => {
    //This is an "anonymous function"
    return x + y //this function has "1 line"
}
const multiply = (x, y) => x * y
let persons = [
    {
        name:'Nguyen Van X',
        email: 'nvx@yahoo.com',
        dateOfBirth: '2020-10-23'
    },
    {
        name:'Joehnnue dd',
        email: 'bbddee@yahoo.com',
        dateOfBirth: '2029-09-23'
    },
    {
        name:' hjuyg nm d',
        email: 'bbb@yahoo.com',
        dateOfBirth: '1996-08-23'
    },
]
//iterate
for(let i = 0; i < persons.length; i++) {
    //timestamp, epoc time, linux time, linux epoc
    //console.log(`${window.performance.now()} name = ${persons[i].name}`)
    //let person = persons[i]
    /*
    let name = person.name
    let email = person.email
    let dateOfBirth = person.dateOfBirth
    */
   //destructuring an object
   let {name, email, dateOfBirth} = persons[i]
    console.log(`name = ${name}, email = ${email}, dateOfBirth = ${dateOfBirth}`)
}
//Cach khac
persons.forEach(person => {
    let {name, email, dateOfBirth} = person
    console.log(`ten = ${name}, email = ${email}, ngay sinh = ${dateOfBirth}`)    
});
