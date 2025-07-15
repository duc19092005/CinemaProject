import React, { useState } from "react";
import { useNavigate } from "react-router-dom";

const QuickBooking: React.FC = () => {
    const [cinema, setCinema] = useState("");
    const [movie, setMovie] = useState("");
    const [date, setDate] = useState("");
    const [session, setSession] = useState("");

    const navigate = useNavigate();

    const handleBooking = () => {
        if (!cinema || !movie || !date || !session) {
            alert("Vui lòng chọn đầy đủ thông tin!");
            return;
        }

        console.log({
            cinema,
            movie,
            date,
            session,
        });

        // Ví dụ chuyển trang
        navigate("/booking");
    };

    return (
        <div className="container mx-auto p-4 bg-sky-50 rounded-lg shadow">
            <h2 className="text-center font-bold text-2xl text-slate-700 mb-4">ĐẶT VÉ NHANH</h2>

            <div className="grid grid-cols-1 md:grid-cols-5 gap-4 ">
                <select
                    value={cinema}
                    onChange={(e) => setCinema(e.target.value)}
                    className="w-full p-2 rounded-xl text-[#081b3d] font-medium border border-blue-950 focus:outline-none focus:ring-2 focus:ring-blue-500">
                    <option value="">1. Chọn Rạp</option>
                    <option value="Cinestar Quốc Thanh (TP.HCM)">Cinestar Quốc Thanh (TP.HCM)</option>
                </select>

                <select
                    value={movie}
                    onChange={(e) => setMovie(e.target.value)}
                    className="w-full p-2 rounded-xl text-[#081b3d] font-medium border border-blue-950 focus:outline-none focus:ring-2 focus:ring-blue-500">
                    <option value="">2. Chọn Phim</option>
                    <option value="Tấm Cám chuyện chưa kể">Tấm Cám chuyện chưa kể</option>
                </select>

                <select
                    value={date}
                    onChange={(e) => setDate(e.target.value)}
                    className="w-full p-2 rounded-xl text-[#081b3d] font-medium border border-blue-950 focus:outline-none focus:ring-2 focus:ring-blue-500">
                    <option value="">3. Chọn Ngày</option>
                    <option value="2025-06-28">28/06/2025</option>
                </select>

                <select
                    value={session}
                    onChange={(e) => setSession(e.target.value)}
                    className="w-full p-2 rounded-xl text-[#081b3d] font-medium border border-blue-950 focus:outline-none focus:ring-2 focus:ring-blue-500">
                    <option value="">4. Chọn Suất</option>
                    <option value="10:30 - 2D Standard">10:30 - 2D Standard</option>
                </select>
                <button
                    onClick={handleBooking}
                    className="group/button relative inline-flex items-center justify-center overflow-hidden rounded-md bg-[#081b3d] backdrop-blur-lg px-6 py-2 text-base font-semibold text-white transition-all duration-300 ease-in-out hover:scale-110 hover:shadow-xl hover:shadow-blue-600/50 border border-white/20">
                    <span className="text-lg">Đặt vé ngay!</span>
                    <div
                        className="absolute inset-0 flex h-full w-full justify-center [transform:skew(-13deg)_translateX(-100%)] group-hover/button:duration-1000 group-hover/button:[transform:skew(-13deg)_translateX(100%)]">
                        <div className="relative h-full w-10 bg-white/30"></div>
                    </div>
                </button>
            </div>
        </div>

    );
};
export default QuickBooking;