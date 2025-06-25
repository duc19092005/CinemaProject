import React, { useEffect, useRef } from 'react';

const movies = [
  { id: 1, title: "Avengers: Endgame", poster: "https://image.tmdb.org/t/p/w500/q6725aR8Zs4IwGMXzZT8aC8lh41.jpg" },
  { id: 2, title: "Joker", poster: "https://image.tmdb.org/t/p/w500/udDclJoHjfjb8Ekgsd4FDteOkCU.jpg" },
  { id: 3, title: "Interstellar", poster: "https://image.tmdb.org/t/p/w500/rAiYTfKGqDCRIIqo664sY9XZIvQ.jpg" },
  { id: 4, title: "Inception", poster: "https://image.tmdb.org/t/p/w500/9gk7adHYeDvHkCSEqAvQNLV5Uge.jpg" },
  { id: 5, title: "The Dark Knight", poster: "https://image.tmdb.org/t/p/w500/qJ2tW6WMUDux911r6m7haRef0WH.jpg" },
  { id: 6, title: "Tenet", poster: "https://image.tmdb.org/t/p/w500/k68nPLbIST6NP96JmTxmZijEvCA.jpg" },
  { id: 7, title: "Spider-Man: No Way Home", poster: "https://image.tmdb.org/t/p/w500/1g0dhYtq4irTY1GPXvft6k4YLjm.jpg" },
  { id: 8, title: "Doctor Strange 2", poster: "https://image.tmdb.org/t/p/w500/9Gtg2DzBhmYamXBS1hKAhiwbBKS.jpg" },
  { id: 9, title: "Black Panther: Wakanda Forever", poster: "https://image.tmdb.org/t/p/w500/sv1xJUazXeYqALzczSZ3O6nkH75.jpg" },
  { id: 10, title: "Dune", poster: "https://image.tmdb.org/t/p/w500/d5NXSklXo0qyIYkgV94XAgMIckC.jpg" },
  { id: 11, title: "Guardians of the Galaxy Vol. 3", poster: "https://image.tmdb.org/t/p/w500/r2J02Z2OpNTctfOSN1Ydgii51I3.jpg" },
  { id: 12, title: "Shang-Chi", poster: "https://image.tmdb.org/t/p/w500/1BIoJGKbXjdFDAqUEiA2VHqkK1Z.jpg" },
  { id: 13, title: "Oppenheimer", poster: "https://image.tmdb.org/t/p/w500/ptpr0kGAckfQkJeJIt8st5dglvd.jpg" },
  { id: 14, title: "Barbie", poster: "https://image.tmdb.org/t/p/w500/iuFNMS8U5cb6xfzi51Dbkovj7vM.jpg" },
  { id: 15, title: "The Flash", poster: "https://image.tmdb.org/t/p/w500/rktDFPbfHfUbArZ6OOOKsXcv0Bm.jpg" },
];

export default function App() {
  const scrollRef = useRef(null);
  const loopMovies = [...movies, ...movies]; // lặp vô hạn

  useEffect(() => {
    const container = scrollRef.current;
    let animationFrame;

    const scroll = () => {
      if (container) {
        container.scrollLeft += 1;
        if (container.scrollLeft >= container.scrollWidth / 2) {
          container.scrollLeft = 0;
        }
      }
      animationFrame = requestAnimationFrame(scroll);
    };

    scroll(); // bắt đầu cuộn

    return () => cancelAnimationFrame(animationFrame);
  }, []);

  return (
    <div className="bg-gray-900 text-white min-h-screen flex flex-col font-quicksand text-[20px]">
      {/* Navbar */}
      <header className="bg-black p-4 flex justify-between items-center">
        <div className="flex items-center gap-3">
          <img src="https://huflit.edu.vn/wp-content/uploads/2024/03/HUFLIT_Logo_English_Official.png" alt="HUFLIT Logo" className="w-12 h-12" />
          <h1 className="text-2xl font-bold">🎬 Màn hình nhân viên</h1>
        </div>
      </header>

      {/* Layout 2: Tất cả phim (auto scroll vô hạn) */}
      <section className="p-6">
        <h3 className="text-xl font-semibold mb-4">🎬 Tất cả phim</h3>
        <div
          ref={scrollRef}
          className="flex overflow-x-auto space-x-4 py-4 scrollbar-hide scroll-smooth"
        >
          {loopMovies.map((movie, idx) => (
            <div
              key={`${movie.id}_scroll_${idx}`}
              className="min-w-[200px] w-[200px] h-[340px] flex-shrink-0 bg-gray-800 rounded-lg overflow-hidden shadow hover:scale-105 transition flex flex-col"
            >
              <div className="h-[220px] w-full overflow-hidden">
                <img
                  src={movie.poster}
                  alt={movie.title}
                  className="w-full h-full object-cover"
                />
              </div>
              <div className="flex-1 flex flex-col justify-between p-3">
                <h4 className="text-md font-semibold mb-1">{movie.title}</h4>
                <button className="bg-red-500 hover:bg-red-600 text-white text-sm px-3 py-1 rounded">
                  Đặt vé
                </button>
              </div>
            </div>
          ))}
        </div>
      </section>

      {/* Banner */}
      <section className="bg-cover bg-center h-64 flex items-center justify-center" style={{ backgroundImage: 'url(https://image.tmdb.org/t/p/original/6Wdl9N6dL0Hi0T1qJLWSz6gMLbd.jpg)' }}>
        <div className="bg-black bg-opacity-60 p-6 rounded">
          <h2 className="text-3xl font-bold">Chào mừng đến với MovieTickets</h2>
          <p className="text-lg">Đặt vé xem phim nhanh chóng và tiện lợi!</p>
        </div>
      </section>

      {/* Layout 1: Phim đang chiếu */}
      <section className="p-6">
        <h3 className="text-xl font-semibold mb-4">🎞️ Phim đang chiếu</h3>
        <div className="grid grid-cols-1 sm:grid-cols-2 md:grid-cols-3 lg:grid-cols-4 xl:grid-cols-5 gap-6">
          {movies.map(movie => (
            <div
              key={movie.id}
              className="bg-gray-800 rounded-lg overflow-hidden shadow-lg hover:scale-105 transition flex flex-col"
            >
              <div className="h-[250px] w-full overflow-hidden">
                <img
                  src={movie.poster}
                  alt={movie.title}
                  className="w-full h-full object-cover"
                />
              </div>
              <div className="flex-1 flex flex-col justify-between p-4 h-[130px]">
                <h4 className="text-lg font-bold mb-2">{movie.title}</h4>
                <button className="bg-red-500 hover:bg-red-600 text-white px-4 py-2 rounded">
                  Đặt vé
                </button>
              </div>
            </div>
          ))}
        </div>
      </section>

      {/* Footer */}
      <footer className="bg-black text-center p-4 mt-auto">
        &copy; 2025 Màn hình khách hàng. All rights reserved.
      </footer>
    </div>
  );
}
