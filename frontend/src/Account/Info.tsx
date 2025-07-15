import React from "react";
import Nav from "../Header/nav";
import Bottom from "../Footer/bottom";
import { useNavigate } from "react-router-dom";

function Info() {
    const userEmail = localStorage.getItem('userEmail');
    const navigate = useNavigate();
    const handleLogout = () => {
        localStorage.removeItem('userEmail');
        navigate('/login');
    };

    return (
        <div className="min-h-screen bg-fixed w-full bg-cover bg-center"
            style={{ backgroundImage: "url('https://images8.alphacoders.com/136/thumb-1920-1368754.jpeg')" }}>
            <div className="sticky top-0 z-50 bg-slate-900 shadow-md mb-4 ">
                <div className="max-w-screen-xl mx-auto px-8">
                    <Nav />
                </div>
            </div>
            <div className="max-w-3xl mx-auto space-y-10 py-5">
                <h1 className="text-white text-3xl font-bold text-center uppercase">Cinema xin chào!  {userEmail}</h1>
                {/* Thông tin cá nhân */}
                <div className="bg-[#f7eaff]/50 p-6 rounded-2xl shadow-xl">
                    <h2 className="text-2xl font-bold mb-6">Thông tin cá nhân</h2>
                    <div className="grid grid-cols-1 md:grid-cols-2 gap-6">
                        <div>
                            <label className="block mb-2 font-semibold ">Họ và tên:</label>
                            <input placeholder="Nhập Họ và tên của bạn..." type="text" className="w-full placeholder-slate-800 border rounded-md px-4 py-2 bg-white/50" />
                        </div>
                        <div>
                            <label className="block mb-2 font-semibold">Ngày sinh</label>
                            <input placeholder="Ngày sinh của bạn..." type="date" className="w-full placeholder-slate-800 border rounded-md px-4 py-2 bg-white/50" />
                        </div>
                        <div>
                            <label className="block mb-2 font-semibold">Email</label>
                            <input placeholder="Email của bạn..." type="email" className="w-full placeholder-slate-800 border rounded-md px-4 py-2 bg-white/50" />
                        </div>
                        <div>
                            <label className="block mb-2 font-semibold">Địa chỉ</label>
                            <input placeholder="Địa chỉ của bạn..." type="text" className="w-full placeholder-slate-800 border rounded-md px-4 py-2 bg-white/50" />
                        </div>
                        <div className="md:col-span-2">
                            <label className="block mb-2 font-semibold">CCCD</label>
                            <input placeholder="Căn cước công dân của bạn..." type="number" className="w-full placeholder-slate-800 border rounded-md px-4 py-2 bg-white/50" />
                        </div>
                    </div>
                    <div className="mt-6 text-center">
                        <button className="bg-yellow-950 text-yellow-400 border border-yellow-400 border-b-4 font-medium overflow-hidden relative px-4 py-2 rounded-md hover:brightness-150 hover:border-t-4 hover:border-b active:opacity-75 outline-none duration-300 group">
                            <span className="bg-yellow-400 shadow-yellow-400 absolute -top-[150%] left-0 inline-flex w-80 h-[5px] rounded-md opacity-50 group-hover:top-[150%] duration-500 shadow-[0_0_10px_10px_rgba(0,0,0,0.3)]"></span>
                            Lưu thông tin
                        </button>


                    </div>
                </div>
                {/* Đổi mật khẩu */}
                <div className="bg-[#f7eaff]/50 p-6 rounded-2xl shadow-xl">
                    <h2 className="text-2xl font-bold mb-6">Đổi mật khẩu</h2>
                    <div className="space-y-4">
                        <div>
                            <label className="block mb-2 font-semibold">Mật khẩu cũ</label>
                            <input placeholder="Mật khẩu cũ của bạn..." type="password" className="w-full placeholder-slate-800 border rounded-md px-4 py-2 bg-white/50" />
                        </div>
                        <div>
                            <label className="block mb-2 font-semibold">Mật khẩu mới</label>
                            <input placeholder="Mật khẩu mới của bạn..." type="password" className="w-full placeholder-slate-800 border rounded-md px-4 py-2 bg-white/50" />
                        </div>
                        <div>
                            <label className="block mb-2 font-semibold">Xác nhận mật khẩu mới</label>
                            <input placeholder="Xác nhận mật khẩu mới của bạn..." type="password" className="w-full placeholder-slate-800 border rounded-md px-4 py-2 bg-white/50" />
                        </div>
                    </div>
                    <div className="mt-6 text-center">
                        <button className="bg-yellow-950 text-yellow-400 border border-yellow-400 border-b-4 font-medium overflow-hidden relative px-4 py-2 rounded-md hover:brightness-150 hover:border-t-4 hover:border-b active:opacity-75 outline-none duration-300 group">
                            <span className="bg-yellow-400 shadow-yellow-400 absolute -top-[150%] left-0 inline-flex w-80 h-[5px] rounded-md opacity-50 group-hover:top-[150%] duration-500 shadow-[0_0_10px_10px_rgba(0,0,0,0.3)]"></span>
                            Cập nhật mật khẩu
                        </button>
                    </div>
                </div>
            </div>
            <div className="flex justify-center mt-10">
                <button
                    className="group flex items-center justify-start w-11 h-11 bg-red-600 rounded-full cursor-pointer relative overflow-hidden transition-all duration-200 shadow-lg hover:w-32 hover:rounded-lg active:translate-x-1 active:translate-y-1">
                    <div
                        className="flex items-center justify-center w-full transition-all duration-300 group-hover:justify-start group-hover:px-3">
                        <svg className="w-4 h-4" viewBox="0 0 512 512" fill="white">
                            <path
                                d="M377.9 105.9L500.7 228.7c7.2 7.2 11.3 17.1 11.3 27.3s-4.1 20.1-11.3 27.3L377.9 406.1c-6.4 6.4-15 9.9-24 9.9c-18.7 0-33.9-15.2-33.9-33.9l0-62.1-128 0c-17.7 0-32-14.3-32-32l0-64c0-17.7 14.3-32 32-32l128 0 0-62.1c0-18.7 15.2-33.9 33.9-33.9c9 0 17.6 3.6 24 9.9zM160 96L96 96c-17.7 0-32 14.3-32 32l0 256c0 17.7 14.3 32 32 32l64 0c17.7 0 32 14.3 32 32s-14.3 32-32 32l-64 0c-53 0-96-43-96-96L0 128C0 75 43 32 96 32l64 0c17.7 0 32 14.3 32 32s-14.3 32-32 32z"
                            ></path>
                        </svg>
                    </div>
                    <div
                        onClick={handleLogout}
                        className=" absolute right-3 transform translate-x-full opacity-0 text-white text-lg font-semibold transition-all duration-300 group-hover:translate-x-0 group-hover:opacity-100">
                        Đăng xuất
                    </div>
                </button>
            </div>

            <div className="sticky mx-auto mt-28">
                <Bottom />
            </div>
        </div>
    );
};
export default Info;