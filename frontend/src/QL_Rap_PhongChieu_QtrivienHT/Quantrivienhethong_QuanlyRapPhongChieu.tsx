import React, { useState } from "react";
import { useNavigate } from "react-router-dom";
import './style.css';

const thStyle: React.CSSProperties = { padding: "8px", textAlign: "center" };
const tdStyle: React.CSSProperties = { padding: "6px", textAlign: "center", border: "1px solid #ccc" };

export default function QuanLy() {
  const navigate = useNavigate();
  const [activeTab, setActiveTab] = useState<"rap" | "phong">("rap");
  const [showAccountMenu, setShowAccountMenu] = useState(false);
  const [showLogoutModal, setShowLogoutModal] = useState(false);
  const [editRapIndex, setEditRapIndex] = useState<number | null>(null);
  const [editSeatIndex, setEditSeatIndex] = useState<number | null>(null);

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

  const [gheList, setGheList] = useState<{ stt: number; ghe: string }[]>([
    { stt: 1, ghe: "A01" },
    { stt: 2, ghe: "A02" },
  ]);

  const [listRap, setListRap] = useState([
    { stt: 1, name: "Rạp 1", diachi: "123 Đường ABC", hotline: "0123456789" },
    { stt: 2, name: "Rạp 2", diachi: "456 Đường XYZ", hotline: "0987654321" },
  ]);

  const handleRapChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    const { name, value } = e.target;
    setRap({ ...rap, [name]: value });
  };

  const handlePhongChange = (e: React.ChangeEvent<HTMLInputElement | HTMLSelectElement>) => {
    const { name, value } = e.target;
    setPhong({ ...phong, [name]: value });

    // Generate gheList when slGhe changes
    if (name === "slGhe") {
      if (value) {
        const numSeats = parseInt(value, 10);
        const newGheList = Array.from({ length: numSeats }, (_, index) => ({
          stt: index + 1,
          ghe: `A${(index + 1).toString().padStart(1, '0')}`,
        }));
        setGheList(newGheList);
      } else {
        setGheList([]); // Clear gheList if slGhe is empty
      }
      setEditSeatIndex(null); // Clear edit state when slGhe changes
    }
  };

  const handleAdd = () => {
    if (activeTab === "rap") {
      if (rap.name && rap.diachi && rap.hotline) {
        if (editRapIndex !== null) {
          // Update existing cinema
          const updatedList = listRap.map((item, index) =>
            index === editRapIndex
              ? { ...item, name: rap.name, diachi: rap.diachi, hotline: rap.hotline }
              : item
          );
          setListRap(updatedList);
          alert(`Đã cập nhật rạp: ${JSON.stringify({ name: rap.name, diachi: rap.diachi, hotline: rap.hotline }, null, 2)}`);
          setEditRapIndex(null);
        } else {
          // Add new cinema
          const newRap = {
            stt: listRap.length + 1,
            name: rap.name,
            diachi: rap.diachi,
            hotline: rap.hotline,
          };
          setListRap([...listRap, newRap]);
          alert(`Đã thêm rạp: ${JSON.stringify(newRap, null, 2)}`);
          setActiveTab("phong"); // Switch to Phòng chiếu tab
        }
        setRap({ name: "", diachi: "", mota: "", hotline: "" });
      } else {
        alert("Vui lòng điền đầy đủ Tên rạp, Địa chỉ và Hotline!");
      }
    } else {
      alert(`Đã lưu phòng chiếu: ${JSON.stringify(phong, null, 2)}`);
    }
  };

  const handleDelete = (stt: number) => {
    setListRap(listRap.filter((item) => item.stt !== stt));
    setEditRapIndex(null); // Clear edit state if deleted
    alert(`Đã xóa rạp có STT: ${stt}`);
  };

  const handleEdit = (item: typeof listRap[0], index: number) => {
    setRap({
      name: item.name,
      diachi: item.diachi,
      mota: "",
      hotline: item.hotline,
    });
    setEditRapIndex(index);
    alert(`Đã chọn rạp để sửa: ${item.name}`);
  };

  const handleSeatDelete = (stt: number) => {
    const deletedSeat = gheList.find((item) => item.stt === stt);
    setGheList(gheList.filter((item) => item.stt !== stt));
    setEditSeatIndex(null); // Clear edit state if deleted
    alert(`Đã xóa ghế: ${JSON.stringify(deletedSeat, null, 2)}`);
  };

  const handleSeatEdit = (item: typeof gheList[0], index: number) => {
    // Since gheList is regenerated based on slGhe, set slGhe to current gheList length
    setPhong({ ...phong, slGhe: gheList.length.toString() });
    setEditSeatIndex(index);
    alert(`Đã chọn ghế để sửa: ${item.ghe}`);
  };

  return (
    <div style={{
      backgroundImage: "url('/images/bg.png')",
      backgroundSize: "cover",
      backgroundPosition: "center",
      backgroundRepeat: "no-repeat",
      backgroundAttachment: "fixed",
      color: "white",
      minHeight: "100vh",
      padding: "16px",
      display: "flex",
      flexDirection: "row",
      alignItems: "flex-start"
    }}>
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

      <div style={{ flex: 1, padding: "24px", marginLeft: "300px" }}>
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

        <div style={{ display: "flex", flexDirection: "column", alignItems: "center", width: "100%" }}>
          {activeTab === "rap" ? (
            <>
              <h4 style={{ marginTop: "16px" }}>Chỉnh sửa Rạp</h4>
              <div style={{ marginTop: "16px", maxWidth: "400px", display: "flex", flexDirection: "column", gap: "12px", width: "100%" }}>
                <div className="uiverse-pixel-input-wrapper">
                  <label className="uiverse-pixel-label">Tên rạp</label>
                  <input
                    name="name"
                    value={rap.name}
                    onChange={handleRapChange}
                    placeholder="Tên rạp"
                    className="uiverse-pixel-input"
                  />
                </div>
                <div className="uiverse-pixel-input-wrapper">
                  <label className="uiverse-pixel-label">Địa chỉ</label>
                  <input
                    name="diachi"
                    value={rap.diachi}
                    onChange={handleRapChange}
                    placeholder="Địa chỉ"
                    className="uiverse-pixel-input"
                  />
                </div>
                <div className="uiverse-pixel-input-wrapper">
                  <label className="uiverse-pixel-label">Miêu tả</label>
                  <input
                    name="mota"
                    value={rap.mota}
                    onChange={handleRapChange}
                    placeholder="Miêu tả"
                    className="uiverse-pixel-input"
                  />
                </div>
                <div className="uiverse-pixel-input-wrapper">
                  <label className="uiverse-pixel-label">Số hotline</label>
                  <input
                    name="hotline"
                    value={rap.hotline}
                    onChange={handleRapChange}
                    placeholder="Số hotline"
                    className="uiverse-pixel-input"
                  />
                </div>
              </div>
              <table className="revenue-table" style={{ width: "auto", marginTop: "20px" }}>
                <thead>
                  <tr>
                    <th style={thStyle}>STT</th>
                    <th style={thStyle}>Tên rạp</th>
                    <th style={thStyle}>Địa chỉ</th>
                    <th style={thStyle}>Hotline</th>
                    <th style={thStyle}>Tùy chỉnh</th>
                  </tr>
                </thead>
                <tbody>
                  {listRap.map((item, index) => (
                    <tr key={item.stt}>
                      <td style={tdStyle}>{item.stt}</td>
                      <td style={tdStyle}>{item.name}</td>
                      <td style={tdStyle}>{item.diachi}</td>
                      <td style={tdStyle}>{item.hotline}</td>
                      <td style={tdStyle}>
                        <button
                          onClick={() => handleDelete(item.stt)}
                          style={{ backgroundColor: '#cc3380', color: "white", border: "none", borderRadius: "4px", padding: "4px 8px", marginRight: "4px" }}
                        >
                          Xóa
                        </button>
                        <button
                          onClick={() => handleEdit(item, index)}
                          style={{ backgroundColor: "#ccc", color: "black", border: "none", borderRadius: "4px", padding: "4px 8px" }}
                        >
                          Sửa
                        </button>
                      </td>
                    </tr>
                  ))}
                </tbody>
              </table>
            </>
          ) : (
            <>
              <h4 style={{ marginTop: "16px" }}>Phòng chiếu</h4>
              <div style={{ marginTop: "16px", maxWidth: "500px", display: "flex", flexDirection: "column", gap: "16px", width: "100%" }}>
                <div className="uiverse-pixel-input-wrapper">
                  <label className="uiverse-pixel-label">Số phòng chiếu</label>
                  <select
                    name="soPhong"
                    value={phong.soPhong}
                    onChange={handlePhongChange}
                    className="uiverse-pixel-input"
                  >
                    <option value="">Chọn</option>
                    <option value="1">1</option>
                    <option value="2">2</option>
                  </select>
                </div>
                <div className="uiverse-pixel-input-wrapper">
                  <label className="uiverse-pixel-label">Rạp</label>
                  <select
                    name="rap"
                    value={phong.rap}
                    onChange={handlePhongChange}
                    className="uiverse-pixel-input"
                  >
                    <option value="">Chọn</option>
                    {listRap.map((item) => (
                      <option key={item.stt} value={item.name}>{item.name}</option>
                    ))}
                  </select>
                </div>
                <div className="uiverse-pixel-input-wrapper">
                  <label className="uiverse-pixel-label">Định dạng hình ảnh</label>
                  <select
                    name="dinhDang"
                    value={phong.dinhDang}
                    onChange={handlePhongChange}
                    className="uiverse-pixel-input"
                  >
                    <option value="">Chọn</option>
                    <option value="2D">2D</option>
                    <option value="3D">3D</option>
                  </select>
                </div>
                <div className="uiverse-pixel-input-wrapper">
                  <label className="uiverse-pixel-label">SL ghế</label>
                  <select
                    name="slGhe"
                    value={phong.slGhe}
                    onChange={handlePhongChange}
                    className="uiverse-pixel-input"
                  >
                    <option value="">Chọn</option>
                    <option value="50">50</option>
                    <option value="100">100</option>
                  </select>
                </div>
              </div>

              <table className="revenue-table" style={{ width: "auto", marginTop: "20px" }}>
                <thead>
                  <tr>
                    <th style={thStyle}>STT</th>
                    <th style={thStyle}>Tên ghế</th>
                    <th style={thStyle}>Tùy chỉnh</th>
                  </tr>
                </thead>
                <tbody>
                  {gheList.map((item, index) => (
                    <tr key={item.stt}>
                      <td style={tdStyle}>{item.stt}</td>
                      <td style={tdStyle}>{item.ghe}</td>
                      <td style={tdStyle}>
                        <button
                          onClick={() => handleSeatDelete(item.stt)}
                          style={{ backgroundColor: '#cc3380', color: "white", border: "none", borderRadius: "4px", padding: "4px 8px", marginRight: "4px" }}
                        >
                          Xóa
                        </button>
                        <button
                          onClick={() => handleSeatEdit(item, index)}
                          style={{ backgroundColor: "#ccc", color: "black", border: "none", borderRadius: "4px", padding: "4px 8px" }}
                        >
                          Sửa
                        </button>
                      </td>
                    </tr>
                  ))}
                </tbody>
              </table>
            </>
          )}

          <div style={{ marginTop: "16px" }}>
            <button onClick={handleAdd} style={{
              background: "#add8e6", color: "black", padding: "8px 24px",
              border: "none", borderRadius: "8px", cursor: "pointer"
            }}>
              {activeTab === "rap" ? "Thêm" : "Lưu"}
            </button>
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
                navigate("/");
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