import React, { useState } from "react";
import { useNavigate } from "react-router-dom";
import DatePicker from "react-datepicker";
import "react-datepicker/dist/react-datepicker.css";
import Nav from '../Header/nav';
import Bottom from '../Footer/bottom';

function Register() {
    const navigate = useNavigate();
    const handleLogin = () => {
        navigate('/Login')
    }
    const [startDate, setStartDate] = useState<Date | null>(null);
    return (
        <div className="min-h-screen w-full bg-cover bg-center"
            style={{ backgroundImage: "url('https://images8.alphacoders.com/136/thumb-1920-1368754.jpeg')" }}>
            <div className="sticky top-0 z-50 shadow-md" style={{ backgroundImage: "url('https://th.bing.com/th/id/R.9e8b6083d2c56afe3e37c99a0d008551?rik=MgANzjo9WJbFrA&riu=http%3a%2f%2fgetwallpapers.com%2fwallpaper%2ffull%2f5%2f0%2f3%2f718692-amazing-dark-purple-backgrounds-1920x1200.jpg&ehk=QVn3JWJ991bU4NaIVD9w8hngTuAZ1AHehPjBWxqpDUE%3d&risl=&pid=ImgRaw&r=0')" }}>
                <header>
                    <div className="content-wrapper max-w-screen-xl text-base mx-auto px-8">
                        <Nav />
                    </div>
                </header>
            </div>
            <div className="content-wrapper max-w-screen-xl text-base mx-auto px-8  min-h-screen pb-32">
                <div className="content-wrapper max-w-screen-2xl text-base mx-auto px-8  min-h-screen">
                    <div>
                        <div className="flex justify-center items-center h-full w-full pt-20">
                            <div className="grid gap-8  border-4 border-double  border-indigo-500 backdrop-blur-sm">
                                <section
                                    id="back-div"
                                    className="bg-transparent rounded-3xl">
                                    <div
                                        className="border-8 border-transparent rounded-xl bg-slate-300 shadow-2xl p-8 m-2">
                                        <h2
                                            className="text-2xl font-extrabold text-center cursor-default  text-[#12213c]">
                                            ĐĂNG KÝ
                                        </h2>
                                        <form action="#" method="post" className="space-y-6">
                                            <div className="w-96">
                                                <label typeof="text" className="flex justify-start items-start mb-2 text-base text-[#12213c] font-bold px-4 ">Tên đăng nhập</label>
                                                <input
                                                    id="TenDN"
                                                    className="placeholder:text-slate-500 text-base border p-3 shadow-md bg-transparent dark:text-[#12213c] dark:border-gray-700 border-gray-300 rounded-lg w-full focus:ring-2 focus:ring-blue-500 transition transform hover:scale-105 duration-300"
                                                    type="text"
                                                    placeholder="Nhập tên đăng nhập"
                                                />
                                            </div>
                                            <div className="w-96">
                                                <label typeof="email" className="flex justify-start items-start mb-2 text-base text-[#12213c] font-bold px-4 ">Email</label>
                                                <input
                                                    id="email"
                                                    className="placeholder:text-slate-500 border p-3 shadow-md bg-transparent dark:text-[#12213c] dark:border-gray-700 border-gray-300 rounded-lg w-full focus:ring-2 focus:ring-blue-500 transition transform hover:scale-105 duration-300"
                                                    type="email"
                                                    placeholder="Email"
                                                />
                                            </div>
                                            <div>
                                                <label className="flex justify-start items-start mb-2 text-base text-[#12213c] font-bold px-4 ">Mật khẩu</label>
                                                <input
                                                    id="password"
                                                    className="placeholder:text-slate-500 border p-3 shadow-md bg-transparent dark:text-[#12213c] dark:border-gray-700 border-gray-300 rounded-lg w-full focus:ring-2 focus:ring-blue-500 transition transform hover:scale-105 duration-300"
                                                    type="password"
                                                    placeholder="Hãy nhập mật khẩu "
                                                />
                                            </div>
                                            <div className="w-96">
                                                <label className="flex justify-start items-start mb-2 text-base text-[#12213c] font-bold px-4 ">
                                                    Ngày sinh
                                                </label>
                                                <DatePicker
                                                    selected={startDate}
                                                    onChange={(date) => setStartDate(date)}
                                                    dateFormat="dd/MM/yyyy"
                                                    isClearable
                                                    showYearDropdown
                                                    scrollableMonthYearDropdown placeholderText="Chọn ngày sinh của bạn 🎂"
                                                    className="placeholder:text-slate-500 border p-3 shadow-md bg-transparent dark:text-[#12213c] dark:border-gray-700 border-gray-300 rounded-lg w-[385px] focus:ring-2 focus:ring-blue-500 transition transform hover:scale-105 duration-300"
                                                />
                                            </div>
                                            <div className="w-96">
                                                <label className="flex justify-start items-start mb-2 text-base text-[#12213c] font-bold px-4 ">Số điện thoại</label>
                                                <input
                                                    id="phone"
                                                    className="placeholder:text-slate-500 border p-3 shadow-md bg-transparent dark:text-[#12213c] dark:border-gray-700 border-gray-300 rounded-lg w-full focus:ring-2 focus:ring-blue-500 transition transform hover:scale-105 duration-300"
                                                    type="tel"
                                                    maxLength={10}
                                                    pattern="[0-9]{10}"
                                                    placeholder="Nhập số điện thoại 📱 "
                                                />
                                            </div>
                                            <div className="w-96">
                                                <label className="flex justify-start items-start mb-2 text-base text-[#12213c] font-bold px-4 ">Họ và tên</label>
                                                <input
                                                    id="TenKH"
                                                    className="placeholder:text-slate-500 border p-3 shadow-md bg-transparent dark:text-[#12213c] dark:border-gray-700 border-gray-300 rounded-lg w-full focus:ring-2 focus:ring-blue-500 transition transform hover:scale-105 duration-300"
                                                    type="text"
                                                    placeholder="Nhập họ và tên"
                                                />
                                            </div>
                                            <div className="w-96">
                                                <label className="flex justify-start items-start mb-2 text-base text-[#12213c] font-bold px-4 ">Số CCCD</label>
                                                <input
                                                    id="CCCD"
                                                    className="placeholder:text-slate-500 border p-3 shadow-md bg-transparent dark:text-[#12213c] dark:border-gray-700 border-gray-300 rounded-lg w-full focus:ring-2 focus:ring-blue-500 transition transform hover:scale-105 duration-300"
                                                    type="tel"
                                                    maxLength={12}
                                                    pattern="[0-9]{12}"
                                                    placeholder="Nhập số Căn cước công dân 💳"
                                                />
                                            </div>
                                            <div className="flex items-center mt-4">
                                                <input
                                                    id="agree"
                                                    type="checkbox"
                                                    className="w-4 h-4 text-blue-600 bg-gray-100 border-gray-300 rounded focus:ring-blue-500"
                                                />
                                                <label htmlFor="agree" className="ml-2 w-[360px] text-sm text-gray-900 dark:text-[#12213c]">
                                                    Khách hàng đã đồng ý các điều khoản, điều kiện của thành viên Cinema
                                                </label>
                                            </div>
                                            <button
                                                className="w-full font-bold p-3 mt-4 text-white bg-gradient-to-r from-blue-500 to-purple-500 rounded-lg hover:scale-105 transition transform duration-300 shadow-lg focus:outline-none focus:ring-2 focus:ring-blue-500"
                                                type="submit">
                                                ĐĂNG KÝ
                                            </button>
                                        </form>
                                        <div className="flex flex-col mt-4 text-sm text-center dark:text-[#12213c]">
                                            <p>
                                                Bạn đã có tài khoản?
                                                <span onClick={handleLogin} className="text-blue-400 transition hover:underline cursor-pointer">Đăng nhập</span>
                                            </p>
                                        </div>
                                    </div>
                                </section>
                            </div>
                        </div>

                    </div>
                </div>
            </div>
            <footer className="2">
                <Bottom />
            </footer>
        </div>
    );
}
export default Register;