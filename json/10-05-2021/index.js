//define an object
let person = {
    name: 'Hoang',
    age: 18,
    email: 'hoang@gmail.com'
}
let person2 = person //reference
//let person3 = {...person} //... => spread operator,EMMAScript 5, hay dung nhat
//let person3 = JSON.parse(JSON.stringify(person)) //all versions of js
//clone an object
let person3 = {
    //it dung    
}
person3.name = person.name
person3.age = person.age
person3.email = person.email

person.name = 'abc'
console.log(`person2 = ${JSON.stringify(person2)}`)
console.log(`person3 = ${JSON.stringify(person3)}`)
//person3 va person la 2 doi tuong rieng re
//Dinh nghia class
class Rectangle { //Object
    constructor({id, width, height, color}) {
        this.id = id ?? 0
        this.width = width ?? 0 //nil-coalesing
        this.height = height ?? 0     
        this.color = color ?? 'red'      
    }        
    isEmpty() {
        return this.width == 0 && this.height == 0                          
    } 
    getArea() {
        return this.width * this.height
    }
    getPerimeter() {
        return 2*(this.width + this.height)
    }
}
var rectangle1 = new Rectangle({id: 1, width: 300, height: 100, color: 'red'})
var rectangle2 = new Rectangle({id: 3, width: 200, height: 100, color: 'green'})
var rectangle3 = new Rectangle({id: 5, width: 400, height: 300, color: 'blue'})
///Object.entries

console.log(`rectangle1 = ${JSON.stringify(rectangle1)}`)
console.log(`rectangle2 = ${JSON.stringify(rectangle2)}`)
console.log(`rectangle3 = ${JSON.stringify(rectangle3)}`)
let listOfSomethings = []
listOfSomethings.push(rectangle1)
listOfSomethings.push(rectangle2)
listOfSomethings.push({
    x: 10,
    y: 20
})
//no problem !
console.log(`listOfSomethings = ${JSON.stringify(listOfSomethings)}`)
//xoa => dung filter
listOfSomethings = listOfSomethings.filter(element => element.id !== 3)
console.log(`listOfSomethings = ${JSON.stringify(listOfSomethings)}`)
//noi 2 array su dung concat = concatenate
console.log(`area of rectangle3 = ${rectangle3.getArea()}`)
//rectangle3.getPerimeter = () => 2*(rectangle3.width + rectangle3.height)
console.log(`perimeter of rectangle3 = ${rectangle3.getPerimeter()}`)
console.log(`perimeter of rectangle2 = ${rectangle2.getPerimeter()}`)
let list1 = [1,7,4,6]
let list2 = [5,2]
let list3 = list1.concat(list2)
let color1 = {
    red: 120,
    green: 100,
    blue: 220,
}
let color2 = {...color1, red: 200} //hay dung
console.log(`color2 = ${JSON.stringify(color2)}`)
list3.sort((item1, item2) => item2 - item1)
for(let eachItem of list3) {
    console.log(`eachItem = ${eachItem}`)
}
//filter 1 danh sach dien thoai, co cac so dien thoai chi chua 1 chuoi nao do 
//= tim kiem so dien thoai
let persons = [
    {
        name:"aa",
        phone: 91254545
    },
    {
        name:"bb",
        phone: 051254545
    },
    {
        name:"dd",
        phone: 43874345,
    },
    {
        name:"cc",
        phone: 9123344455
    }
]
let filteredPersons = persons.filter(person => `${person.phone}`.includes('912'))
console.log(`filteredPersons = ${JSON.stringify(filteredPersons)}`)









