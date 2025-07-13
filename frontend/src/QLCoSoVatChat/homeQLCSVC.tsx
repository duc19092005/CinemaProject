import React, { useState } from "react";

export default function QuanLy() {
  const [activeTab, setActiveTab] = useState<"rap" | "phong">("rap");

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
            fontWeight: "bold", cursor: "pointer"
          }}>
          📋 Rạp phim
        </button>
        <button
          onClick={() => setActiveTab("phong")}
          style={{
            background: activeTab === "phong" ? "#CAFF38" : "#CAFF38",
            color: "black", border: "none", borderRadius: "8px", padding: "12px",
            fontWeight: "bold", cursor: "pointer"
          }}>
          📋 Phòng chiếu
        </button>
      </div>

      {/* Main content */}
      <div style={{ flex: 1, padding: "24px" }}>
        <div style={{ display: "flex", justifyContent: "space-between" }}>
          <h3>Xin chào quản trị viên hệ thống</h3>
          <h4>Chỉnh sửa Phòng chiếu</h4>
          <span style={{ fontSize: "28px" }}>👤</span>
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
