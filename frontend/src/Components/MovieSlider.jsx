import React from "react";
import { Swiper, SwiperSlide } from "swiper/react";
import { Navigation, Autoplay } from "swiper/modules";
import "swiper/css";
import "swiper/css/navigation";
import { useNavigate } from "react-router-dom";

const MovieSlider = () => {
    const navigate = useNavigate();
    const handleShowtimes = () => {
        navigate("/showtimes");
    }
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
                modules={[Navigation, Autoplay]}
                autoplay={{ delay: 2000, disableOnInteraction: false }}
                className="mySwiper w-full"
            >
                {slides.map((slide, index) => (
                    <SwiperSlide key={index}>
                        <div className="relative w-full flex justify-center items-center">
                            <img
                                onClick={handleShowtimes}
                                src={slide.image}
                                alt={`slide-${index}`}
                                className="w-full max-h-[400px] object-cover aspect-[1215/365] rounded-md"
                            />
                        </div>
                    </SwiperSlide>
                ))}
            </Swiper>
        </div>
    );
};

export default MovieSlider;
