import React, { Component } from 'react';

class Counter extends Component {
  constructor(props) {
    super(props);
    this.state = { count: 0 }; // Initialize count state
  }

  componentDidMount() {
    // Update the document title when the component mounts
    document.title = `Count: ${this.state.count}`;
  }

  componentDidUpdate() {
    // Update the document title whenever the component updates
    document.title = `Count: ${this.state.count}`;
  }

  incrementCount = () => {
    // Increment the count state when the button is clicked
    this.setState((prevState) => ({
      count: prevState.count + 1,
    }));
  };

  render() {
    return (
      <div>
        <h1>Count: {this.state.count}</h1>
        <button onClick={this.incrementCount}>Increment</button>
      </div>
    );
  }
}

export default Counter;
