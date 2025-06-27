import React, { useState } from "react";
import Nav from "../Header/nav";
import Bottom from "../Footer/bottom";

function Listfilm() {
    const [showTrailer, setShowTrailer] = useState(false);
    const [trailerUrl, setTrailerUrl] = useState("");

    const handleOpenTrailer = (url: string) => {
        let embedUrl = url;

        if (url.includes("watch?v=")) {
            embedUrl = url.replace("watch?v=", "embed/");
        } else if (url.includes("youtu.be/")) {
            const videoId = url.split("youtu.be/")[1];
            embedUrl = `https://www.youtube.com/embed/${videoId}`;
        }

        setTrailerUrl(embedUrl);
        setShowTrailer(true);
    };

    const movies = [
        {
            title: "BUÔN THẦN BÁN THÁNH (T16)",
            image: "https://bloganchoi.com/wp-content/uploads/2019/03/tam-cam-chuyen-chua-ke.jpg",
            trailer: "https://www.youtube.com/watch?v=Ud-YVnRK_kY",
        },
        {
            title: "LÂM GIANG TIÊN (T18)",
            image: "https://static2.vieon.vn/vieplay-image/poster_v4/2025/06/02/djtoaqo5_660x946-lamgiangtien2.png",
            trailer: "https://youtu.be/-hTr-NBoDnU?si=idCRW93f3kx6j7ZV",
        },
        {
            title: "TRƯỜNG NGUYỆT TẪN MINH",
            image: "https://bazaarvietnam.vn/wp-content/uploads/2023/04/harper-bazaar-review-phim-truong-nguyet-tan-minh-till-the-end-of-the-moon-101-e1680702014162.jpg",
            trailer: "https://youtu.be/7kRzVm_umc0?si=bjoPQPcEVgsWZ2AL",
        },
        {
            title: "Tấm Cám chuyện Quỳnh Lập kể",
            image: "https://cdn.eva.vn/upload/2-2017/images/2017-05-10/tam-cam-chuyen-huynh-lap-ke-hay-chuyen-ai-cho-tao-luong-thien-cua-me-ghe-ac-nhat-hanh-tinh-tamcam-huynh-lap-1494403229-width500height683.jpg",
            trailer: "https://youtu.be/I5SL4kNC7rk?si=HSB1PYMD2C6x6N0p",
        },
        {
            title: "BÍ KÍP LUYỆN RỒNG (K)",
            image: "https://cinestar.com.vn/_next/image/?url=https%3A%2F%2Fapi-website.cinestar.com.vn%2Fmedia%2Fwysiwyg%2FPosters%2F06-2025%2Fbi-kip-luyen-rong_1.jpg&w=1200&q=75",
            trailer: "https://youtu.be/JD-idNoeiPE",
        },
        {
            title: "NĂM MƯƠI (T18)",
            image: "https://th.bing.com/th/id/R.4b3f8ee56b9334f4958f75a5f45362a9?rik=JkvbTUiZTAlZYQ&pid=ImgRaw&r=0g",
            trailer: "https://youtu.be/miUjcCPpVGo",
        },
        {
            title: "BUÔN THẦN BÁN THÁNH (T16)",
            image: "https://bloganchoi.com/wp-content/uploads/2019/03/tam-cam-chuyen-chua-ke.jpg",
            trailer: "https://www.youtube.com/watch?v=Ud-YVnRK_kY",
        },
        {
            title: "Tấm Cám chuyện Quỳnh Lập kể",
            image: "https://cdn.eva.vn/upload/2-2017/images/2017-05-10/tam-cam-chuyen-huynh-lap-ke-hay-chuyen-ai-cho-tao-luong-thien-cua-me-ghe-ac-nhat-hanh-tinh-tamcam-huynh-lap-1494403229-width500height683.jpg",
            trailer: "https://youtu.be/I5SL4kNC7rk?si=HSB1PYMD2C6x6N0p",
        },
        {
            title: "LÂM GIANG TIÊN (T18)",
            image: "https://static2.vieon.vn/vieplay-image/poster_v4/2025/06/02/djtoaqo5_660x946-lamgiangtien2.png",
            trailer: "https://youtu.be/-hTr-NBoDnU?si=idCRW93f3kx6j7ZV",
        },
        {
            title: "TRƯỜNG NGUYỆT TẪN MINH",
            image: "https://bazaarvietnam.vn/wp-content/uploads/2023/04/harper-bazaar-review-phim-truong-nguyet-tan-minh-till-the-end-of-the-moon-101-e1680702014162.jpg",
            trailer: "https://youtu.be/7kRzVm_umc0?si=bjoPQPcEVgsWZ2AL",
        },
        {
            title: "BÍ KÍP LUYỆN RỒNG (K)",
            image: "https://cinestar.com.vn/_next/image/?url=https%3A%2F%2Fapi-website.cinestar.com.vn%2Fmedia%2Fwysiwyg%2FPosters%2F06-2025%2Fbi-kip-luyen-rong_1.jpg&w=1200&q=75",
            trailer: "https://youtu.be/JD-idNoeiPE",
        },
        {
            title: "Tấm Cám chuyện Quỳnh Lập kể",
            image: "https://cdn.eva.vn/upload/2-2017/images/2017-05-10/tam-cam-chuyen-huynh-lap-ke-hay-chuyen-ai-cho-tao-luong-thien-cua-me-ghe-ac-nhat-hanh-tinh-tamcam-huynh-lap-1494403229-width500height683.jpg",
            trailer: "https://youtu.be/I5SL4kNC7rk?si=HSB1PYMD2C6x6N0p",
        },
        {
            title: "NĂM MƯƠI (T18)",
            image: "https://th.bing.com/th/id/R.4b3f8ee56b9334f4958f75a5f45362a9?rik=JkvbTUiZTAlZYQ&pid=ImgRaw&r=0g",
            trailer: "https://youtu.be/miUjcCPpVGo",
        },
        {
            title: "BUÔN THẦN BÁN THÁNH (T16)",
            image: "https://bloganchoi.com/wp-content/uploads/2019/03/tam-cam-chuyen-chua-ke.jpg",
            trailer: "https://www.youtube.com/watch?v=Ud-YVnRK_kY",
        },
        {
            title: "TRƯỜNG NGUYỆT TẪN MINH",
            image: "https://bazaarvietnam.vn/wp-content/uploads/2023/04/harper-bazaar-review-phim-truong-nguyet-tan-minh-till-the-end-of-the-moon-101-e1680702014162.jpg",
            trailer: "https://youtu.be/7kRzVm_umc0?si=bjoPQPcEVgsWZ2AL",
        },
        {
            title: "Tấm Cám chuyện Quỳnh Lập kể",
            image: "https://cdn.eva.vn/upload/2-2017/images/2017-05-10/tam-cam-chuyen-huynh-lap-ke-hay-chuyen-ai-cho-tao-luong-thien-cua-me-ghe-ac-nhat-hanh-tinh-tamcam-huynh-lap-1494403229-width500height683.jpg",
            trailer: "https://youtu.be/I5SL4kNC7rk?si=HSB1PYMD2C6x6N0p",
        },
        {
            title: "BÍ KÍP LUYỆN RỒNG (K)",
            image: "https://cinestar.com.vn/_next/image/?url=https%3A%2F%2Fapi-website.cinestar.com.vn%2Fmedia%2Fwysiwyg%2FPosters%2F06-2025%2Fbi-kip-luyen-rong_1.jpg&w=1200&q=75",
            trailer: "https://youtu.be/JD-idNoeiPE",
        },
        {
            title: "Tấm Cám chuyện Quỳnh Lập kể",
            image: "https://cdn.eva.vn/upload/2-2017/images/2017-05-10/tam-cam-chuyen-huynh-lap-ke-hay-chuyen-ai-cho-tao-luong-thien-cua-me-ghe-ac-nhat-hanh-tinh-tamcam-huynh-lap-1494403229-width500height683.jpg",
            trailer: "https://youtu.be/I5SL4kNC7rk?si=HSB1PYMD2C6x6N0p",
        },
        {
            title: "TRƯỜNG NGUYỆT TẪN MINH",
            image: "https://bazaarvietnam.vn/wp-content/uploads/2023/04/harper-bazaar-review-phim-truong-nguyet-tan-minh-till-the-end-of-the-moon-101-e1680702014162.jpg",
            trailer: "https://youtu.be/7kRzVm_umc0?si=bjoPQPcEVgsWZ2AL",
        },
        {
            title: "BÍ KÍP LUYỆN RỒNG (K)",
            image: "https://cinestar.com.vn/_next/image/?url=https%3A%2F%2Fapi-website.cinestar.com.vn%2Fmedia%2Fwysiwyg%2FPosters%2F06-2025%2Fbi-kip-luyen-rong_1.jpg&w=1200&q=75",
            trailer: "https://youtu.be/JD-idNoeiPE",
        },
        {
            title: "NĂM MƯƠI (T18)",
            image: "https://th.bing.com/th/id/R.4b3f8ee56b9334f4958f75a5f45362a9?rik=JkvbTUiZTAlZYQ&pid=ImgRaw&r=0g",
            trailer: "https://youtu.be/miUjcCPpVGo",
        },
        {
            title: "LÂM GIANG TIÊN (T18)",
            image: "https://static2.vieon.vn/vieplay-image/poster_v4/2025/06/02/djtoaqo5_660x946-lamgiangtien2.png",
            trailer: "https://youtu.be/-hTr-NBoDnU?si=idCRW93f3kx6j7ZV",
        },
        {
            title: "TRƯỜNG NGUYỆT TẪN MINH",
            image: "https://bazaarvietnam.vn/wp-content/uploads/2023/04/harper-bazaar-review-phim-truong-nguyet-tan-minh-till-the-end-of-the-moon-101-e1680702014162.jpg",
            trailer: "https://youtu.be/7kRzVm_umc0?si=bjoPQPcEVgsWZ2AL",
        },
        {
            title: "BÍ KÍP LUYỆN RỒNG (K)",
            image: "https://cinestar.com.vn/_next/image/?url=https%3A%2F%2Fapi-website.cinestar.com.vn%2Fmedia%2Fwysiwyg%2FPosters%2F06-2025%2Fbi-kip-luyen-rong_1.jpg&w=1200&q=75",
            trailer: "https://youtu.be/JD-idNoeiPE",
        },
        {
            title: "Tấm Cám chuyện Quỳnh Lập kể",
            image: "https://cdn.eva.vn/upload/2-2017/images/2017-05-10/tam-cam-chuyen-huynh-lap-ke-hay-chuyen-ai-cho-tao-luong-thien-cua-me-ghe-ac-nhat-hanh-tinh-tamcam-huynh-lap-1494403229-width500height683.jpg",
            trailer: "https://youtu.be/I5SL4kNC7rk?si=HSB1PYMD2C6x6N0p",
        },
        {
            title: "NĂM MƯƠI (T18)",
            image: "https://th.bing.com/th/id/R.4b3f8ee56b9334f4958f75a5f45362a9?rik=JkvbTUiZTAlZYQ&pid=ImgRaw&r=0g",
            trailer: "https://youtu.be/miUjcCPpVGo",
        },
    ];

    return (
        <div className="App bg-slate-900 min-h-screen">
            {/* Header */}
            <div className="sticky top-0 z-50 bg-slate-900 shadow-md">
                <header>
                    <div className="max-w-screen-xl mx-auto px-8">
                        <Nav />
                    </div>
                </header>
            </div>

            {/* Main Content */}
            <main className="max-w-screen-xl mx-auto px-8 py-12">
                <h2 className="text-3xl text-white font-bold mb-8 uppercase">-- Phim đang chiếu --</h2>
                <div className="grid grid-cols-1 sm:grid-cols-2 md:grid-cols-3 lg:grid-cols-4 gap-8">
                    {movies.map((movie, index) => (
                        <div key={index} className="bg-slate-800 rounded-xl shadow-lg p-4 flex flex-col items-center">
                            <img
                                src={movie.image}
                                alt={movie.title}
                                className="w-full h-[420px] object-cover rounded-md cursor-pointer hover:scale-105 transition"
                                onClick={() => handleOpenTrailer(movie.trailer)}
                            />
                            <h3 className="text-white font-semibold text-center mt-4">{movie.title}</h3>
                            <div className="mt-3 flex gap-3">
                                <button
                                    onClick={() => handleOpenTrailer(movie.trailer)}
                                    className="p-3 rounded-full backdrop-blur-lg border border-red-500/20 bg-gradient-to-tr from-black/60 to-black/40 shadow-lg hover:shadow-2xl hover:shadow-red-500/30 hover:scale-110 hover:rotate-2 active:scale-95 active:rotate-0 transition-all duration-300 ease-out cursor-pointer group relative overflow-hidden"
                                >
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
                                <button
                                    onClick={() => window.open("https://tailwindcss.com/docs/flex-basis", "_blank")}
                                    className="overflow-hidden relative w50 p-2 h-12 bg-purple-600 text-white border-none rounded-md text-base font-bold cursor-pointer z-10 group"
                                >
                                    🎟 Đặt vé ngay
                                    <span className="absolute w-60 h-40 -top-12 -left-10 bg-white rotate-12 transform scale-x-0 group-hover:scale-x-100 transition-transform group-hover:duration-500 duration-1000 origin-left"></span>
                                    <span className="absolute w-60 h-40 -top-12 -left-10 bg-orange-400 rotate-12 transform scale-x-0 group-hover:scale-x-100 transition-transform group-hover:duration-700 duration-700 origin-left"></span>
                                    <span className="absolute w-60 h-40 -top-12 -left-10 bg-orange-600 rotate-12 transform scale-x-0 group-hover:scale-x-100 transition-transform group-hover:duration-1000 duration-500 origin-left"></span>
                                    <span className="flex flex-row items-center justify-center group-hover:opacity-100 group-hover:duration-1000 duration-100 opacity-0 absolute z-10 inset-0">
                                        🎟 Đặt vé ngay
                                    </span>
                                </button>
                            </div>
                        </div>
                    ))}
                </div>
            </main>

            {/* Trailer Popup */}
            {showTrailer && (
                <div className="fixed inset-0 bg-black/80 flex items-center justify-center z-50">
                    <div className="bg-black rounded-lg p-4 relative w-[90%] md:w-[60%] aspect-video">
                        <button
                            onClick={() => setShowTrailer(false)}
                            className="absolute top-2 right-2 text-white text-2xl font-bold"
                        >
                            ✕
                        </button>
                        <iframe
                            src={trailerUrl}
                            title="Trailer"
                            className="w-full h-full rounded-md"
                            allowFullScreen
                        />
                    </div>
                </div>
            )}

            {/* Footer */}
            <footer className="pt-32">
                <Bottom />
            </footer>
        </div>
    );
}

export default Listfilm;
