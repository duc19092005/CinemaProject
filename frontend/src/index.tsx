import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import App from './App';
import reportWebVitals from './reportWebVitals';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import Booking from './Bookig/Booking';
import Login from './Account/Login';
import Register from './Account/Register';
import Listfilm from './Cinema/Listfilm';
import Forgotpassword from './Account/Forgotpass';
import Comingmovies from './Cinema/Comingmovies';
import Introduce from './Cinema/Introduce';
import Showtimes from './Bookig/Showtimes';


ReactDOM.createRoot(document.getElementById('root')!).render(
  <React.StrictMode>
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<App />} />
        <Route path="/booking" element={<Booking />} />
        <Route path="/login" element={< Login />} />
        <Route path="/register" element={<Register />} />
        <Route path="/listfilm" element={<Listfilm />} />
        <Route path="/forgotpassword" element={<Forgotpassword />} />
        <Route path="/comingmovies" element={<Comingmovies />} />
        <Route path="/introduce" element={<Introduce />} />
        <Route path="/showtimes" element={<Showtimes />} />
      </Routes>
    </BrowserRouter>
  </React.StrictMode>
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
