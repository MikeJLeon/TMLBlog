import React, { Component } from 'react';

export class Blog extends Component {
    static displayName = Blog.name;
    constructor(props) {
        super(props);
        this.state = { res: "" };
    }

    componentDidMount() {
        this.getBlog();
    }

    render() {
        return (
            <div>
                <h1>Hello, world!</h1>
                <p>{this.state.res}</p>
            </div>
        );
    }
    async getBlog() {
        const response = await fetch("PostsModel");
        console.log(response);
        const data = await response.json();
        console.log(data);
        this.setState({ res: data });
    }
}
