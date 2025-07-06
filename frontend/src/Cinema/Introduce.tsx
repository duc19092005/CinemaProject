import React, { useState } from "react";
import Nav from "../Header/nav";
import Bottom from "../Footer/bottom";
import { useNavigate } from "react-router-dom";

function Introduce() {
    const navigate = useNavigate();
    const [ticketCounts, setTicketCounts] = useState<{ [key: string]: number }>({});
    const [comboCounts, setComboCounts] = useState<{ [key: string]: number }>({});
    const [selectedSeats, setSelectedSeats] = useState<number[]>([]);
    const [showTrailer, setShowTrailer] = useState(false);
    const [trailerUrl, setTrailerUrl] = useState("");

    const ticketTypes = [
        { key: "adult", label: "Người lớn", price: 75000 },
        { key: "student", label: "HSSV/Cao tuổi", price: 45000 },
        { key: "vip", label: "Người lớn - BDD", price: 155000 },
    ];

    const combos = [
        { key: "combo2", label: "Combo 2 Ngăn", price: 109000 },
        { key: "comboNhaGau", label: "Combo Nhà Gấu", price: 129000 },
        { key: "comboCoGau", label: "Combo Cỏ Gấu", price: 129000 },
    ];

    const toggleSeat = (seatNumber: number) => {
        setSelectedSeats((prev) =>
            prev.includes(seatNumber)
                ? prev.filter((n) => n !== seatNumber)
                : [...prev, seatNumber]
        );
    };

    const totalTicket = Object.entries(ticketCounts).reduce(
        (sum, [key, count]) =>
            sum + (ticketTypes.find((t) => t.key === key)?.price || 0) * count,
        0
    );

    const totalCombo = Object.entries(comboCounts).reduce(
        (sum, [key, count]) =>
            sum + (combos.find((c) => c.key === key)?.price || 0) * count,
        0
    );

    const total = totalTicket + totalCombo;

    // Trailer link
    const trailerRawUrl = "https://www.youtube.com/watch?v=7kRzVm_umc0";

    const handleOpenTrailer = (url: string) => {
        let embedUrl = "";

        if (url.includes("watch?v=")) {
            const videoId = url.split("watch?v=")[1].split("&")[0];
            embedUrl = `https://www.youtube.com/embed/${videoId}`;
        } else if (url.includes("youtu.be/")) {
            const videoId = url.split("youtu.be/")[1].split("?")[0];
            embedUrl = `https://www.youtube.com/embed/${videoId}`;
        } else {
            embedUrl = url;
        }

        setTrailerUrl(embedUrl);
        setShowTrailer(true);
    };

    return (
        <div className="bg-gray-900 text-white min-h-screen p-4">
            {/* Header */}
            <div className="sticky top-0 z-50 bg-slate-900 shadow-md mb-4">
                <div className="max-w-screen-xl mx-auto px-8">
                    <Nav />
                </div>
            </div>

            <div className="flex flex-col items-center">
                {/* Movie Info */}
                <div className="flex flex-col md:flex-row gap-6 mb-6 justify-center items-center">
                    <img
                        src="https://cinestar.com.vn/_next/image/?url=https%3A%2F%2Fapi-website.cinestar.com.vn%2Fmedia%2Fwysiwyg%2FPosters%2F06-2025%2Fut-lan-poster.jpg&w=3840&q=75"
                        alt="Poster"
                        className="w-full max-w-[400px] rounded-lg shadow-lg"
                    />
                    <div>
                        <h1 className="text-3xl font-bold text-yellow-400 mb-2 uppercase">
                            úc lan oán linh giữ của
                        </h1>
                        <ul className="text-sm text-gray-300 mb-4">
                            <li>Thể loại: Kinh dị</li>
                            <li>Thời lượng: 111'</li>
                            <li>Quốc gia: Việt Nam</li>
                            <li>Đạo diễn: Trần Trọng Dần</li>
                            <li>Diễn viên: Quốc Trường, Mạc Văn Khoa,...</li>
                            <li>Khởi chiếu: 20/06/2025</li>
                        </ul>
                        <p className="max-w-[600px] mb-4">
                            Sau sự ra đi của cha, Lan (Phương Thanh) về một vùng quê và ở đợ cho
                            nhà ông Danh (Mạc Văn Khoa) - một người đàn ông góa vợ, không con cái.
                            Ngay sau khi bước chân vào căn nhà, Lan phải đối mặt với hàng loạt
                            hiện tượng kỳ dị và những cái chết bí ẩn liên tục xảy ra...
                        </p>
                        <button
                            onClick={() => handleOpenTrailer(trailerRawUrl)}
                            className="bg-red-600 hover:bg-red-700 text-white px-4 py-2 rounded"
                        >
                            Xem Trailer
                        </button>
                    </div>
                </div>
                {/* Ticket Type Selector */}
                <div className="mb-6">
                    <h2 className="text-xl font-bold text-yellow-400 mb-4">Chọn Loại Vé</h2>
                    <div className="grid grid-cols-2 md:grid-cols-3 gap-4">
                        {ticketTypes.map((t) => (
                            <div key={t.key} className="bg-gray-800 p-4 rounded">
                                <p>{t.label}</p>
                                <p className="text-yellow-400">{t.price.toLocaleString()} VND</p>
                                <div className="flex items-center gap-2 mt-2">
                                    <button
                                        onClick={() =>
                                            setTicketCounts((prev) => ({
                                                ...prev,
                                                [t.key]: Math.max((prev[t.key] || 0) - 1, 0),
                                            }))
                                        }
                                        className="bg-gray-700 px-2"
                                    >
                                        -
                                    </button>
                                    <span>{ticketCounts[t.key] || 0}</span>
                                    <button
                                        onClick={() =>
                                            setTicketCounts((prev) => ({
                                                ...prev,
                                                [t.key]: (prev[t.key] || 0) + 1,
                                            }))
                                        }
                                        className="bg-gray-700 px-2"
                                    >
                                        +
                                    </button>
                                </div>
                            </div>
                        ))}
                    </div>
                </div>
                {/* Seat Selector */}
                <div className="mb-6">
                    <h2 className="text-xl font-bold text-yellow-400 mb-4">Chọn Ghế</h2>
                    <div className="grid grid-cols-12 gap-1">
                        {Array.from({ length: 96 }).map((_, i) => (
                            <button
                                key={i}
                                onClick={() => toggleSeat(i + 1)}
                                className={`w-8 h-8 ${selectedSeats.includes(i + 1)
                                    ? "bg-yellow-400"
                                    : "bg-gray-700 hover:bg-yellow-400"
                                    }`}
                            >
                                {i + 1}
                            </button>
                        ))}
                    </div>
                </div>
                {/* Combo Selector */}
                <div className="mb-6">
                    <h2 className="text-xl font-bold text-yellow-400 mb-4">Chọn Bắp Nước</h2>
                    <div className="grid grid-cols-1 md:grid-cols-3 gap-4">
                        {combos.map((c) => (
                            <div key={c.key} className="bg-gray-800 p-4 rounded">
                                <p>{c.label}</p>
                                <p className="text-yellow-400">{c.price.toLocaleString()} VND</p>
                                <div className="flex items-center gap-2 mt-2">
                                    <button
                                        onClick={() =>
                                            setComboCounts((prev) => ({
                                                ...prev,
                                                [c.key]: Math.max((prev[c.key] || 0) - 1, 0),
                                            }))
                                        }
                                        className="bg-gray-700 px-2"
                                    >
                                        -
                                    </button>
                                    <span>{comboCounts[c.key] || 0}</span>
                                    <button
                                        onClick={() =>
                                            setComboCounts((prev) => ({
                                                ...prev,
                                                [c.key]: (prev[c.key] || 0) + 1,
                                            }))
                                        }
                                        className="bg-gray-700 px-2"
                                    >
                                        +
                                    </button>
                                </div>
                            </div>
                        ))}
                    </div>
                </div>

                {/* Cart */}
                <div className="fixed bottom-0 left-0 right-0 bg-gray-900 p-4 flex justify-between items-center text-white border-t border-gray-700">
                    <p>
                        Tạm tính:{" "}
                        <span className="text-yellow-400">{total.toLocaleString()} VND</span>
                    </p>
                    <button className="bg-red-600 hover:bg-red-700 px-4 py-2 rounded">
                        Bước Tiếp
                    </button>
                </div>
            </div>

            {/* Trailer Modal */}
            {showTrailer && (
                <div
                    className="fixed inset-0 bg-black bg-opacity-80 flex justify-center items-center z-50"
                    onClick={() => setShowTrailer(false)}
                >
                    <div className="relative w-full max-w-3xl aspect-video">
                        <iframe
                            width="100%"
                            height="100%"
                            src={trailerUrl}
                            title="Trailer"
                            frameBorder="0"
                            allowFullScreen
                        />
                        <button
                            onClick={() => setShowTrailer(false)}
                            className="absolute top-2 right-2 text-white text-2xl"
                        >
                            ✕
                        </button>
                    </div>
                </div>
            )}

            {/* Footer */}
            <footer className="mt-20">
                <Bottom />
            </footer>
        </div>
    );
}

export default Introduce;
