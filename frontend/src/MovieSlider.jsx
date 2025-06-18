import React from "react";
import { Swiper, SwiperSlide } from "swiper/react";
import { Navigation } from "swiper/modules";
import "swiper/css";
import "swiper/css/navigation";

const MovieSlider = () => {
    const slides = [
        {
            image: "https://api-website.cinestar.com.vn/media/MageINIC/bannerslider/chaching.jpg",
        },
        {
            image: "https://api-website.cinestar.com.vn/media/MageINIC/bannerslider/1215wx365h_6_.jpg",
        },
        {
            image: "https://api-website.cinestar.com.vn/media/MageINIC/bannerslider/1215wx365h_7_.jpg",
        },
        {
            image: "https://api-website.cinestar.com.vn/media/MageINIC/bannerslider/1215wx365h_7_.jpg",
        },
        {
            image: "https://api-website.cinestar.com.vn/media/MageINIC/bannerslider/1215wx365h_7_.jpg",
        },
    ];

    return (
        <div className="w-full bg-[#0d1128]">
            <Swiper
                navigation={true}
                modules={[Navigation]}
                className="mySwiper w-full h-[400px]"
            >
                {slides.map((slide, index) => (
                    <SwiperSlide key={index}>
                        <div
                            className="relative w-full h-full bg-cover bg-center rounded-md overflow-hidden"
                            style={{ backgroundImage: `url(${slide.image})` }}
                        >
                            {/* Nút "ĐẶT VÉ NGAY" */}
                            <div className="absolute bottom-6 right-6">
                                <a href="https://tailwindcss.com/docs/flex-basis" className=" ">
                                    <button class="w-[150px] bg-purple-800 h-[50px] my-3 flex items-center justify-center font-bold rounded-xl cursor-pointer relative overflow-hidden transition-all duration-500 ease-in-out shadow-md hover:scale-105 hover:shadow-lg before:absolute before:top-0 before:-left-full before:w-full before:h-full before:bg-gradient-to-r before:from-[#f3ea28] before:to-[rgb(200,213,98)] before:transition-all before:duration-500 before:ease-in-out before:z-[-1] before:rounded-xl hover:before:left-0 text-[#000]">
                                        ĐẶT VÉ NGAY
                                    </button>
                                </a>
                            </div>

                        </div>
                    </SwiperSlide>
                ))}
            </Swiper>
        </div>
    );
};

export default MovieSlider;
