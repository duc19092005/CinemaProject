import React from "react";
import Nav from "../Header/nav";
import Bottom from "../Footer/bottom";
import logo from "../image/logocinema1.png";
import Snowfall from "../Components/Snowfall";


function Introduce() {

    return (
        <div className="min-h-screen bg-fixed w-full bg-cover bg-center"
            style={{ backgroundImage: "url('https://images8.alphacoders.com/136/thumb-1920-1368754.jpeg')" }}>
            <Snowfall />
            <div className="sticky top-0 z-50 bg-slate-900 shadow-md mb-4 ">
                <div className="max-w-screen-xl mx-auto px-8">
                    <Nav />
                </div>
            </div>
            <div>
                <div className="w-full">
                    {/* Banner */}
                    <div
                        className="w-full h-64 bg-cover bg-center flex items-center justify-center"
                        style={{
                            backgroundImage:
                                "url('https://cinestar.com.vn/pictures/moi/vechungtoi/slider.jpg')",
                        }}
                    >
                        <h1 className="text-white text-4xl md:text-5xl font-bold drop-shadow-lg text-center uppercase ">
                            Giới Thiệu Cinema
                        </h1>
                    </div>

                    {/* Content */}
                    <div className="max-w-5xl mx-auto py-12 px-4 md:px-0 space-y-8 text-gray-700">
                        <h2 className="text-2xl font-semibold text-white">
                            Về Chúng Tôi
                        </h2>
                        <p className="leading-relaxed text-white text-lg">
                            Hệ thống rạp chiếu phim CINEHA là một thương hiệu rạp phim mới,
                            phục vụ nhu cầu thưởng thức phim ảnh chất lượng cao với giá vé phù hợp
                            cho mọi đối tượng khán giả. CINEHA được đầu tư hệ thống thiết bị hiện đại
                            đạt chuẩn quốc tế về chiếu phim và âm thanh.
                        </p>
                        <p className="leading-relaxed text-white text-lg">
                            Chúng tôi luôn cam kết mang đến cho khách hàng trải nghiệm xem phim tuyệt vời nhất,
                            không gian thoải mái, dịch vụ chuyên nghiệp và các chương trình ưu đãi hấp dẫn.
                        </p>
                        {/* Hình minh họa */}
                        <div className="w-full flex justify-center text-white">
                            <img
                                src={logo} alt="logo"
                                className="w-96 h-44 hover:scale-105 transition-transform duration-300"
                            />
                        </div>
                        <h2 className="text-2xl font-semibold  text-white">
                            Tầm Nhìn & Sứ Mệnh
                        </h2>
                        <p className="leading-relaxed text-white pb-32 text-lg">
                            CINEHA phấn đấu trở thành chuỗi rạp chiếu phim được yêu thích nhất,
                            không ngừng đổi mới và nâng cao chất lượng phục vụ để đáp ứng sự tin tưởng của khách hàng.
                        </p>
                        <div
                            className="group relative flex justify-center items-center text-zinc-600 text-sm font-bold">
                            <div
                                className="absolute opacity-0 group-hover:opacity-100 group-hover:-translate-y-[150%] -translate-y-[300%] duration-500 group-hover:delay-500 skew-y-[20deg] group-hover:skew-y-0 shadow-md">
                                <div className="bg-lime-200 flex items-center gap-1 p-2 rounded-md uppercase">
                                    <svg
                                        className="stroke-zinc-600"
                                        xmlns="http://www.w3.org/2000/svg"
                                        width="20px"
                                        height="20px"
                                        viewBox="0 0 24 24"
                                        fill="none"
                                    >
                                    </svg>
                                    <span>🫶 CINEHA XIN CHÂN THÀNH CẢM ƠN 🫶   </span>
                                </div>
                                <div
                                    className="shadow-md bg-lime-200 absolute bottom-0 translate-y-1/2 left-1/2 translate-x-full rotate-45 p-1"
                                ></div>
                                <div
                                    className="rounded-md bg-white group-hover:opacity-0 group-hover:scale-[115%] group-hover:delay-700 duration-500 w-full h-full absolute top-0 left-0"
                                >
                                    <div
                                        className="border-b border-r border-white bg-white absolute bottom-0 translate-y-1/2 left-1/2 translate-x-full rotate-45 p-1"
                                    ></div>
                                </div>
                            </div>

                            <div className="shadow-md flex items-center group-hover:gap-2 bg-gradient-to-br from-lime-200 to-yellow-200 p-3 rounded-full cursor-pointer duration-300">
                                <span>❤️</span>
                                <span className="text-[0px] group-hover:text-sm duration-300"
                                >CẢM ƠN VÌ ĐÃ CHỌN CHÚNG TÔI ❤️</span>
                            </div>
                        </div>

                    </div>
                </div>
            </div>
            <div className="pt-32 min-w-full">
                <Bottom />
            </div>
        </div>
    );
}

export default Introduce;
