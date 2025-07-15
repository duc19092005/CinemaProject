import React from "react";
import Nav from "../Header/nav";
import Bottom from "../Footer/bottom";

function Info() {
    return (
        <div>
            <Nav />
            <div className="container">
                <h1>Account Information</h1>
                <p>This is where account information will be displayed.</p>
            </div>
            <Bottom />
        </div>
    );
};
export default Info;