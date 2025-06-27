import React from "react";
import { useNavigate } from "react-router-dom";
import Nav from '../Header/nav';
import Bottom from '../Footer/bottom';

function Login() {
    const navigate = useNavigate();
    const handleRegister = () => {
        navigate('/register');
    }

    return (
        <div className="min-h-screen w-full bg-cover bg-center"
            style={{ backgroundImage: "url('https://images8.alphacoders.com/136/thumb-1920-1368754.jpeg')" }}>
            <div className="sticky top-0 z-50  shadow-md" style={{ backgroundImage: "url('https://th.bing.com/th/id/R.9e8b6083d2c56afe3e37c99a0d008551?rik=MgANzjo9WJbFrA&riu=http%3a%2f%2fgetwallpapers.com%2fwallpaper%2ffull%2f5%2f0%2f3%2f718692-amazing-dark-purple-backgrounds-1920x1200.jpg&ehk=QVn3JWJ991bU4NaIVD9w8hngTuAZ1AHehPjBWxqpDUE%3d&risl=&pid=ImgRaw&r=0')" }}>
                <header>
                    <div className="content-wrapper max-w-screen-xl text-base mx-auto px-8">
                        <Nav />
                    </div>
                </header>
            </div>
            <div className="content-wrapper max-w-screen-2xl text-base mx-auto px-8  min-h-screen">
                <div>
                    <div className="flex justify-center items-center h-full w-full">
                        <div className="grid gap-8">
                            <section
                                id="back-div"
                                className="bg-gradient-to-r from-blue-500 to-purple-500 rounded-3xl">
                                <div
                                    className="border-8 border-transparent rounded-xl bg-white dark:bg-gray-900 shadow-xl p-8 m-2">
                                    <h2
                                        className="text-5xl font-bold text-center cursor-default dark:text-gray-300 text-gray-900">
                                        ĐĂNG NHẬP
                                    </h2>
                                    <form action="#" method="post" className="space-y-6">
                                        <div className="w-96">
                                            <label typeof="email" className="flex justify-start items-start mb-2 text-lg dark:text-gray-300 px-4 pt-3">Email</label>
                                            <input
                                                id="email"
                                                className="border p-3 shadow-md dark:bg-indigo-700 dark:text-gray-300 dark:border-gray-700 border-gray-300 rounded-lg w-full focus:ring-2 focus:ring-blue-500 transition transform hover:scale-105 duration-300"
                                                type="email"
                                                placeholder="Email"
                                            />
                                        </div>
                                        <div>
                                            <label className="flex justify-start items-start mb-2 text-lg dark:text-gray-300 px-4 ">Mật khẩu</label>
                                            <input
                                                id="password"
                                                className="border p-3 shadow-md dark:bg-indigo-700 dark:text-gray-300 dark:border-gray-700 border-gray-300 rounded-lg w-full focus:ring-2 focus:ring-blue-500 transition transform hover:scale-105 duration-300"
                                                type="password"
                                                placeholder="Password"
                                            />
                                        </div>
                                        <a href="#" className="text-blue-400 text-sm transition hover:underline flex  justify-end items-end">Quên mật khẩu?</a>
                                        <button
                                            className="w-full font-bold p-3 mt-4 text-white bg-gradient-to-r from-blue-500 to-purple-500 rounded-lg hover:scale-105 transition transform duration-300 shadow-lg focus:outline-none focus:ring-2 focus:ring-blue-500"
                                            type="submit">
                                            ĐĂNG NHẬP
                                        </button>
                                    </form>
                                    <div className="flex flex-col mt-4 text-sm text-center dark:text-gray-300">
                                        <p>
                                            Chưa có tài khoản?
                                            <a onClick={handleRegister} className="text-blue-400 transition hover:underline">Đăng kí</a>
                                        </p>
                                    </div>
                                    <div id="third-party-auth" className="flex justify-center gap-4 mt-5">
                                        <button
                                            className="p-2 rounded-lg hover:scale-105 transition transform duration-300 shadow-lg">
                                            <img
                                                className="w-6 h-6"
                                                loading="lazy"
                                                src="https://ucarecdn.com/8f25a2ba-bdcf-4ff1-b596-088f330416ef/"
                                                alt="Google"
                                            />
                                        </button>
                                        <button
                                            className="p-2 rounded-lg hover:scale-105 transition transform duration-300 shadow-lg">
                                            <img
                                                className="w-6 h-6"
                                                loading="lazy"
                                                src="https://ucarecdn.com/6f56c0f1-c9c0-4d72-b44d-51a79ff38ea9/"
                                                alt="Facebook"
                                            />
                                        </button>
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
