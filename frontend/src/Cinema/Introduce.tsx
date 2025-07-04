import React from "react";
import Nav from "../Header/nav";
import Bottom from "../Footer/bottom";
import { useNavigate } from "react-router-dom";



function Introduce() {
    const navigate = useNavigate();
    return (
        <div className="App bg-gradient-to-tr from-slate-900 to-purple-950 min-h-screen top-0">
            {/* Header */}
            <div className="sticky top-0 z-50 bg-slate-900 shadow-md">
                <header>
                    <div className="max-w-screen-xl mx-auto px-8">
                        <Nav />
                    </div>
                </header>
            </div>
            <div className="flex justify-center items-center max-h-full">
                <img
                    src="https://wallpapercave.com/wp/wp10400999.jpg"
                    alt="SUMENH"
                    className="px-56 pt-6"
                />
            </div>
            <div>
                <footer className="pt-32">
                    <Bottom />
                </footer>
            </div>
        </div>
    );

}
export default Introduce;