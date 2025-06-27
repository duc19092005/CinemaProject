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
        <div className="container mx-auto p-4 bg-slate-100 rounded-lg shadow">
            <div className="flex flex-wrap gap-2">
                <h2 className=" flex flex-row justify-center items-center pr-7 font-bold text-2xl text-slate-700">
                    ĐẶT VÉ NHANH
                </h2>
                <select
                    value={cinema}
                    onChange={(e) => setCinema(e.target.value)}
                    className="w-full md:flex-1 min-w-[150px] p-2 rounded">
                    <option value="">1. Chọn Rạp</option>
                    <option value="Cinestar Quốc Thanh (TP.HCM)">Cinestar Quốc Thanh (TP.HCM)</option>
                    <option value="Cinestar Quốc Thanh (TP.HCM)">Cinestar Quốc Thanh (TP.HCM)</option>
                </select>
                <select
                    value={movie}
                    onChange={(e) => setMovie(e.target.value)}
                    className="w-full md:flex-1 min-w-[150px] p-2 rounded">
                    <option value="">2. Chọn Phim</option>
                    <option value="Tấm Cám chuyện chưa kể">Tấm Cám chuyện chưa kể</option>
                    <option value="Mượn hồn đoạt xác">Mượn hồn đoạt xác</option>
                </select>
                <select
                    value={date}
                    onChange={(e) => setDate(e.target.value)}
                    className="w-full md:flex-1 min-w-[150px] p-2 rounded">
                    <option value="">3. Chọn Ngày</option>
                    <option value="2025-06-28">28/06/2025</option>
                    <option value="2025-06-29">29/06/2025</option>
                </select>
                <select
                    value={session}
                    onChange={(e) => setSession(e.target.value)}
                    className="w-full md:flex-1 min-w-[150px] p-2 rounded">
                    <option value="">4. Chọn Suất</option>
                    <option value="10:30 - 2D Standard">10:30 - 2D Standard</option>
                    <option value="11:10 - 2D Standard">11:10 - 2D Standard</option>
                </select>
                <button
                    onClick={handleBooking}
                    className=" overflow-hidden relative w50 p-2 h-12 bg-purple-600 text-white border-none rounded-md text-base font-bold cursor-pointer z-10 group">
                    ĐẶT NGAY
                    <span className="absolute w-60 h-40 -top-12 -left-10 bg-white rotate-12 transform scale-x-0 group-hover:scale-x-100 transition-transform group-hover:duration-500 duration-1000 origin-left"></span>
                    <span className="absolute w-60 h-40 -top-12 -left-10 bg-orange-400 rotate-12 transform scale-x-0 group-hover:scale-x-100 transition-transform group-hover:duration-700 duration-700 origin-left"></span>
                    <span className="absolute w-60 h-40 -top-12 -left-10 bg-orange-600 rotate-12 transform scale-x-0 group-hover:scale-x-100 transition-transform group-hover:duration-1000 duration-500 origin-left"></span>
                    <span className="flex flex-row items-center justify-center group-hover:opacity-100 group-hover:duration-1000 duration-100 opacity-0 absolute z-10 inset-0">
                        ĐẶT NGAY
                    </span>
                </button>
            </div>
        </div>
    );
};
export default QuickBooking;