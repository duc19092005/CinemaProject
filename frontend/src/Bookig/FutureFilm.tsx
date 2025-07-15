import React, { useState, useEffect } from "react";
import Nav from "../Header/nav";
import Bottom from "../Footer/bottom";
import { useNavigate } from "react-router-dom";
import Clock from "../Components/Clock";
import Choose from "./Choose";

function FutureFilm() {

    const [showTrailer, setShowTrailer] = useState(false);
    const [trailerUrl, setTrailerUrl] = useState("");

    const movieInfo = {
        name: "Úc Lan Oán Linh Giữ Của",
        genre: "Kinh dị",
        duration: 111,
        country: "Việt Nam",
        director: "Trần Trọng Dần",
        actors: "Quốc Trường, Mạc Văn Khoa,...",
        releaseDate: "20/06/2025",
        description: "Sau sự ra đi của cha, Lan (Phương Thanh) về một vùng quê và ở đợ cho nhà ông Danh (Mạc Văn Khoa)...",
        poster: "https://cinestar.com.vn/_next/image/?url=https%3A%2F%2Fapi-website.cinestar.com.vn%2Fmedia%2Fwysiwyg%2FPosters%2F06-2025%2Fut-lan-poster.jpg&w=3840&q=75",
        trailer: "https://www.youtube.com/watch?v=7kRzVm_umc0"
    };

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
        <div className="min-h-screen bg-fixed w-full bg-cover bg-center top-0" style={{ backgroundImage: "url('https://images8.alphacoders.com/136/thumb-1920-1368754.jpeg')" }}>
            <div className="sticky top-0 z-50 bg-slate-900 shadow-md mb-4">
                <div className="max-w-screen-xl mx-auto px-8">
                    <Nav />
                </div>
            </div>

            <div className="flex flex-col items-center px-10">
                {/* Movie Info */}
                <div className="flex flex-col md:flex-row gap-6 mb-6 justify-center items-center">
                    <div>
                        <div>
                            <img src={movieInfo.poster} alt="Poster" className="w-full max-w-[400px] rounded-lg shadow-lg" />
                        </div>
                    </div>
                    <div>
                        <h1 className="text-3xl font-bold text-yellow-400 mb-2 uppercase">{movieInfo.name}</h1>
                        <ul className="text-white mb-4">
                            <li><span className="text-yellow-400 font-bold">Thể loại:</span> <span className="pl-6">{movieInfo.genre}</span></li>
                            <li><span className="text-yellow-400 font-bold">Thời lượng:</span> <span className="pl-6">{movieInfo.duration}'</span></li>
                            <li><span className="text-yellow-400 font-bold">Quốc gia:</span> <span className="pl-6">{movieInfo.country}</span></li>
                            <li><span className="text-yellow-400 font-bold">Đạo diễn:</span> <span className="pl-6">{movieInfo.director}</span></li>
                            <li><span className="text-yellow-400 font-bold">Diễn viên:</span> <span className="pl-6">{movieInfo.actors}</span></li>
                            <li><span className="text-yellow-400 font-bold">Khởi chiếu:</span> <span className="pl-6">{movieInfo.releaseDate}</span></li>
                        </ul>
                        <p className="max-w-[600px] mb-4 text-white">{movieInfo.description}</p>
                        <div className="px-6 pt-6">
                            <button onClick={() => handleOpenTrailer(trailerRawUrl)}
                                className="p-3 rounded-full backdrop-blur-lg border border-red-500/20 bg-gradient-to-tr from-black/60 to-black/40 shadow-lg hover:shadow-2xl hover:shadow-red-500/30 hover:scale-110 hover:rotate-2 active:scale-95 active:rotate-0 transition-all duration-300 ease-out cursor-pointer group relative overflow-hidden">
                                <div className="absolute inset-0 bg-gradient-to-r from-transparent via-red-400/20 to-transparent -translate-x-full group-hover:translate-x-full transition-transform duration-700 ease-out"></div>
                                <div className="relative z-10">
                                    <svg
                                        className="w-7 h-7 fill-current text-red-500 group-hover:text-red-400 transition-colors duration-300"
                                        viewBox="0 0 576 512"
                                        xmlns="http://www.w3.org/2000/svg"
                                    >
                                        <path
                                            d="M549.655 124.083c-6.281-23.65-24.787-42.276-48.284-48.597C458.781 64 288 64 288 64S117.22 64 74.629 75.486c-23.497 6.322-42.003 24.947-48.284 48.597-11.412 42.867-11.412 132.305-11.412 132.305s0 89.438 11.412 132.305c6.281 23.65 24.787 41.5 48.284 47.821C117.22 448 288 448 288 448s170.78 0 213.371-11.486c23.497-6.321 42.003-24.171 48.284-47.821 11.412-42.867 11.412-132.305 11.412-132.305s0-89.438-11.412-132.305zm-317.51 213.508V175.185l142.739 81.205-142.739 81.201z"
                                        ></path>
                                    </svg>
                                </div>
                            </button>
                        </div>
                    </div>
                </div>
            </div>
            <div className="flex flex-row justify-center items-center py-10 mb-56 px-10" >
                <img src="data:image/png;base64,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" alt="film-reel"></img>
                <p className="text-center text-4xl font-bold text-white uppercase ">hiện chưa có lịch chiếu</p>
            </div>

            {/* Trailer Modal */}
            {showTrailer && (
                <div className="fixed inset-0 bg-black bg-opacity-80 flex justify-center items-center z-50" onClick={() => setShowTrailer(false)}>
                    <div className="relative w-full max-w-3xl aspect-video">
                        <iframe width="100%" height="100%" src={trailerUrl} title="Trailer" frameBorder="0" allowFullScreen />
                        <button onClick={() => setShowTrailer(false)} className="absolute top-2 right-2 text-white text-2xl">✕</button>
                    </div>
                </div>
            )}

            <footer>
                <Bottom />
            </footer>
        </div>
    );
}

export default FutureFilm;