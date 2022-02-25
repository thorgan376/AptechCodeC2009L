class Car extends Object{	
	#color = ""
	constructor({name, year, color}) {		
		super()
		this.name = name
		this.year = year		
		this.#color = color //se thu lai ben React 
	}

	//name = "aaaa"//reactjs		
	//"private" method
	_doSomethingForMe() {
		console.log('This is a private....')
	}
	toString(){
		return `name = ${this.name}, year = ${this.year}, color = ${this.#color}`
	}
}
//muon public class = ?
//export = public = extern
module.exports = {Car} //cu phap nay dung ca node+reactjs
