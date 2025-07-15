import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import App from './Home';
import reportWebVitals from './reportWebVitals';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import Login from './Account/Login';
import Register from './Account/Register';
import Listfilm from './Cinema/Listfilm';
import Forgotpassword from './Account/Forgotpass';
import Comingmovies from './Cinema/Comingmovies';
import Introduce from './Cinema/Introduce';
import Showtimes from './Bookig/Showtimes';
import Cinezone from './Cinema/Cinezone';
import PaymentPage from './Bookig/PaymentPage';
import Info from './Account/Info';
import QLRap from './HomeQLRap'
import Comment from './Cinema/Comment';
import FutureFilm from './Bookig/FutureFilm';

ReactDOM.createRoot(document.getElementById('root')!).render(
  <React.StrictMode>
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<App />} />
        <Route path="/login" element={< Login />} />
        <Route path="/register" element={<Register />} />
        <Route path="/listfilm" element={<Listfilm />} />
        <Route path="/forgotpassword" element={<Forgotpassword />} />
        <Route path="/comingmovies" element={<Comingmovies />} />
        <Route path="/introduce" element={<Introduce />} />
        <Route path="/showtimes" element={<Showtimes />} />
        <Route path="/cinezone" element={<Cinezone />} />
        <Route path="/payment" element={<PaymentPage />} />
        <Route path="/info" element={<Info />} />
        <Route path="/QLRap/Home" element={<QLRap />} />
        <Route path="/comment" element={<Comment />} />
        <Route path="/futurefilm" element={<FutureFilm />} />
      </Routes>
    </BrowserRouter>
  </React.StrictMode>
);
reportWebVitals();
