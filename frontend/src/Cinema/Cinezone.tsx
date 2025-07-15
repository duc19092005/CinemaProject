import React, { useState } from "react";
import Nav from "../Header/nav";
import Footer from "../Footer/bottom";
import filmszone from "../image/filmszone.jpg";
import { useNavigate } from "react-router-dom";

function TabsExample() {
    const navigate = useNavigate();
    const handleShowTimes = () => {
        navigate("/showtimes");
    }
    const handleFutureFilm = () => {
        navigate("/futurefilm");
    };
    // State lưu tab đang active
    const [activeTab, setActiveTab] = useState("tab1");
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
    const movies123 = [

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
        <div className="min-h-screen bg-fixed w-full bg-cover bg-center top-0"
            style={{ backgroundImage: "url('https://images8.alphacoders.com/136/thumb-1920-1368754.jpeg')" }}>
            <div className=" top-0 z-50 bg-slate-950 shadow-md sticky">
                <div className=" content-wrapper max-w-screen-xl text-base mx-auto px-8 ">
                    <Nav />
                </div>
            </div>
            <div className="pt-3">
                <div className="h-48 w-full bg-cover bg-center mx-auto max-w-screen-xl rounded-xl pt-10"
                    style={{ backgroundImage: `url(${filmszone})` }} >
                    <div className="flex h-full text-white p-4">
                        <ul className="S text-lg font-semibold">
                            <li className="flex justify-center items-center pb-3 text-xl">CINEMA HÒA HƯNG</li>
                            <li className="pl-8 flex flex-row items-center gap-2">
                                <img src="data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAADAAAAAwCAYAAABXAvmHAAAACXBIWXMAAAsTAAALEwEAmpwYAAADdElEQVR4nO1aTYxLURS+/glDGOad8zoIGRLjZ0ksiN9ggYXdbIWYjBA2bCwkYm9BJhLJRKxsiAWRiGrPaY1gw4iVkGAI8T8T2nu5cltU/IxzX99rO4kvOUnTtOd+3/l79933lPqPMmwmnGkId2rG04bhtmZ4qRm1JixqxheG8KZm7DGE2y3PDFWjQGdho2FMa8LPhtFKrPRbgiuawnX1JU54Q0r6r0aQr6kQe2vqFE1wpmriv2aFscdyc1Oy5K+l5mmC+3GTNxUR92y+tS0R8oV8y2JN+Dwp8qYiot9ehwWxkndTQxM8Tpq8+dHk8NT2plrjIX9LjXEjsFbkTcV6bVqNrlqAJjxcB/K2ZASHqos+4SzN8NFvUbxjCPcWKFhoLwcTnbnP7jtDeNezlAZtvjUVPfqMx+XNB58MQ6e1auRfA3JWjTIUdGmCgoeIY9Giz81NmvC9lLzmYLU4MLlgjVSEJnzrsugtQDNsk6cbdvn6N4S75dnFrREEYLe05ocqmyHLibFPmIUT3gLE+5wc7vF2/n0Nhn3CDLO389IWWODcZqE9qoBCLlgkLKFnEQS4qSIQkJ4xKaoAy81N0iHhL4BgUCSgih2k7Z02WZiBDxEE4MMGKqEH3s4NYUY4hfYm3sSEV72da4ajQud33Uj09e/+oxnvCcfoEX8BBJtkI86JCLp8/bvxa4T+dQ43eAuwF9vGaYbXsghBQWfDtfLghOvcaYWR+X5l+9rHegsoLwQnxVFyexvC3UOVU+nqm8M9UvKm3MDdKiqK2WCZuIwq1uea000Yd41wVp42sF9a8+YnK+aDpaoaGAaKICIeI8yoaqE53FIvAZrCzVULKGWBIF+H6N+wVo2IRUAxBytrHn2W3yCJYAjO104AnFNxo3yDjwPJ1z0M2kwwRyUBQ3iwBrV/QCUFd9CUaEMT3nQHaYkJKImglrnS0wq/psUBmw3nq1rAPYlJIAM7akL+hwiGCzGSvxTbzJfCXm8J3FF4DKXT73ypeqDI4XKfY8LfyBMWi4wrVD3hbmaiZwA6VSNAM5yKUDqnVaPA5lsneD0EcfM+PXu8aiTYzHTUhI/+XffwJLbHR3HDnRFphjdDNO27Qja1RDUyNAWr/jSZSq8cEK5XwwGGsOPnVw/KrxZghxpOMAyd38h/ifIARDUCSttvwoNJLvIVJsM8X30cKTwAAAAASUVORK5CYII=" alt="marker--v1" className="w-6"></img>
                                828 Sư Vạn Hạnh, Phường Hòa Hưng, TP Hồ Chí Minh</li>
                        </ul>
                    </div>
                </div>
                {/* Tab header */}
                <div className="flex border-b border-gray-300 justify-center items-center mb-4 space-x-40 text-lg pt-5">
                    <button
                        onClick={() => setActiveTab("tab1")}
                        className={`text-white font-medium text-xl px-4 py-2 ${activeTab === "tab1" ? "border-b-2 border-yellow-500 font-semibold px-10 text-yellow-500" : ""}`}>
                        Phim đang chiếu
                    </button>
                    <button
                        onClick={() => setActiveTab("tab2")}
                        className={`text-white font-medium text-xl px-4 py-2 ${activeTab === "tab2" ? "border-b-2 border-yellow-500 font-semibold px-10 text-yellow-500" : ""}`}>
                        Phim sắp chiếu
                    </button>
                </div>
                {/* Nội dung tab */}
                <div className="p-4 text-white max-w-screen-xl mx-auto px-8 py-12 top-0">
                    {activeTab === "tab1" && <div><div className="grid grid-cols-1 sm:grid-cols-2 md:grid-cols-3 lg:grid-cols-4 gap-8">
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
                                        onClick={handleShowTimes}
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
                    </div></div>}
                    {activeTab === "tab2" && <div><div className="grid grid-cols-1 sm:grid-cols-2 md:grid-cols-3 lg:grid-cols-4 gap-8">
                        {movies123.map((movie, index) => (
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
                                        onClick={(handleFutureFilm)}
                                        className="overflow-hidden relative w50 p-2 h-12 bg-purple-600 text-white border-none rounded-md text-base font-bold cursor-pointer z-10 group"
                                    >
                                        🎟 Tìm hiểu thêm
                                        <span className="absolute w-60 h-40 -top-12 -left-10 bg-white rotate-12 transform scale-x-0 group-hover:scale-x-100 transition-transform group-hover:duration-500 duration-1000 origin-left"></span>
                                        <span className="absolute w-60 h-40 -top-12 -left-10 bg-orange-400 rotate-12 transform scale-x-0 group-hover:scale-x-100 transition-transform group-hover:duration-700 duration-700 origin-left"></span>
                                        <span className="absolute w-60 h-40 -top-12 -left-10 bg-orange-600 rotate-12 transform scale-x-0 group-hover:scale-x-100 transition-transform group-hover:duration-1000 duration-500 origin-left"></span>
                                        <span className="flex flex-row items-center justify-center group-hover:opacity-100 group-hover:duration-1000 duration-100 opacity-0 absolute z-10 inset-0">
                                            🎟 Tìm hiểu thêm
                                        </span>
                                    </button>
                                </div>
                            </div>
                        ))}
                    </div></div>}
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
                </div>
                <div>
                    <Footer />
                </div>
            </div>
        </div>
    );
}

export default TabsExample;
