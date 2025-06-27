import './App.css';
import Nav from './Header/nav';
import Bottom from './Footer/bottom';
import MovieSlider from "./MovieSlider";
import React, { useState } from "react";
import { Swiper, SwiperSlide } from "swiper/react";
import "swiper/css";
import "swiper/css/navigation";
import { Navigation } from "swiper/modules";
import QuickBooking from "./Bookig/QuickBooking";



function App() {
  const [showTrailer, setShowTrailer] = useState(false);
  const [trailerUrl, setTrailerUrl] = useState("");

  const handleOpenTrailer = (url: string) => {
    let embedUrl = url;

    // 👉 Chuyển đổi URL trailer sang dạng nhúng
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
      title: "MƯỢN HỒN ĐOẠT XÁC (T18)",
      image: "https://th.bing.com/th/id/OIP.C73d3caZ6TlIhZIih-uzggHaLW?w=783&h=1200&rs=1&pid=ImgDetMain",
      trailer: "https://youtu.be/miUjcCPpVGo",
    },
    {
      title: "NHIỆM VỤ BẤT KHẢ THI",
      image: "https://th.bing.com/th/id/OIP.C73d3caZ6TlIhZIih-uzggHaLW?w=783&h=1200&rs=1&pid=ImgDetMain",
      trailer: "https://youtu.be/miUjcCPpVGo",
    },
    {
      title: "NĂM MƯƠI (T18)",
      image: "https://th.bing.com/th/id/R.4b3f8ee56b9334f4958f75a5f45362a9?rik=JkvbTUiZTAlZYQ&pid=ImgRaw&r=0g",
      trailer: "https://youtu.be/miUjcCPpVGo",
    },
  ];

  const renderMovieSlide = (movie: any, index: number) => (
    <SwiperSlide key={index}>
      <div className="flex flex-col items-center">
        <img
          src={movie.image}
          alt={movie.title}
          onClick={() => handleOpenTrailer(movie.trailer)}
          className="w-80 h-[500px] object-cover rounded shadow-xl hover:scale-105 transition-transform duration-300 cursor-pointer"
        />
        <p className="text-white mt-4 font-semibold text-center">{movie.title}</p>
        <div className="mt-2 flex gap-2">
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
    </SwiperSlide>
  );
  const renderMovieSlide1 = (movie: any, index: number) => (
    <SwiperSlide key={index}>
      <div className="flex flex-col items-center">
        <img
          src={movie.image}
          alt={movie.title}
          onClick={() => handleOpenTrailer(movie.trailer)}
          className="w-80 h-[500px] object-cover rounded shadow-xl hover:scale-105 transition-transform duration-300 cursor-pointer"
        />
        <p className="text-white mt-4 font-semibold text-center">{movie.title}</p>
        <div className="mt-2 flex gap-2">
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
    </SwiperSlide>
  );
  return (
    <div className="App bg-slate-900">
      <div className="sticky top-0 z-50 bg-slate-900 shadow-md">
        <header>
          <div className="content-wrapper max-w-screen-xl text-base mx-auto px-8">
            <Nav />
          </div>
        </header>
      </div>
      <div className="content-wrapper max-w-screen-xl text-base mx-auto px-8 bg-slate-900 min-h-screen">
        <main className="flex flex-col gap-6 p-4">
          <MovieSlider />
          <QuickBooking />
          {/* Phim đang chiếu */}
          <section>
            <h2 className="text-3xl text-white font-bold py-5 uppercase">-- Phim đang chiếu --</h2>
            <Swiper slidesPerView={4} spaceBetween={30} navigation modules={[Navigation]} className="mySwiper px-6">
              {movies.map(renderMovieSlide)}
            </Swiper>
          </section>
          {/* Nút Xem thêm */}
          <div className="pt-12">
            <button
              onClick={() => window.open("https://tailwindcss.com/docs/flex-basis", "_blank")}
              type="submit"
              className="flex justify-center gap-2 items-center mx-auto shadow-xl text-base bg-purple-600 backdrop-blur-md lg:font-semibold isolation-auto
                    border-gray-50 before:absolute before:w-full before:transition-all before:duration-700 before:hover:w-full before:-left-full before:hover:left-0 
                    before:rounded-full before:bg-orange-500 hover:text-gray-50 before:-z-10 before:aspect-square before:hover:scale-150 before:hover:duration-700 
                    relative z-10 px-4 py-2 overflow-hidden border-2 rounded-full group">
              Xem thêm
              <svg
                className="w-6 h-6 justify-end group-hover:rotate-90 group-hover:bg-gray-50 text-gray-50 ease-linear duration-300 rounded-full border border-gray-700
                      group-hover:border-none p-2 rotate-45"
                viewBox="0 0 16 19"
                xmlns="http://www.w3.org/2000/svg">
                <path
                  d="M7 18C7 18.5523 7.44772 19 8 19C8.55228 19 9 18.5523 9 18H7ZM8.70711 0.292893C8.31658 -0.0976311 7.68342 -0.0976311 7.29289 0.292893L0.928932 6.65685C0.538408 7.04738 0.538408 7.68054 0.928932 8.07107C1.31946 8.46159 1.95262 8.46159 2.34315 8.07107L8 2.41421L13.6569 8.07107C14.0474 8.46159 14.6805 8.46159 15.0711 8.07107C15.4616 7.68054 15.4616 7.04738 15.0711 6.65685L8.70711 0.292893ZM9 18L9 1H7L7 18H9Z"
                  className="fill-gray-800 group-hover:fill-gray-800"
                ></path>
              </svg>
            </button>
          </div>
          {/* Phim sắp chiếu */}
          <section>
            <h2 className="text-3xl text-white font-bold py-5 uppercase">-- Phim sắp chiếu --</h2>
            <Swiper slidesPerView={4} spaceBetween={30} navigation modules={[Navigation]} className="mySwiper px-6">
              {movies.map(renderMovieSlide1)}
            </Swiper>
          </section>
          {/* Nút Xem thêm */}
          <div className="pt-12">
            <button
              onClick={() => window.open("https://tailwindcss.com/docs/flex-basis", "_blank")}
              type="submit"
              className="flex justify-center gap-2 items-center mx-auto shadow-xl text-base bg-purple-600 backdrop-blur-md lg:font-semibold isolation-auto
                    border-gray-50 before:absolute before:w-full before:transition-all before:duration-700 before:hover:w-full before:-left-full before:hover:left-0 
                    before:rounded-full before:bg-orange-500 hover:text-gray-50 before:-z-10 before:aspect-square before:hover:scale-150 before:hover:duration-700 
                    relative z-10 px-4 py-2 overflow-hidden border-2 rounded-full group">
              Xem thêm
              <svg
                className="w-6 h-6 justify-end group-hover:rotate-90 group-hover:bg-gray-50 text-gray-50 ease-linear duration-300 rounded-full border border-gray-700
                      group-hover:border-none p-2 rotate-45"
                viewBox="0 0 16 19"
                xmlns="http://www.w3.org/2000/svg">
                <path
                  d="M7 18C7 18.5523 7.44772 19 8 19C8.55228 19 9 18.5523 9 18H7ZM8.70711 0.292893C8.31658 -0.0976311 7.68342 -0.0976311 7.29289 0.292893L0.928932 6.65685C0.538408 7.04738 0.538408 7.68054 0.928932 8.07107C1.31946 8.46159 1.95262 8.46159 2.34315 8.07107L8 2.41421L13.6569 8.07107C14.0474 8.46159 14.6805 8.46159 15.0711 8.07107C15.4616 7.68054 15.4616 7.04738 15.0711 6.65685L8.70711 0.292893ZM9 18L9 1H7L7 18H9Z"
                  className="fill-gray-800 group-hover:fill-gray-800"
                ></path>
              </svg>
            </button>
          </div>
        </main>

        {/* Trailer popup */}
        {showTrailer && (
          <div className="fixed inset-0 bg-black bg-opacity-80 flex items-center justify-center z-50">
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

      <footer className="pt-32">
        <Bottom />
      </footer>
    </div>
  );
}

export default App;
