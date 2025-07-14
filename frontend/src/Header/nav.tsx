import React, { useState } from 'react';
import { TicketIcon } from '@heroicons/react/24/solid';
import { MapPinIcon } from '@heroicons/react/24/solid';
import user from "../image/user.png";
import logo from '../image/logocinema1.png';
import { useNavigate } from 'react-router-dom';

function Nav() {
    const [searchTerm, setSearchTerm] = useState('');
    const [isOpen, setIsOpen] = useState(false);
    const navigate = useNavigate();
    const handleSearch = (e: React.FormEvent<HTMLFormElement>) => {
        e.preventDefault();
        console.log('Tìm kiếm:', searchTerm);
    };
    const handleBooking = () => {
        navigate('/booking');
    };
    const handlelogin = () => {
        navigate('/login');
    }
    const handleIntro = () => {
        navigate('/introduce');
    }
    const handleShowtimes = () => {
        navigate('/showtimes');
    }
    const handleCinezone = () => {
        navigate('/cinezone');
    }

    return (
        <nav className="">
            <div className="flex flex-row justify-between items-center px-4">
                <div className="basis-1/6 text-center">
                    <button
                        className="w-full mt-2 text-sm text-purple-400 underline"
                        onClick={() => navigate("/")}>
                        <img
                            src={logo} alt="logo"
                            className="w-50 h-20 hover:scale-105 transition-transform duration-300"
                        />
                    </button>
                </div>
                <ul className="basis-2/6 flex items-center justify-center gap-4 mx-autos">
                    <li>
                        <button onClick={handleBooking} className="relative inline-flex items-center justify-center px-4 py-2.5 overflow-hidden tracking-tighter text-white bg-purple-800 rounded-md group">
                            <span className="absolute w-0 h-0 transition-all duration-500 ease-out bg-amber-400 rounded-full group-hover:w-56 group-hover:h-56"></span>
                            <span className="relative text-base font-semibold flex items-center gap-2 uppercase">
                                <TicketIcon className="w-6 h-6 text-white" />
                                Đặt vé ngay
                            </span>
                        </button>
                    </li>
                </ul>
                <ul className="basis-3/6 flex justify-end items-center gap-4">
                    <li>
                        <form
                            onSubmit={handleSearch}
                            className="flex items-center border border-gray-300 rounded-3xl overflow-hidden shadow-sm">
                            <input
                                type="text"
                                placeholder="Tìm phim..."
                                className="px-4 py-2 w-80 focus:outline-none focus:ring-2 focus:ring-purple-500"
                                value={searchTerm}
                                onChange={(e: React.ChangeEvent<HTMLInputElement>) => setSearchTerm(e.target.value)} />
                            <button
                                type="submit"
                                className="bg-purple-600 text-white px-4 py-2 hover:bg-purple-800 transition">
                                Tìm
                            </button>
                        </form>
                    </li>
                    <li>
                        <button onClick={handlelogin} className="px-4 py-2 text-sm text-white font-semibold rounded-3xl shadow-md transition-transform transform bg-transparent border border-white hover:scale-90 hover:border-purple-600 hover:shadow-purple-900/50 hover:shadow-xl focus:outline-none">
                            <img src={user}
                                alt="account"
                                className="w-7 flex items-center" />
                        </button>

                    </li>

                </ul>
            </div>
            <div className="flex-auto flex justify-between items-center px-4 py-2">
                <div className="relative flex  w-1/2">
                    <span
                        onClick={() => setIsOpen(!isOpen)}
                        className="cursor-pointer px-4 py-2 text-zinc-50 flex items-center gap-2 ">
                        <MapPinIcon className="w-5 h-5 text-purple-400" />
                        Chọn rạp
                    </span>
                    {/* Khối div xổ ra */}
                    {isOpen && (
                        <div className="absolute left-0 top-full w-max mt-2 z-50 ">
                            <div className="grid grid-cols-3 gap-5 p-4  bg-[#0f172a] backdrop-blur-md rounded shadow-lg w-full ">
                                <div onClick={handleCinezone}
                                    className="text-slate-200 font-bold cursor-pointer  ">Cinema Hòa Hưng (TP.HCM)
                                </div>
                                <div>
                                    <a href="https://cinestar.com.vn/" className="text-slate-200 font-bold">Cinema Vũng Tàu (TP.HCM)</a>
                                </div>
                                <div>
                                    <a href="https://cinestar.com.vn/" className="text-slate-200 font-bold">Cinema Hòa Hưng (TP.HCM)</a>
                                </div>
                            </div>
                        </div>
                    )}

                    <span
                        onClick={(handleShowtimes)}
                        className="cursor-pointer px-4 py-2 text-zinc-50 flex items-center gap-2">
                        <MapPinIcon className="w-5 h-5 text-purple-400" />
                        Chọn lịch chiếu
                    </span>
                </div>
                <div className="flex relative w-1/2 justify-end ">
                    <div>
                        <span onClick={handleIntro}
                            className="cursor-pointer px-4 py-2 text-zinc-50 flex items-center gap-2">
                            Giới thiệu
                        </span>
                    </div>
                </div>
            </div>
        </nav>
    );
}

export default Nav;
