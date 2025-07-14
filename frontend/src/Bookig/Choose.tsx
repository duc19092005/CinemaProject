import React, { useState } from 'react';

function Choose() {
    const timecinema = [
        { id: "1", time: "10:00" },
        { id: "2", time: "12:00" },
        { id: "3", time: "14:00" },
        { id: "4", time: "16:00" },
        { id: "5", time: "18:00" },
    ];
    //Khai báo interface cho Cinema
    interface Timecinema {
        id: string;
        time: string;
    }
    //Khai báo state cho Cinema
    //Sử dụng Timecinema để định nghĩa kiểu dữ liệu cho selectedCinema
    const [selectedCinema, setSelectedCinema] = useState<Timecinema | null>(null);
    const [isOpen, setIsOpen] = useState(false);
    const handleSelect = (cinema: any) => {
        setSelectedCinema(cinema);
        setIsOpen(false);
    };
    return (
        <div>
            <div className="mb-6 flex flex-col items-center">
                <div className="relative w-[500px] max-w-xl mx-auto">
                    {/* Button hiển thị */}
                    <button
                        onClick={() => setIsOpen(!isOpen)}
                        className="w-full bg-transparent border border-gray-300 rounded px-4 py-2 focus:outline-none focus:ring-2 focus:ring-yellow-300">
                        {selectedCinema ? (
                            <div>
                                <p className="flex justify-center items-center font-semibold text-white">{selectedCinema.time}</p>
                            </div>
                        ) : (
                            <span className="text-gray-400">-- Chọn thời gian --</span>
                        )}
                    </button>

                    {/* Danh sách dropdown */}
                    {isOpen && (
                        <div className="absolute z-10 w-full mt-2 bg-white border border-gray-300 rounded shadow-lg max-h-60 overflow-y-auto">
                            {timecinema.map((cinema) => (
                                <div
                                    key={cinema.id}
                                    onClick={() => handleSelect(cinema)}
                                    className="px-4 py-2 hover:bg-yellow-100 cursor-pointer"
                                >
                                    <p className="font-semibold text-black">{cinema.time}</p>
                                </div>
                            ))}
                        </div>
                    )}
                </div>
            </div>
        </div>
    );
}

export default Choose;