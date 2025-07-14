import React from "react";
import { useNavigate } from "react-router-dom";
import Nav from '../Header/nav';
import Bottom from '../Footer/bottom';

function Login() {
    const navigate = useNavigate();
    const handleRegister = () => {
        navigate('/register');
    }
    const handleForgotpassword = () => {
        navigate('/Forgotpassword');
    }

    return (
        <div className="min-h-screen w-full bg-cover bg-center top-0"
            style={{ backgroundImage: "url('https://images8.alphacoders.com/136/thumb-1920-1368754.jpeg')" }}>
            <div className="sticky top-0 z-50  shadow-md" style={{ backgroundImage: "url('https://th.bing.com/th/id/R.9e8b6083d2c56afe3e37c99a0d008551?rik=MgANzjo9WJbFrA&riu=http%3a%2f%2fgetwallpapers.com%2fwallpaper%2ffull%2f5%2f0%2f3%2f718692-amazing-dark-purple-backgrounds-1920x1200.jpg&ehk=QVn3JWJ991bU4NaIVD9w8hngTuAZ1AHehPjBWxqpDUE%3d&risl=&pid=ImgRaw&r=0')" }}>
                <header>
                    <div className="content-wrapper max-w-screen-xl text-base mx-auto px-8">
                        <Nav />
                    </div>
                </header>
            </div>
            <div className="content-wrapper max-w-screen-2xl text-base mx-auto px-8  min-h-screen pt-24">
                <div>
                    <div className="flex justify-center items-center h-full w-full">
                        <div className="grid gap-8 border-4 border-double  border-indigo-500 backdrop-blur-sm">
                            <section
                                id="back-div"
                                className="bg-transparent rounded-3xl ">
                                <div className=" border-transparent rounded-xl bg-slate-300 shadow-2xl p-8 m-2">
                                    <h2
                                        className="text-2xl font-bold text-center cursor-default  text-[#12213c]">
                                        ĐĂNG NHẬP
                                    </h2>
                                    <form action="#" method="post" className="space-y-6">
                                        <div className="w-96">
                                            <label typeof="email" className="flex justify-start items-start mb-2 text-base text-[#12213c] font-bold px-4 pt-3">Email</label>
                                            <input
                                                id="email"
                                                className="placeholder:text-slate-500 border p-3 shadow-md bg-transparent text-[#12213c]  dark:border-gray-700 border-gray-300 rounded-lg w-full focus:ring-2 focus:ring-blue-500 transition transform hover:scale-105 duration-300"
                                                type="email"
                                                placeholder="Email"
                                            />
                                        </div>
                                        <div>
                                            <label className="flex justify-start items-start mb-2 text-base text-[#12213c] font-bold px-4 ">Mật khẩu</label>
                                            <input
                                                id="password"
                                                className="placeholder:text-slate-500 border p-3 shadow-md bg-transparent text-[#12213c]  dark:border-gray-700 border-gray-300 rounded-lg w-full focus:ring-2 focus:ring-blue-500 transition transform hover:scale-105 duration-300"
                                                type="password"
                                                placeholder="Password"
                                            />
                                        </div>
                                        <div>
                                            <span onClick={handleForgotpassword} className="text-[#12213c] text-sm font-bold transition hover:underline flex justify-end items-end cursor-pointer ">Quên mật khẩu?</span>
                                        </div>
                                        <button
                                            className="text-xl w-full font-bold p-3 mt-4 text-white bg-gradient-to-r from-blue-500 to-purple-500 rounded-lg hover:scale-105 transition transform duration-300 shadow-lg focus:outline-none focus:ring-2 focus:ring-blue-500"
                                            type="submit">
                                            ĐĂNG NHẬP
                                        </button>
                                    </form>
                                    <div className="flex justify-center items-center flex-col mt-4 text-sm text-center text-[#12213c] font-bold">
                                        <p>
                                            Chưa có tài khoản?
                                            <span onClick={handleRegister} className="text-blue-400 transition hover:underline cursor-pointer pl-3">Đăng ký</span>
                                        </p>
                                    </div>
                                </div>
                            </section>
                        </div>
                    </div>

                </div>
            </div>
            <footer className="pt-32">
                <Bottom />
            </footer>
        </div>
    );
}

export default Login;
