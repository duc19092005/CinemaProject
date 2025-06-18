import React from 'react';
import './App.css';
import Nav from './Header/nav';
import Bottom from './Footer/bottom';
import MovieSlider from "./MovieSlider"; // chỉnh đường dẫn nếu khác


function App() {
  return (
    <div className="App">
      <div className="content-wrapper max-w-screen-2xl text-base mx-auto px-8 bg-slate-900 text-white min-h-screen">
        {/* Header */}
        <header>
          <Nav />
        </header>

        {/* Main */}
        <main className="flex flex-col gap-6 p-4">

          <div className="bg-slate-900 ">
            <MovieSlider />
          </div>
          <div className="text-1 font-bold text-xl uppercase">Phim đang chiếu</div>
          <a href="https://tailwindcss.com/docs/flex-basis" className=" ">
            <button
              type="submit"
              className="flex justify-center gap-2 items-center mx-auto shadow-xl text-base bg-purple-600 backdrop-blur-md lg:font-semibold isolation-auto border-gray-50 before:absolute before:w-full before:transition-all before:duration-700 before:hover:w-full before:-left-full before:hover:left-0 before:rounded-full before:bg-orange-500 hover:text-gray-50 before:-z-10 before:aspect-square before:hover:scale-150 before:hover:duration-700 relative z-10 px-4 py-2 overflow-hidden border-2 rounded-full group">
              Xem thêm
              <svg
                className="w-8 h-8 justify-end group-hover:rotate-90 group-hover:bg-gray-50 text-gray-50 ease-linear duration-300 rounded-full border border-gray-700 group-hover:border-none p-2 rotate-45"
                viewBox="0 0 16 19"
                xmlns="http://www.w3.org/2000/svg">
                <path
                  d="M7 18C7 18.5523 7.44772 19 8 19C8.55228 19 9 18.5523 9 18H7ZM8.70711 0.292893C8.31658 -0.0976311 7.68342 -0.0976311 7.29289 0.292893L0.928932 6.65685C0.538408 7.04738 0.538408 7.68054 0.928932 8.07107C1.31946 8.46159 1.95262 8.46159 2.34315 8.07107L8 2.41421L13.6569 8.07107C14.0474 8.46159 14.6805 8.46159 15.0711 8.07107C15.4616 7.68054 15.4616 7.04738 15.0711 6.65685L8.70711 0.292893ZM9 18L9 1H7L7 18H9Z"
                  className="fill-gray-800 group-hover:fill-gray-800"
                ></path>
              </svg>
            </button>
          </a>
          <div className="text-2 font-bold text-xl uppercase">Phim sắp chiếu</div>
          <a href="https://tailwindcss.com/docs/flex-basis" className=" ">
            <button
              type="submit"
              className="flex justify-center gap-2 items-center mx-auto shadow-xl text-base bg-purple-600 backdrop-blur-md lg:font-semibold isolation-auto border-gray-50 before:absolute before:w-full before:transition-all before:duration-700 before:hover:w-full before:-left-full before:hover:left-0 before:rounded-full before:bg-orange-500 hover:text-gray-50 before:-z-10 before:aspect-square before:hover:scale-150 before:hover:duration-700 relative z-10 px-4 py-2 overflow-hidden border-2 rounded-full group">
              Xem thêm
              <svg
                className="w-8 h-8 justify-end group-hover:rotate-90 group-hover:bg-gray-50 text-gray-50 ease-linear duration-300 rounded-full border border-gray-700 group-hover:border-none p-2 rotate-45"
                viewBox="0 0 16 19"
                xmlns="http://www.w3.org/2000/svg">
                <path
                  d="M7 18C7 18.5523 7.44772 19 8 19C8.55228 19 9 18.5523 9 18H7ZM8.70711 0.292893C8.31658 -0.0976311 7.68342 -0.0976311 7.29289 0.292893L0.928932 6.65685C0.538408 7.04738 0.538408 7.68054 0.928932 8.07107C1.31946 8.46159 1.95262 8.46159 2.34315 8.07107L8 2.41421L13.6569 8.07107C14.0474 8.46159 14.6805 8.46159 15.0711 8.07107C15.4616 7.68054 15.4616 7.04738 15.0711 6.65685L8.70711 0.292893ZM9 18L9 1H7L7 18H9Z"
                  className="fill-gray-800 group-hover:fill-gray-800"
                ></path>
              </svg>
            </button>
          </a>

          <div className="voucher font-bold text-xl uppercase">Khuyến mãi</div>
          <a href="https://tailwindcss.com/docs/flex-basis" className=" ">
            <button
              className="overflow-hidden relative w-56 p-2 h-12 bg-purple-600 text-white border-none rounded-md text-base font-bold cursor-pointer z-10 group">
              Tất cả ưu đãi
              <span
                className="absolute w-60 h-40 -top-12 -left-2 bg-white rotate-12 transform scale-x-0 group-hover:scale-x-100 transition-transform group-hover:duration-500 duration-1000 origin-left"></span>
              <span
                className="absolute w-60 h-40 -top-12 -left-2 bg-orange-400 rotate-12 transform scale-x-0 group-hover:scale-x-100 transition-transform group-hover:duration-700 duration-700 origin-left"></span>
              <span
                className="absolute w-60 h-40 -top-12 -left-2 bg-orange-600 rotate-12 transform scale-x-0 group-hover:scale-x-100 transition-transform group-hover:duration-1000 duration-500 origin-left"></span>
              <span
                className="group-hover:opacity-100 group-hover:duration-1000 duration-100 opacity-0 absolute top-2.5 left-12 z-10 "
              >Tất cả ưu đãi!</span>
            </button>
          </a>


          <div className="friend font-bold text-xl uppercase">Chương trình thành viên</div>
          <div className="button-dk bg-green-600 px-4 py-2 rounded text-white w-max">Đăng ký thành viên</div>

          <div className="story font-bold text-xl uppercase">Story</div>
          <div className="more-products font-bold text-xl uppercase">Giải trí</div>
          <div className="subcribe-us font-bold text-xl uppercase">Subscribe Us</div>
        </main>

        {/* Footer */}
        <footer>
          <Bottom />
        </footer>
      </div>
    </div>
  );
}

export default App;
