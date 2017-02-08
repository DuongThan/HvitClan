var HelloReact23 = React.createClass({
    render: function () {
        return (
            <h1> {this.props.name} </h1>
            );
    }
});

React.render(
    <HelloReact23 name="Hello Duongthan"/>,document.getElementById('container')
    );