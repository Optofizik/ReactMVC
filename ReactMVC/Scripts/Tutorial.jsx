﻿var CommentBox = React.createClass({
    render: function () {
        return (
        <div className="commentBox">
            Hello, World! I am a Comment Box!
        </div>);
    }
});

ReactDOM.render(
    <CommentBox />,
    document.getElementById("content")
);