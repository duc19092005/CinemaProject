import React, { useState } from 'react';
import { TicketIcon, MapPinIcon, Bars3Icon, XMarkIcon } from '@heroicons/react/24/solid';
import user from "../image/user.png";
import logo from '../image/logocinema1.png';
import { useNavigate } from 'react-router-dom';

function Nav() {
    const [searchTerm, setSearchTerm] = useState('');
    const [isOpen, setIsOpen] = useState(false);
    const [isMenuOpen, setIsMenuOpen] = useState(false);
    const navigate = useNavigate();

    const handleSearch = (e: React.FormEvent<HTMLFormElement>) => {
        e.preventDefault();
        console.log('Tìm kiếm:', searchTerm);
    };

    return (
        <nav className=" shadow-md text-white relative z-50">
            <div className="flex items-center justify-between px-4 py-2">
                <button onClick={() => navigate("/")} className="flex items-center space-x-2">
                    <img src={logo} alt="logo" className="h-20 hover:scale-105 transition-transform duration-300" />
                </button>

                <div className="md:hidden flex items-center space-x-3">
                    <button onClick={() => setIsOpen(!isOpen)} className="border rounded px-3 py-1 text-yellow-400 font-bold border-white flex items-center gap-1">
                        Chọn Rạp <span className="rotate-90">▼</span>
                    </button>
                    <button onClick={() => setIsMenuOpen(true)}>
                        <Bars3Icon className="w-6 h-6" />
                    </button>
                </div>

                <div className="hidden md:flex items-center gap-6">
                    <button
                        onClick={() => navigate('/booking')}
                        className="relative inline-flex items-center justify-center px-4 py-2 overflow-hidden text-white bg-purple-800 rounded-md group">
                        <span className="absolute w-0 h-0 transition-all duration-500 ease-out bg-amber-400 rounded-full group-hover:w-56 group-hover:h-56"></span>
                        <span className="relative text-base font-semibold flex items-center gap-2 uppercase">
                            <TicketIcon className="w-6 h-6 text-white" />
                            Đặt vé ngay
                        </span>
                    </button>

                    <form
                        onSubmit={handleSearch}
                        className="flex items-center border border-gray-300 rounded-3xl overflow-hidden shadow-sm w-[250px]">
                        <input
                            type="text"
                            placeholder="Tìm phim..."
                            className="px-4 py-2 w-full text-black focus:outline-none"
                            value={searchTerm}
                            onChange={(e) => setSearchTerm(e.target.value)} />
                        <button type="submit" className="bg-purple-600 text-white px-4 py-2 hover:bg-purple-800 transition">Tìm</button>
                    </form>

                    <button onClick={() => navigate('/login')} className="flex items-center px-3 py-2 border border-white rounded-full hover:scale-90 transition">
                        <img src={user} alt="account" className="w-7" />
                    </button>
                </div>
            </div>

            {/* Mobile menu overlay */}
            {isMenuOpen && (
                <div className="fixed inset-0 bg-slate-900/90 text-white p-6 z-50" style={{ backgroundImage: "url('https://images8.alphacoders.com/136/thumb-1920-1368754.jpeg')" }}>
                    <div className="flex justify-between items-center mb-6">
                        <img src={logo} alt="logo" className="h-12" />
                        <div className="flex items-center space-x-2">
                            <button onClick={() => setIsOpen(!isOpen)} className="border rounded px-3 py-1 text-yellow-400 font-bold border-white flex items-center gap-1">
                                Chọn Rạp <span className="rotate-90">▼</span>
                            </button>
                            <button onClick={() => setIsMenuOpen(false)} className="text-white border border-white rounded-full p-1">
                                <XMarkIcon className="w-6 h-6" />
                            </button>
                        </div>
                    </div>
                    <ul className="space-y-4 text-lg font-bold">
                        <li className="text-yellow-400 cursor-pointer" onClick={() => navigate('/')}>TRANG CHỦ</li>
                        <li className="cursor-pointer" onClick={() => navigate('/booking')}>ĐẶT VÉ</li>
                        <li className="cursor-pointer">BẮP NƯỚC</li>
                        <li className="cursor-pointer" onClick={() => navigate('/info')}>LỊCH CHIẾU</li>
                        <li className="cursor-pointer">KHUYẾN MÃI</li>
                        <li className="cursor-pointer">THÀNH VIÊN</li>
                    </ul>
                </div>
            )}

            <div className={`md:flex justify-between items-center px-4 py-2  text-sm ${isMenuOpen ? 'hidden' : 'block'} md:block`}>
                <div className="flex flex-wrap gap-4 w-full md:w-1/2">
                    <span onClick={() => setIsOpen(!isOpen)} className="cursor-pointer flex items-center gap-1 hover:text-purple-300">
                        <MapPinIcon className="w-5 h-5 text-purple-400" />
                        Chọn rạp
                    </span>
                    {isOpen && (
                        <div className="absolute left-4 top-[131px] z-50 bg-slate-900 rounded shadow-lg p-4 grid grid-cols-3 md:grid-cols-3 gap-3">
                            <div onClick={() => navigate('/cinezone')} className="text-slate-200 font-bold cursor-pointer">Cinema Hòa Hưng (TP HCM)</div>
                            <div onClick={() => navigate('/cinezone')} className="text-slate-200 font-bold cursor-pointer">Cinema Vũng Tàu (TP HCM)</div>
                            <div onClick={() => navigate('/cinezone')} className="text-slate-200 font-bold cursor-pointer">Cinema Quốc Thanh (TP HCM)</div>
                        </div>
                    )}
                    <span onClick={() => navigate('/info')} className="cursor-pointer flex items-center gap-1 hover:text-purple-300">
                        <MapPinIcon className="w-5 h-5 text-purple-400" />
                        Chọn lịch chiếu
                    </span>
                </div>
                <div className="w-full md:w-1/2 text-right mt-2 md:mt-0 text-sm">
                    <span onClick={() => navigate('/introduce')} className="cursor-pointer hover:text-purple-300">Giới thiệu</span>
                </div>
            </div>
        </nav>
    );
}

export default Nav;