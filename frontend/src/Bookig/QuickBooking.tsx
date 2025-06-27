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
        <div className="bg-[#eaf0ff] p-4 rounded-lg flex flex-col md:flex-row items-center gap-4 shadow-md justify-center w-full">
            <h2 className="basic1/6 text-2xl font-extrabold text-gray-800 whitespace-nowrap">
                ĐẶT VÉ NHANH
            </h2>
            <div className="basis-5/6">
                <select
                    value={cinema}
                    onChange={(e) => setCinema(e.target.value)}
                    className="border rounded-md px-4 py-2 font-bold text-purple-700 ">
                    <option value="">1. Chọn Rạp</option>
                    <option value="Rạp 1">Rạp 1</option>
                    <option value="Rạp 2">Rạp 2</option>
                    <option value="Rạp 3">Rạp 3</option>
                </select>
                <select
                    value={movie}
                    onChange={(e) => setMovie(e.target.value)}
                    className="border rounded-md px-4 py-2 font-bold text-purple-700">
                    <option value="">2. Chọn Phim</option>
                    <option value="Phim 1">Phim 1</option>
                    <option value="Phim 2">Phim 2</option>
                    <option value="Phim 3">Phim 3</option>
                </select>
                <select
                    value={date}
                    onChange={(e) => setDate(e.target.value)}
                    className="border rounded-md px-4 py-2 font-bold text-purple-700">
                    <option value="">3. Chọn Ngày</option>
                    <option value="2024-06-28">28/06/2024</option>
                    <option value="2024-06-29">29/06/2024</option>
                    <option value="2024-06-30">30/06/2024</option>
                </select>
                <select
                    value={session}
                    onChange={(e) => setSession(e.target.value)}
                    className="border rounded-md px-4 py-2 font-bold text-purple-700">
                    <option value="">4. Chọn Suất</option>
                    <option value="9:00">9:00</option>
                    <option value="12:00">12:00</option>
                    <option value="15:00">15:00</option>
                </select>
                <button
                    onClick={handleBooking}
                    className="bg-purple-600 hover:bg-purple-700 text-white font-bold px-6 py-2 rounded-md">
                    ĐẶT NGAY
                </button>
            </div>
        </div>
    );
};
export default QuickBooking;
