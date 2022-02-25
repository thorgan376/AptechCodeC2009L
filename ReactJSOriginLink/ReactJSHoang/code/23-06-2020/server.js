const {Car} = require('./models/Car')
console.log("chjao cac ban")
// var x = 100;
// const y = 12;
//y = 13;
//const & freeze
const person = {
	name: "Hoang",
	age: 18
}
person.name = "rejirhjer"; //ok
person.age = 30
console.log(`name = ${person.name}, age = ${person.age}`)
const personB = Object.freeze({
	name: "John",
	age: 30
})
personB.name = "xxx";
console.log(`object's detail = ${JSON.stringify(personB)}`)
//let thi sao ?
//let = local trong pham vi 1 block(khoi lenh)
var i = 999;
// for(let i = 0; i < 100; i++) {
// 	console.log(i)
// }

console.log(i)
//thu tu su dung(uu tien) : const => let => var
//vi du ve arrow function = "anonymous function" = lambda expression
const sum = (x, y) => {
	console.log('chuan bi tinh tong')
	return x + y
} 
console.log(`mot cong hai bang = ${sum(1,2)}`)
//array nhung thuc chat giong ArrayList<Object>

let products = [
	{
		name: 'iphone 3',
		year: 2013
	},
	{
		name: 'iphone 5',
		year: 2015
	},
	{
		name: 'iphone 7',
		year: 2017
	},
	{
		name: 'iphone 6',
		year: 2016
	}
] //array trong js
//anh xa => ham map
let productNames = products.map(product => product.name)
//lay ra nhung san pham sau nam 2015 ?
const resultProducts = products
		.filter(product => product.year >= 2015)
//xoa phan tu "phone 6"
products = products
	.filter(product => product.name !== 'iphone 6')
let z11 = '123';
if(z11 == 123) {	
	console.log("dung roi nhe")	
}

products[0].name = "mazda"
console.log("haha")
//them 1 phan tu vao danh sach

products.splice(2, 0, {
	name: 'iphone 12',
	year: 2020
})

/*
let products2 = products.concat({
	name: 'iphone 12',
	year: 2020
})
*/
//const add = (a, b) => a + b
function add(a, b = 10) {
	//default params = param when value is NULL
	return a + b
}
console.log(`tong 1 va 2 la : ${add(1)}`)
const sumNnumbers = (x, y, ...rest) => {
	let sum = x + y
	rest.forEach(eachParam => {
		
		sum += eachParam
	})
	return sum
}
console.log(sumNnumbers(1,2,3,4,5,6))
//tao 1 object bat ky
let email = "hoang@gmail.com"
let age = 18
let name = "Hoang"
const mrHoang = { name,age,email }
console.log(`detail object = ${JSON.stringify(mrHoang)}`)
//loi dung truyen tham so
/*
function buyAProduct({name, year, description}) {
	console.log(`Ban da mua...name: ${name}, year: ${year}, description= ${description}`)
}
buyAProduct({
	name: "iphone X", 
	description: "day la ipX", 
	year: 2020} //labeled parameters(Apple)
) //ko can theo thu tu
*/
//doi tuong chua ky tu dac biet o "key" => ok 
let productC = {
	"tên sản phẩm": "iphone 13",
	year: 2022
}
productC["拥有阳"] = "hweuhwuheu"

console.log("haha")
const objectX = {
	x: 10,
	y: 123,
	z: 222,
	//object phuc tap
	rectangle: {
		width: 100,
		height: 200,
		draw3(param3) {
			console.log(`Goi ham draw3 - ${param3}`)
		},
		draw: function(param1) {
			console.log(`Ban ve cai gi - ${param1}`)
		},
		draw2: (param2) => {
			console.log(`Goi ham draw2 - ${param2}`)	
		},		
	},	
}
const {x, y, z} = objectX //destructuring an object in JS
console.log(JSON.stringify({x, y, z}))
const {rectangle} = objectX
const {width, height, draw, draw2, draw3} = objectX.rectangle
//objectX.rectangle.draw(11)
draw(122)
draw2(123)
draw3(444)
//desctruct an array
const [...rest] = [1, 2, 3, 4, 65, 7, 8]
//"..." hay goi la "spread operator", rest
//clone an object
let iphoneA = {
	name: "iphone 14",
	year: 2022
}
//let iphoneB = iphoneA //reference

