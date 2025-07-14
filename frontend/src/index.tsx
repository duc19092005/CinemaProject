import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import QLNV from './HomeQLRap';
import reportWebVitals from './reportWebVitals';
import { BrowserRouter, Routes, Route } from 'react-router-dom';

const root = ReactDOM.createRoot(
  document.getElementById('root') as HTMLElement
);

root.render(
    <BrowserRouter>
      <Routes>
        <Route path="/QLNV" element={<QLNV />} />
      </Routes>
    </BrowserRouter>
);
reportWebVitals();
