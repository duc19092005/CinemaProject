import React, { useState } from "react";

export default function QuanLy() {
  const [activeTab, setActiveTab] = useState<"rap" | "phong">("rap");
  const [showAccountMenu, setShowAccountMenu] = useState(false);
  const [showLogoutModal, setShowLogoutModal] = useState(false);

  const [rap, setRap] = useState({
    name: "",
    diachi: "",
    mota: "",
    hotline: "",
  });

  const [phong, setPhong] = useState({
    soPhong: "",
    rap: "",
    dinhDang: "",
    slGhe: "",
  });

  const [gheList] = useState([{ id: 1, ma: "A1" }]);

  // Xử lý thay đổi input của rạp
  const handleRapChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    const { name, value } = e.target;
    setRap({ ...rap, [name]: value });
  };

  // Xử lý thay đổi input của phòng
  const handlePhongChange = (e: React.ChangeEvent<HTMLInputElement | HTMLSelectElement>) => {
    const { name, value } = e.target;
    setPhong({ ...phong, [name]: value });
  };

  // Lưu dữ liệu
  const handleSave = () => {
    if (activeTab === "rap") {
      alert(`Đã lưu rạp: ${JSON.stringify(rap, null, 2)}`);
      setRap({ name: "", diachi: "", mota: "", hotline: "" });
    } else {
      alert(`Đã lưu phòng chiếu: ${JSON.stringify(phong, null, 2)}`);
      setPhong({ soPhong: "", rap: "", dinhDang: "", slGhe: "" });
    }
  };

  return (
    <div style={{ display: "flex", minHeight: "100vh", background: "#231C60", color: "white" }}>
      {/* Sidebar */}
      <div style={{ width: "200px", padding: "16px" }}>
        <div style={{ fontWeight: "bold", marginBottom: "16px" }}>Tôi muốn chỉnh sửa</div>
        <button
          onClick={() => setActiveTab("rap")}
          style={{
            background: activeTab === "rap" ? "#CAFF38" : "#CAFF38",
            color: "black", border: "none", borderRadius: "8px",
            padding: "12px", fontWeight: "bold", cursor: "pointer",
            display: "flex", alignItems: "center", gap: "8px", marginBottom: "8px"
          }}>
          <span style={{ fontSize: "18px" }}>☰</span> Rạp phim
        </button>
        <button
          onClick={() => setActiveTab("phong")}
          style={{
            background: activeTab === "phong" ? "#CAFF38" : "#CAFF38",
            color: "black", border: "none", borderRadius: "8px",
            padding: "12px", fontWeight: "bold", cursor: "pointer",
            display: "flex", alignItems: "center", gap: "8px"
          }}>
          <span style={{ fontSize: "18px" }}>☰</span> Phòng chiếu
        </button>
      </div>

      {/* Đường kẻ trắng phân cách */}
      <div style={{ width: "1px", background: "white", opacity: 0.3 }} />

      {/* Main content */}
      <div style={{ flex: 1, padding: "16px" }}>
        {/* Header */}
        <div style={{
          display: "flex", justifyContent: "space-between", alignItems: "center",
          paddingBottom: "8px", borderBottom: "1px solid #555"
        }}>
          <div style={{ fontWeight: "bold" }}>Xin chào quản trị viên hệ thống</div>
          <div style={{ position: "relative" }}>
            <span style={{ fontSize: "28px", cursor: "pointer" }}
              onClick={() => setShowAccountMenu(!showAccountMenu)}>👤</span>
            {showAccountMenu && (
              <div style={{
                position: "absolute", right: 0, top: "36px",
                background: "#4c65a8", color: "white", borderRadius: "4px",
                padding: "8px", minWidth: "100px", textAlign: "center"
              }}>
                <button
                  onClick={() => { setShowLogoutModal(true); setShowAccountMenu(false); }}
                  style={{ background: "none", border: "none", color: "white", cursor: "pointer" }}>
                  Đăng xuất
                </button>
              </div>
            )}
          </div>
        </div>

        {/* Form chỉnh sửa */}
        {activeTab === "rap" && (
          <div style={{ marginTop: "24px", maxWidth: "400px" }}>
            <h3>Chỉnh sửa Rạp</h3>
            {["name", "diachi", "mota", "hotline"].map((field) => (
              <div key={field} style={{ marginBottom: "12px" }}>
                <div>{field === "name" ? "Tên rạp" : field === "diachi" ? "Địa chỉ" : field === "mota" ? "Miêu tả" : "Số hotline"}</div>
                <input
                  type="text"
                  name={field}
                  value={rap[field as keyof typeof rap]}
                  onChange={handleRapChange}
                  style={{
                    width: "100%", padding: "6px", borderRadius: "4px",
                    border: "none", background: "#7e57c2", color: "white"
                  }}
                />
              </div>
            ))}
            <button onClick={handleSave} style={{
              backgroundColor: "#add8e6", color: "black", padding: "8px 24px",
              border: "none", borderRadius: "8px", cursor: "pointer"
            }}>Lưu</button>
          </div>
        )}

        {activeTab === "phong" && (
          <div style={{ marginTop: "24px", maxWidth: "400px" }}>
            <h3>Chỉnh sửa Phòng chiếu</h3>
            <div style={{ marginBottom: "12px" }}>
              <div>Số phòng</div>
              <input
                type="text" name="soPhong"
                value={phong.soPhong}
                onChange={handlePhongChange}
                style={{ width: "100%", padding: "6px", borderRadius: "4px",
                  border: "none", background: "#7e57c2", color: "white" }}
              />
            </div>
            <div style={{ marginBottom: "12px" }}>
              <div>Rạp</div>
              <input
                type="text" name="rap"
                value={phong.rap}
                onChange={handlePhongChange}
                style={{ width: "100%", padding: "6px", borderRadius: "4px",
                  border: "none", background: "#7e57c2", color: "white" }}
              />
            </div>
            <div style={{ marginBottom: "12px" }}>
              <div>Định dạng hình ảnh</div>
              <input
                type="text" name="dinhDang"
                value={phong.dinhDang}
                onChange={handlePhongChange}
                style={{ width: "100%", padding: "6px", borderRadius: "4px",
                  border: "none", background: "#7e57c2", color: "white" }}
              />
            </div>
            <div style={{ marginBottom: "12px" }}>
              <div>Số lượng ghế</div>
              <input
                type="text" name="slGhe"
                value={phong.slGhe}
                onChange={handlePhongChange}
                style={{ width: "100%", padding: "6px", borderRadius: "4px",
                  border: "none", background: "#7e57c2", color: "white" }}
              />
            </div>
            <button onClick={handleSave} style={{
              backgroundColor: "#add8e6", color: "black", padding: "8px 24px",
              border: "none", borderRadius: "8px", cursor: "pointer"
            }}>Lưu</button>
          </div>
        )}
      </div>

      {/* Modal cảnh báo đăng xuất */}
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
              <button
                onClick={() => {
                  alert("Đã đăng xuất!");
                  setShowLogoutModal(false);
                }}
                style={{ padding: "6px 12px", border: "none", borderRadius: "4px", background: "#ccc", color: "black" }}>
                Có
              </button>
              <button
                onClick={() => setShowLogoutModal(false)}
                style={{ padding: "6px 12px", border: "none", borderRadius: "4px", background: "#ccc", color: "black" }}>
                Không
              </button>
            </div>
          </div>
        </div>
      )}
    </div>
  );
}
