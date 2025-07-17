import React, { useState } from "react";
import { useNavigate } from "react-router-dom"; // Đảm bảo dòng này đã được import
import './style.css';

const thStyle: React.CSSProperties = { padding: "8px", textAlign: "center" };
const tdStyle: React.CSSProperties = { padding: "6px", textAlign: "center", border: "1px solid #ccc" };

export default function QuanLy() {
  const navigate = useNavigate(); // Khởi tạo hook useNavigate
  const [activeTab, setActiveTab] = useState<"rap" | "phong">("rap");
  const [showAccountMenu, setShowAccountMenu] = useState(false);
  const [showLogoutModal, setShowLogoutModal] = useState(false);

  // State for 'rạp' (cinema)
  const [rap, setRap] = useState({
    name: "",
    diachi: "",
    mota: "",
    hotline: "",
  });

  // State for 'phòng chiếu' (screening room)
  const [phong, setPhong] = useState({
    soPhong: "",
    rap: "",
    dinhDang: "",
    slGhe: "",
  });

  // Demo list of seats (gheList) - 'tongDoanhThu' removed
  const [gheList] = useState([
    { stt: 1, ngay: "20/11/2025" },
    { stt: 2, ngay: "19/11/2025" },
  ]);

  const handleRapChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    const { name, value } = e.target;
    setRap({ ...rap, [name]: value });
  };

  const handlePhongChange = (e: React.ChangeEvent<HTMLInputElement | HTMLSelectElement>) => {
    const { name, value } = e.target;
    setPhong({ ...phong, [name]: value });
  };

  const handleSave = () => {
    if (activeTab === "rap") {
      alert(`Đã lưu rạp: ${JSON.stringify(rap, null, 2)}`);
    } else {
      alert(`Đã lưu phòng chiếu: ${JSON.stringify(phong, null, 2)}`);
    }
  };

  return (
    <div style={{
      backgroundImage: "url('/images/bg.png')",
      backgroundSize: "cover",
      backgroundPosition: "center",
      backgroundRepeat: "no-repeat",
      color: "white",
      minHeight: "100vh",
      padding: "16px",
      display: "flex",
      flexDirection: "row",
      alignItems: "flex-start"
    }}>
      {/* Sidebar */}
      <div style={{
        width: "300px", background: "#231C60", padding: "16px", display: "flex",
        flexDirection: "column", gap: "12px", borderRight: "2px solid white",
        height: "100vh",
        position: "fixed",
        top: 0,
        left: 0,
      }}>
        <div style={{ display: "flex", alignItems: "center" }}>
          <img src="/images/logocinema1.png" alt="Logo" style={{ height: "40px", marginRight: "8px" }} />
        </div>
        <h3>Bạn muốn chỉnh sửa/ thêm gì</h3>
        <button onClick={() => setActiveTab("rap")} className="button2">
          <span style={{ fontSize: "18px", marginRight: "8px" }}>☰</span> Rạp
        </button>
        <button onClick={() => setActiveTab("phong")} className="button2">
          <span style={{ fontSize: "18px", marginRight: "8px" }}>☰</span> Phòng chiếu
        </button>
      </div>

      {/* Main content wrapper */}
      <div style={{ flex: 1, padding: "24px", marginLeft: "300px" }}>
        {/* Header section (Xin chào quản lý, logout) */}
        <div style={{ display: "flex", justifyContent: "space-between", marginBottom: "24px" }}>
          <h3>Xin chào Quản trị viên hệ thống</h3>
          <div style={{ position: "relative" }}>
            <span style={{ fontSize: "28px", cursor: "pointer" }} onClick={() => setShowAccountMenu(!showAccountMenu)}>👤</span>
            {showAccountMenu && (
              <div style={{
                position: "absolute", right: 0, top: "36px",
                background: "#231C60", color: "white", borderRadius: "4px",
                padding: "8px", minWidth: "100px", textAlign: "center"
              }}>
                <button onClick={() => { setShowLogoutModal(true); setShowAccountMenu(false); }}
                  style={{ background: "", border: "", color: "White", cursor: "pointer" }}>
                  Đăng xuất
                </button>
              </div>
            )}
          </div>
        </div>

        {/* Centered content section */}
        <div style={{ display: "flex", flexDirection: "column", alignItems: "center", width: "100%" }}>
          {activeTab === "rap" ? (
            <>
              <h4 style={{ marginTop: "16px" }}>Chỉnh sửa Rạp</h4>
              <div style={{ marginTop: "16px", maxWidth: "400px", display: "flex", flexDirection: "column", gap: "12px", width: "100%" }}>
                <input
                  name="name"
                  value={rap.name}
                  onChange={handleRapChange}
                  placeholder="Tên rạp"
                  style={{ background: "#7e57c2", color: "white", border: "none", borderRadius: "4px", padding: "8px" }}
                />
                <input
                  name="diachi"
                  value={rap.diachi}
                  onChange={handleRapChange}
                  placeholder="Địa chỉ"
                  style={{ background: "#7e57c2", color: "white", border: "none", borderRadius: "4px", padding: "8px" }}
                />
                <input
                  name="mota"
                  value={rap.mota}
                  onChange={handleRapChange}
                  placeholder="Miêu tả"
                  style={{ background: "#7e57c2", color: "white", border: "none", borderRadius: "4px", padding: "8px" }}
                />
                <input
                  name="hotline"
                  value={rap.hotline}
                  onChange={handleRapChange}
                  placeholder="Số hotline"
                  style={{ background: "#7e57c2", color: "white", border: "none", borderRadius: "4px", padding: "8px" }}
                />
              </div>
            </>
          ) : (
            <>
              <h4 style={{ marginTop: "16px" }}>Phòng chiếu</h4>
              <div style={{ marginTop: "16px", maxWidth: "500px", display: "flex", flexDirection: "column", gap: "12px", width: "100%" }}>
                <div>
                  Số phòng chiếu
                  <select
                    name="soPhong"
                    value={phong.soPhong}
                    onChange={handlePhongChange}
                    style={{ marginLeft: "8px", background: "#7e57c2", color: "white", border: "none", borderRadius: "4px", padding: "6px" }}
                  >
                    <option value="">Chọn</option>
                    <option value="1">1</option>
                    <option value="2">2</option>
                  </select>
                </div>
                <div>
                  Rạp
                  <select
                    name="rap"
                    value={phong.rap}
                    onChange={handlePhongChange}
                    style={{ marginLeft: "8px", background: "#7e57c2", color: "white", border: "none", borderRadius: "4px", padding: "6px" }}
                  >
                    <option value="">Chọn</option>
                    <option value="A01">A01</option>
                    <option value="A02">A02</option>
                  </select>
                </div>
                <div>
                  Định dạng hình ảnh
                  <input
                    name="dinhDang"
                    value={phong.dinhDang}
                    onChange={handlePhongChange}
                    style={{ display: "block", marginTop: "4px", background: "#7e57c2", color: "white", border: "none", borderRadius: "4px", padding: "8px" }}
                  />
                </div>
                <div>
                  SL ghế
                  <select
                    name="slGhe"
                    value={phong.slGhe}
                    onChange={handlePhongChange}
                    style={{ marginLeft: "8px", background: "#7e57c2", color: "white", border: "none", borderRadius: "4px", padding: "6px" }}
                  >
                    <option value="">Chọn</option>
                    <option value="50">50</option>
                    <option value="100">100</option>
                  </select>
                </div>
              </div>

              {/* Danh sách ghế */}
              <table className="revenue-table" style={{ width: "auto", marginTop: "20px" }}>
                <thead>
                  <tr>
                    <th style={thStyle}>STT</th>
                    <th style={thStyle}>Ngày</th>
                    <th style={thStyle}>Tùy chỉnh</th>
                  </tr>
                </thead>
                <tbody>
                  {gheList.map((item) => (
                    <tr key={item.stt}>
                      <td style={tdStyle}>{item.stt}</td>
                      <td style={tdStyle}>{item.ngay}</td>
                      <td style={tdStyle}>
                        <button style={{ backgroundColor: '#cc3380', color: "white", border: "none", borderRadius: "4px", padding: "4px 8px", marginRight: "4px" }}>Xóa</button>
                        <button style={{ backgroundColor: "#ccc", color: "black", border: "none", borderRadius: "4px", padding: "4px 8px" }}>Sửa</button>
                      </td>
                    </tr>
                  ))}
                </tbody>
              </table>
            </>
          )}

          {/* Nút Lưu */}
          <div style={{ marginTop: "16px" }}>
            <button onClick={handleSave} style={{
              background: "#add8e6", color: "black", padding: "8px 24px",
              border: "none", borderRadius: "8px", cursor: "pointer"
            }}>Lưu</button>
          </div>
        </div>
      </div>

      {showLogoutModal && (
        <div style={{
          position: "fixed", top: 0, left: 0, right: 0, bottom: 0,
          background: "rgba(0,0,0,0.5)", display: "flex",
          justifyContent: "center", alignItems: "center"
        }}>
          <div style={{
            background: "#4c65a8", padding: "24px", borderRadius: "8px",
            textAlign: "center", color: "white", width: "300px"
          }}>
            <div style={{ marginBottom: "8px" }}>
              <div style={{ display: "flex", justifyContent: "center", marginBottom: "8px" }}>
                <img src="/images/warning.png" alt="!" style={{ width: "40px" }} />
              </div>
            </div>
            <p>Bạn chắc chắn muốn đăng xuất không</p>
            <div style={{ display: "flex", justifyContent: "space-around", marginTop: "16px" }}>
              <button onClick={() => {
                alert("Đã đăng xuất");
                setShowLogoutModal(false);
                navigate("/"); // Thêm dòng này để điều hướng về trang chủ
              }}
                style={{ padding: "6px 12px", border: "none", borderRadius: "4px", background: "#ccc", color: "black" }}>Có</button>
              <button onClick={() => setShowLogoutModal(false)}
                style={{ padding: "6px 12px", border: "none", borderRadius: "4px", background: "#ccc", color: "black" }}>Không</button>
            </div>
          </div>
        </div>
      )}
    </div>
  );
}