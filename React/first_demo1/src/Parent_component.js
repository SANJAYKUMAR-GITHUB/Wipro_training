import React, {Component} from "react";
import Child from './Child_comp.js'

class Parent extends Component {
    constructor(props){
        super(props);
        this.state={
            message: 'Hello from parent Componetn!'};
    
}

render(){
    return (
        <div>
        <h1> Parent Component</h1>
        <Child message = {this.state.message}/>
        </div>
    );
}
}