let iphoneB = JSON.parse(JSON.stringify(iphoneA)) //clone
iphoneA.name = "iphone 1555"
//classical 
let iphoneC = Object.assign({}, iphoneA)
iphoneC.name = "mazda"

let iphoneD = {...iphoneA, name: "something"}
let mazda = new Car({
	name: "mazda 10", 
	year: 2020,
	color: 'red'
})
//let someCar = new Car()
mazda._doSomethingForMe()
const makeOperatorObject = (param1) => {
	let i = 0;
	let result = {
		next: () => {
			if(i < 2) {
				i++;				
				return { value: {name: 'mazda', year: 2019}, done: false}	
			} else {
				return { value: {name: 'meccc', year: 2020}, done: true}		
			}			
		}
	}
	return result;
}
let operatorObject = makeOperatorObject("xxx")
//duyet doi tuong 
let result = operatorObject.next();
while (!result.done) {	
 	console.log(result.value); 
 	result = operatorObject.next(); 	
}
//generator function => 1 input => nhieu lan output
function* aGeneratorFunction(param1) {
	yield 5;
	yield 9;
	yield 10;
	return 15;
	yield 20
}
var result2 = aGeneratorFunction(123);
console.log(result2.next())
console.log(result2.next())
console.log(result2.next())
console.log(result2.next())
console.log(result2.next())
function gotoLibrary(numberOfBooks, completed) {
	//callback la 1 function
	setTimeout(()=>{
		console.log(`1.Toi da muon: ${numberOfBooks} sach`);		
		completed("da muon xong", null)
		//callback({data: "", error: "Ko xong roi"})
	}, 2000)
}
gotoLibrary(2, (data, error)=>{	
	if(error == null) {
		console.log("2.Muon sach xong di choi")
		console.log("3.Di choi xong an com")		
	}
	//"callback hell"	
});
//Promise = Future
//2 viec: 1.mua biet thu + 2.mua be boi
//viec 1 xong thi moi lam dc 2
const muaBietThu = (money) => {
	return new Promise((resolve, reject) => {
		setTimeout(()=> {
			if(money > 10 && money < 12) {
				resolve({content:"Nha biet thu 5 tang"})
			} else if(money >= 12 && money < 14) {
				resolve({
					content:"Nha biet thu 10 tang", 
					soNguoiGiupViec: 5
				})
			}
			else if(money <= 10 && money > 5){
				reject({
					error: "Ko du tien mua",
					reason: "Tu nhien bi duoi viec"
				})
			} else if(money <= 5){
				reject({
					error: "Ko du tien mua"					
				})
			} 
			//tren 14 la ko biet di dau
		}, 3000)
	})
}
const muaBeboi = (money) => {
	return new Promise((resolve, reject) => {
		setTimeout(() => {
			resolve("Mua be boi roi em oi")
		}, 2000)
	})
}
/*
muaBietThu(11).then((content) => { //ES6
	console.log(`Thanh cong: ${content.content}`)
	debugger
	muaBeboi(1).then((result) => {
		console.log(result)
	})
}).catch((error) => {
	console.log("that bai")
	debugger
})
*/
//Promise => async / await
//async function muaNhaMuaBeBoi(tienMuaBietThu, tienMuaBeBoi) { //ES8
const muaNhaMuaBeBoi = async (tienMuaBietThu, tienMuaBeBoi) => {	//ES7
	try {
		let content = await muaBietThu(11)
		console.log(`Thanh cong: ${content.content}`)
		let result = await muaBeboi(1)
		console.log(result)
	}catch(error) {
		console.log(`that bai = ${error.toString()}`)
	} finally {

	}
}
muaNhaMuaBeBoi(11, 1)
const programmingLanguages = ["C#", "java", "python","c++"]
if (programmingLanguages.indexOf("js") > 0) {
	//tim thay
}
if (programmingLanguages.includes("js")) {
	debugger
}
debugger























