import React, { useState } from "react";
import './style.css';

interface Revenue {
  stt: number;
  ngay: string;
  tongDoanhThu: string;
}

const thStyle: React.CSSProperties = { padding: "8px", textAlign: "center" };
const tdStyle: React.CSSProperties = { padding: "6px", textAlign: "center", border: "1px solid #ccc" };
const modalOverlayStyle: React.CSSProperties = {
  position: "fixed", top: 0, left: 0, right: 0, bottom: 0,
  background: "rgba(0,0,0,0.5)", display: "flex", alignItems: "center", justifyContent: "center"
};

export default function QuanLy() {
  const [showAccountMenu, setShowAccountMenu] = useState(false);
  const [showLogoutModal, setShowLogoutModal] = useState(false);

  // State for revenue
  const [revenueList, setRevenueList] = useState<Revenue[]>([
    { stt: 1, ngay: "20/11/2025", tongDoanhThu: "VND 20.000" },
    { stt: 2, ngay: "19/11/2025", tongDoanhThu: "VND 120.000" },
  ]);
  const [selectedRap, setSelectedRap] = useState("Chọn");

  return (
    <div style={{
      backgroundImage: "url('/images/bg.png')",
      backgroundSize: "cover",
      backgroundPosition: "center",
      backgroundRepeat: "no-repeat",
      color: "white",
      minHeight: "100vh",
      display: "flex"
    }}>
      {/* Sidebar */}
      <div style={{
        width: "300px", background: "#231C60", padding: "16px", display: "flex",
        flexDirection: "column", gap: "12px", borderRight: "2px solid white"
      }}>
        <div style={{ display: "flex", alignItems: "center" }}>
          <img src="/images/logocinema1.png" alt="Logo" style={{ height: "40px", marginRight: "8px" }} />
        </div>
        <h3>Bạn muốn chỉnh sửa/ thêm gì</h3>
        <button className="button2">
          <span style={{ fontSize: "18px", marginRight: "8px" }}>☰</span> Doanh thu
        </button>
      </div>

      {/* Main content */}
      <div style={{ flex: 1, padding: "24px" }}>
        <div style={{ display: "flex", justifyContent: "space-between" }}>
          <h3>CINEMA MOVIE Xin chào</h3>
          <div style={{ position: "relative" }}>
            <span style={{ fontSize: "28px", cursor: "pointer" }} onClick={() => setShowAccountMenu(!showAccountMenu)}>👤</span>
            {showAccountMenu && (
              <div style={{
                position: "absolute", right: 0, top: "36px",
                background: "#231C60", color: "white", borderRadius: "4px",
                padding: "8px", minWidth: "100px", textAlign: "center"
              }}>
                <button onClick={() => { setShowLogoutModal(true); setShowAccountMenu(false); }}
                  style={{ background: "none", border: "none", color: "white", cursor: "pointer" }}>
                  Đăng xuất
                </button>
              </div>
            )}
          </div>
        </div>

        {/* Nội dung - Only Doanh thu section */}
        <div style={{ display: "flex", flexDirection: "column", alignItems: "center" }}>
          <h3 style={{ marginTop: "24px" }}>Quản lý Doanh thu</h3>
          <div style={{ display: "flex", alignItems: "center", gap: "10px", marginBottom: "20px" }}>
            <div style={{ backgroundColor: "#ddd", color: "#000", borderRadius: "4px", padding: "6px" }}>Rạp</div>
              <select
                style={{ backgroundColor: "#7e57c2", color: "white", border: "none", borderRadius: "4px", padding: "6px" }}
              >
                <option value="A01">A01</option>
                <option value="A02">A02</option>
                <option value="A03">A03</option>
                <option value="A04">A04</option>
              </select>
          </div>
          <table className="revenue-table">
            <thead>
              <tr>
                <th style={thStyle}>STT</th>
                <th style={thStyle}>Ngày</th>
                <th style={thStyle}>Tổng doanh thu</th>
              </tr>
            </thead>
            <tbody>
              {revenueList.map((item) => (
                <tr key={item.stt}>
                  <td style={tdStyle}>{item.stt}</td>
                  <td style={tdStyle}>{item.ngay}</td>
                  <td style={tdStyle}>{item.tongDoanhThu}</td>
                </tr>
              ))}
              <tr className="total-row">
                <td style={tdStyle}>Tổng doanh thu</td>
                <td style={tdStyle}></td>
                <td style={tdStyle}>VND XXX.XXX.XXXX</td>
              </tr>
            </tbody>
          </table>
        </div>

        {showLogoutModal && (
          <div style={{
            position: "fixed", top: 0, left: 0, right: 0, bottom: "0",
            background: "rgba(0,0,0,0.5)", display: "flex", justifyContent: "center", alignItems: "center"
          }}>
            <div style={{ background: "#4c65a8", padding: "24px", borderRadius: "8px", textAlign: "center", color: "white", width: "300px" }}>
              <p>Bạn chắc chắn muốn đăng xuất không?</p>
              <div style={{ display: "flex", justifyContent: "space-around", marginTop: "16px" }}>
                <button onClick={() => { alert("Đã đăng xuất"); setShowLogoutModal(false); }}
                  style={{ padding: "6px 12px", border: "none", borderRadius: "4px", background: "lightgreen", color: "black" }}>Có</button>
                <button onClick={() => setShowLogoutModal(false)}
                  style={{ padding: "6px 12px", border: "none", borderRadius: "4px", background: '#cc3380', color: "white" }}>Không</button>
              </div>
            </div>
          </div>
        )}
      </div>
    </div>
  );
}