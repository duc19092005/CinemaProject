import React, { useState } from "react";

export default function QuanLy() {
  const [activeTab, setActiveTab] = useState<"rap" | "phong">("rap");
  const [showAccountMenu, setShowAccountMenu] = useState(false);
  const [showLogoutModal, setShowLogoutModal] = useState(false);
  // State cho rạp
  const [rap, setRap] = useState({
    name: "",
    diachi: "",
    mota: "",
    hotline: "",
  });

  // State cho phòng chiếu
  const [phong, setPhong] = useState({
    soPhong: "",
    rap: "",
    dinhDang: "",
    slGhe: "",
  });

  // Danh sách ghế demo
  const [gheList] = useState([{ id: 1, ma: "A1" }]);

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
    <div style={{ display: "flex", height: "100vh", background: "#1a1143", color: "white", fontFamily: "sans-serif" }}>
      {/* Sidebar */}
      <div style={{
        width: "200px", background: "#1a1143", padding: "16px", display: "flex",
        flexDirection: "column", gap: "12px", borderRight: "2px solid white"
      }}>
        <button
  onClick={() => setActiveTab("rap")}
  style={{
    background: activeTab === "rap" ? "#CAFF38" : "#CAFF38",
    color: "black", border: "none", borderRadius: "8px", padding: "12px",
    fontWeight: "bold", cursor: "pointer", display: "flex", alignItems: "center", gap: "8px"
  }}>
  <span style={{ fontSize: "18px" }}>☰</span> Rạp phim
</button>

<button
  onClick={() => setActiveTab("phong")}
  style={{
    background: activeTab === "phong" ? "#CAFF38" : "#CAFF38",
    color: "black", border: "none", borderRadius: "8px", padding: "12px",
    fontWeight: "bold", cursor: "pointer", display: "flex", alignItems: "center", gap: "8px"
  }}>
  <span style={{ fontSize: "18px" }}>☰</span> Phòng chiếu
</button>

      </div>

      {/* Main content */}
      <div style={{ flex: 1, padding: "24px" }}>
        <div style={{ display: "flex", justifyContent: "space-between" }}>
          <h3>Xin chào quản trị viên hệ thống</h3>
          <div style={{ position: "relative" }}>
  <span style={{ fontSize: "28px", cursor: "pointer" }} onClick={() => setShowAccountMenu(!showAccountMenu)}>👤</span>
  {showAccountMenu && (
    <div style={{
      position: "absolute", right: 0, top: "36px",
      background: "#4c65a8", color: "white", borderRadius: "4px",
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

        {activeTab === "rap" ? (
          <>
            <h4 style={{ marginTop: "16px" }}>Chỉnh sửa Rạp</h4>
            <div style={{ marginTop: "16px", maxWidth: "400px", display: "flex", flexDirection: "column", gap: "12px" }}>
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
            <div style={{ marginTop: "16px", maxWidth: "500px", display: "flex", flexDirection: "column", gap: "12px" }}>
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
            <table style={{ marginTop: "16px", width: "100%", textAlign: "left" }}>
              <thead>
                <tr>
                  <th>STT</th>
                  <th>Mã số ghế</th>
                  <th></th>
                </tr>
              </thead>
              <tbody>
                {gheList.map((ghe) => (
                  <tr key={ghe.id}>
                    <td>{ghe.id}</td>
                    <td>{ghe.ma}</td>
                    <td>
                      <button style={{ background: "#CAFF38", color: "black", border: "none", borderRadius: "4px", padding: "4px 12px", marginRight: "4px" }}>
                        Xóa
                      </button>
                      <button style={{ background: "#add8e6", color: "black", border: "none", borderRadius: "4px", padding: "4px 12px" }}>
                        Sửa
                      </button>
                    </td>
                  </tr>
                ))}
              </tbody>
            </table>
          </>
        )}

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
        <button onClick={() => { alert("Đã đăng xuất"); setShowLogoutModal(false); }}
          style={{ padding: "6px 12px", border: "none", borderRadius: "4px", background: "#ccc", color: "black" }}>Có</button>
        <button onClick={() => setShowLogoutModal(false)}
          style={{ padding: "6px 12px", border: "none", borderRadius: "4px", background: "#ccc", color: "black" }}>Không</button>
      </div>
    </div>
  </div>
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
  );
}
