import React from "react";
import { useNavigate } from "react-router-dom";
import Nav from '../Header/nav';
import Bottom from "../Footer/bottom";

function Booking() {
    const navigate = useNavigate();

    return (
        <div>
            <div className="min-h-screen bg-slate-900 text-white p-8">
                <div className="sticky top-0 z-50 bg-slate-900 shadow-md">
                    <header>
                        <div className="content-wrapper max-w-screen-xl text-base mx-auto px-8">
                            <Nav />
                        </div>
                    </header>
                </div>
                <h1 className="text-4xl font-bold mb-6 text-center">🎟 Trang Đặt Vé</h1>

                <div className="max-w-xl mx-auto bg-slate-800 p-6 rounded-lg shadow-lg space-y-4">
                    <div>
                        <label className="block mb-1 font-semibold">Chọn phim</label>
                        <select className="w-full p-2 rounded bg-slate-700 text-white">
                            <option>BUÔN THẦN BÁN THÁNH</option>
                            <option>MƯỢN HỒN ĐOẠT XÁC</option>
                            <option>NHIỆM VỤ BẤT KHẢ THI</option>
                            <option>NĂM MƯƠI</option>
                        </select>
                    </div>

                    <div>
                        <label className="block mb-1 font-semibold">Chọn suất chiếu</label>
                        <select className="w-full p-2 rounded bg-slate-700 text-white">
                            <option>10:00</option>
                            <option>14:30</option>
                            <option>18:00</option>
                            <option>21:00</option>
                        </select>
                    </div>

                    <div>
                        <label className="block mb-1 font-semibold">Số lượng vé</label>
                        <input
                            type="number"
                            min="1"
                            defaultValue="1"
                            className="w-full p-2 rounded bg-slate-700 text-white"
                        />
                    </div>

                    <button
                        className="w-full bg-purple-600 hover:bg-purple-700 transition p-3 rounded text-lg font-bold"
                        onClick={() => alert("Đặt vé thành công!")}
                    >
                        ✅ Xác nhận đặt vé
                    </button>
                    <button
                        className="w-full mt-2 text-sm text-purple-400 underline"
                        onClick={() => navigate("/")}
                    >
                        ← Quay về trang chính
                    </button>
                </div>
            </div>
            <footer>
                <Bottom />
            </footer>
        </div>


    );

}

export default Booking;
