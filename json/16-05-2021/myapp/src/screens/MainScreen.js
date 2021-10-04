import React, {Component} from 'react';
//import './MainScreen.css'

export default class MainScreen extends Component {
    constructor(props) {
        super(props)
        console.log('constructor')
        //internal property = state
        this.state = {
            timer: 0,
            searchString:''
        }        
    }
    
    async componentDidMount() {
        const {products} = this.props
        console.log('componentDidMount')        
        setInterval(()=>{
            this.setState({
                timer: this.state.timer + 1
            })
            //this.state.x = this.state.x + 1//never !
        }, 1000)
    }
    render() {        
        console.log('render')        
        const {x, y} = this.props //da hoc tu buoi 1        
        const {name, email} = this.props.person
        const {products} = this.props
        //lam the nao de hien ra table tu danh sach products
        //bt nay mn da lam voi jquery
        const filteredProducts = products.filter(product => product.name.includes(this.state.searchString))
        const {timer, searchString} = this.state
        return <div>
            <h1>timer = {timer}</h1>
            <input type="text" placeholder="Enter text to search" 
                onChange={(event) => {
                    //debugger
                    this.setState({searchString: event?.target?.value})
                }}
                value={searchString}></input>
            <h2>typed text = {searchString} </h2>
            <h1>Day la trang Main day ne</h1>
            <h2>Ban da truyen x = {x}, y = {y} </h2>
            <h2>Ban da truyen name = {name}, y = {email} </h2>            
            <table>
                <tbody>
                 {filteredProducts.length > 0 ? <tr>
                     <th>Name</th>
                     <th>Year</th>
                 </tr>:<h2>No product found</h2>}
                 {filteredProducts.map(product => (<tr key={product.name}>
                    <td>{product.name}</td>
                    <td>{product.year}</td>
                </tr>))}                   
                </tbody>
            </table>                
        </div>
    }
}
//trong js thuan ko co export
// const MainScreen = (props) => {
//     const { x, y } = props //da hoc tu buoi 1        
//     const { name, email } = props.person
//     const { products } = props
//     //lam the nao de hien ra table tu danh sach products
//     //bt nay mn da lam voi jquery
//     const filteredProducts = products.filter(product => product.year > 2017)
//     return <div>
//         <h1>Day la trang Main day ne</h1>
//         <h2>Ban da truyen x = {x}, y = {y} </h2>
//         <h2>Ban da truyen name = {name}, y = {email} </h2>
//         <table>
//             {filteredProducts.length > 0 ? <tr>
//                 <th>Name</th>
//                 <th>Year</th>
//             </tr> : <h2>No product found</h2>}
//             {filteredProducts.map(product => (<tr>
//                 <td>{product.name}</td>
//                 <td>{product.year}</td>
//             </tr>))}
//         </table>
//     </div>
// }
// export default MainScreen