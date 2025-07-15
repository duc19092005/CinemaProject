import React, { useState } from "react";
import './style.css';

interface Staff {
  email: string;
  password?: string;
  name: string;
  phone: string;
  dob: string;
  role: "Cashier";
  rạp: string;
}

interface FormData extends Omit<Staff, 'password'> {
  password: string;
  password2: string;
}

interface EditingStaff extends Omit<Staff, 'email' | 'password'> {
  index: number;
}

const thStyle: React.CSSProperties = { padding: "8px", textAlign: "center" };
const tdStyle: React.CSSProperties = { padding: "6px", textAlign: "center", border: "1px solid #ccc" };
const modalOverlayStyle: React.CSSProperties = {
  position: "fixed", top: 0, left: 0, right: 0, bottom: 0,
  background: "rgba(0,0,0,0.5)", display: "flex", alignItems: "center", justifyContent: "center"
};
const modalContentStyle: React.CSSProperties = {
  background: "#1a1143", color: "white", padding: "20px",
  borderRadius: "8px", minWidth: "300px"
};

export default function QuanLy() {
  const [activeTab, setActiveTab] = useState<"nhanvien" | "rap" | "phong">("nhanvien");
  const [showAccountMenu, setShowAccountMenu] = useState(false);
  const [showLogoutModal, setShowLogoutModal] = useState(false);

  // State for staff management
  const [staffList, setStaffList] = useState<Staff[]>([
    { email: "test@email.com", password: "1234", name: "Nguyễn Văn A", phone: "123456789", dob: "01-01-2000", role: "Cashier", rạp: "A01" },
  ]);

  const [formData, setFormData] = useState<FormData>({
    email: "",
    password: "",
    password2: "",
    name: "",
    phone: "",
    dob: "",
    role: "Cashier",
    rạp: "A01",
  });

  const [showConfirmModal, setShowConfirmModal] = useState<boolean>(false);
  const [editingStaff, setEditingStaff] = useState<EditingStaff | null>(null);

  // State for rạp
  const [rap, setRap] = useState({
    name: "",
    diachi: "",
    mota: "",
    hotline: "",
  });

  // State for phòng chiếu
  const [phong, setPhong] = useState({
    soPhong: "",
    rap: "",
    dinhDang: "",
    slGhe: "",
  });

  // Staff management functions
  const saveStaff = (): void => {
    if (!formData.name) {
      alert("Tên nhân viên không được để trống.");
      return;
    }
    if (formData.password !== formData.password2) {
      alert("Mật khẩu và xác nhận mật khẩu không khớp.");
      return;
    }

    const newStaff: Staff = {
      email: formData.email,
      password: formData.password,
      name: formData.name,
      phone: formData.phone,
      dob: formData.dob,
      role: formData.role,
      rạp: formData.rạp,
    };

    setStaffList([...staffList, newStaff]);
    setFormData({ email: "", password: "", password2: "", name: "", phone: "", dob: "", role: "Cashier", rạp: "A01" });
    setShowConfirmModal(false);
  };

  const handleDelete = (index: number): void => {
    const newList = [...staffList];
    newList.splice(index, 1);
    setStaffList(newList);
  };

  const handleEdit = (index: number): void => {
    const { name, phone, dob, role, rạp } = staffList[index];
    setEditingStaff({ name, phone, dob, role, rạp, index });
  };

  const handleSaveEdit = (): void => {
    if (editingStaff === null) return;

    const newList = [...staffList];
    newList[editingStaff.index] = {
      ...newList[editingStaff.index],
      name: editingStaff.name,
      phone: editingStaff.phone,
      dob: editingStaff.dob,
      role: editingStaff.role,
      rạp: editingStaff.rạp,
    };
    setStaffList(newList);
    setEditingStaff(null);
  };

  const handleInputChange = (e: React.ChangeEvent<HTMLInputElement | HTMLSelectElement>, field: keyof FormData): void => {
    setFormData({ ...formData, [field]: e.target.value });
  };

  const handleEditInputChange = (e: React.ChangeEvent<HTMLInputElement | HTMLSelectElement>, field: keyof Omit<EditingStaff, 'index'>): void => {
    if (editingStaff) {
      setEditingStaff({ ...editingStaff, [field]: e.target.value });
    }
  };

  // Rạp and Phòng functions
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
    } else if (activeTab === "phong") {
      alert(`Đã lưu phòng chiếu: ${JSON.stringify(phong, null, 2)}`);
    } else {
      setShowConfirmModal(true);
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
        <button onClick={() => setActiveTab("nhanvien")} className="button2">
          <span style={{ fontSize: "18px", marginRight: "8px" }}>☰</span> Nhân viên
        </button>
        <button onClick={() => setActiveTab("rap")} className="button2">
          <span style={{ fontSize: "18px", marginRight: "8px" }}>☰</span> Rạp phim
        </button>
        <button onClick={() => setActiveTab("phong")} className="button2">
          <span style={{ fontSize: "18px", marginRight: "8px" }}>☰</span> Phòng chiếu
        </button>
      </div>

      {/* Main content */}
      <div style={{ flex: 1, padding: "24px" }}>
        <div style={{ display: "flex", justifyContent: "space-between" }}>
          <h3>Xin chào quản lý</h3>
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

        {/* Nội dung */}
        {activeTab === "nhanvien" && (
          <div style={{
            display: "flex",
            flexDirection: "column",
            alignItems: "center"
          }}>
            <h3 style={{ marginTop: "24px" }}>Thêm nhân viên</h3>
            <div style={{
              display: "grid", gridTemplateColumns: "200px 1fr", gap: "8px",
              maxWidth: "600px", marginTop: "16px"
            }}>
              <div style={{ backgroundColor: "#ddd", color: "#000", borderRadius: "4px", padding: "6px" }}>Rạp</div>
              <select
                value={formData.rạp}
                onChange={(e) => handleInputChange(e, 'rạp')}
                style={{ backgroundColor: "#7e57c2", color: "white", border: "none", borderRadius: "4px", padding: "6px" }}
              >
                <option value="A01">A01</option>
                <option value="A02">A02</option>
                <option value="A03">A03</option>
                <option value="A04">A04</option>
              </select>
              <div style={{ backgroundColor: "#ddd", color: "#000", borderRadius: "4px", padding: "6px" }}>Email Đăng nhập</div>
              <input
                type="text"
                value={formData.email}
                onChange={(e) => handleInputChange(e, 'email')}
                style={{ backgroundColor: "#7e57c2", color: "white", border: "none", borderRadius: "4px", padding: "6px" }}
              />
              <div style={{ backgroundColor: "#ddd", color: "#000", borderRadius: "4px", padding: "6px" }}>Mật khẩu</div>
              <input
                type="password"
                value={formData.password}
                onChange={(e) => handleInputChange(e, 'password')}
                style={{ backgroundColor: "#7e57c2", color: "white", border: "none", borderRadius: "4px", padding: "6px" }}
              />
              <div style={{ backgroundColor: "#ddd", color: "#000", borderRadius: "4px", padding: "6px" }}>Xác nhận mật khẩu</div>
              <input
                type="password"
                value={formData.password2}
                onChange={(e) => handleInputChange(e, 'password2')}
                style={{ backgroundColor: "#7e57c2", color: "white", border: "none", borderRadius: "4px", padding: "6px" }}
              />
              <div style={{ backgroundColor: "#ddd", color: "#000", borderRadius: "4px", padding: "6px" }}>Ngày tháng năm sinh</div>
              <input
                type="text"
                value={formData.dob}
                onChange={(e) => handleInputChange(e, 'dob')}
                style={{ backgroundColor: "#7e57c2", color: "white", border: "none", borderRadius: "4px", padding: "6px" }}
              />
              <div style={{ backgroundColor: "#ddd", color: "#000", borderRadius: "4px", padding: "6px" }}>SĐT</div>
              <input
                type="text"
                value={formData.phone}
                onChange={(e) => handleInputChange(e, 'phone')}
                style={{ backgroundColor: "#7e57c2", color: "white", border: "none", borderRadius: "4px", padding: "6px" }}
              />
              <div style={{ backgroundColor: "#ddd", color: "#000", borderRadius: "4px", padding: "6px" }}>Tên nhân viên</div>
              <input
                type="text"
                value={formData.name}
                onChange={(e) => handleInputChange(e, 'name')}
                style={{ backgroundColor: "#7e57c2", color: "white", border: "none", borderRadius: "4px", padding: "6px" }}
              />
              <div style={{ backgroundColor: "#ddd", color: "#000", borderRadius: "4px", padding: "6px" }}>Quyền hạn</div>
              <select
                value={formData.role}
                onChange={(e) => handleInputChange(e, 'role')}
                style={{ backgroundColor: "#7e57c2", color: "white", border: "none", borderRadius: "4px", padding: "6px" }}
              >
                <option value="Cashier">Cashier</option>
              </select>
            </div>
            <div style={{ marginTop: "16px" }}>
              <button onClick={handleSave} style={{
                backgroundColor: "#add8e6", color: "black", padding: "8px 24px",
                border: "none", borderRadius: "8px"
              }}>Lưu</button>
            </div>
            <h3 style={{ marginTop: "24px" }}>Danh sách nhân viên</h3>
            <div style={{ maxWidth: "900px", width: "100%" }}>
              <table style={{ width: "100%", borderCollapse: "collapse" }}>
                <thead>
                  <tr style={{ backgroundColor: "#4a80d6", color: "white" }}>
                    <th style={thStyle}>STT</th>
                    <th style={thStyle}>Tên nhân viên</th>
                    <th style={thStyle}>SĐT</th>
                    <th style={thStyle}>Ngày tháng năm sinh</th>
                    <th style={thStyle}>Role</th>
                    <th style={thStyle}>Rạp</th>
                    <th style={thStyle}>Tùy chỉnh</th>
                  </tr>
                </thead>
                <tbody>
                  {staffList.map((staff, idx) => (
                    <tr key={idx} style={{ backgroundColor: "white", color: "black" }}>
                      <td style={tdStyle}>{idx + 1}</td>
                      <td style={tdStyle}>{staff.name}</td>
                      <td style={tdStyle}>{staff.phone}</td>
                      <td style={tdStyle}>{staff.dob}</td>
                      <td style={tdStyle}>{staff.role}</td>
                      <td style={tdStyle}>{staff.rạp}</td>
                      <td style={tdStyle}>
                        <button onClick={() => handleDelete(idx)} style={{ backgroundColor: '#cc3380', color: "white", border: "none", borderRadius: "4px", padding: "4px 8px" }}>Xóa</button>
                        <button onClick={() => handleEdit(idx)} style={{ backgroundColor: "#ccc", color: "black", border: "none", borderRadius: "4px", padding: "4px 8px", marginLeft: "4px" }}>Sửa</button>
                      </td>
                    </tr>
                  ))}
                </tbody>
              </table>
            </div>
            {showConfirmModal && (
              <div style={modalOverlayStyle}>
                <div style={{ background: "#4c65a8", padding: "24px", borderRadius: "8px", textAlign: "center", color: "white", width: "300px" }}>
                  <div style={{ display: "flex", justifyContent: "center" }}>
                    <img src="/images/warning.png" alt="!" style={{ width: "40px", marginBottom: "8px" }} />
                  </div>
                  <p>Bạn có chắc chắn muốn lưu nhân viên này?</p>
                  <div style={{ display: "flex", justifyContent: "space-around", marginTop: "16px" }}>
                    <button onClick={saveStaff} style={{ padding: "6px 12px", border: "none", borderRadius: "4px", background: "lightgreen", color: "black" }}>Có</button>
                    <button onClick={() => setShowConfirmModal(false)} style={{ padding: "6px 12px", border: "none", borderRadius: "4px", background: '#cc3380', color: "white" }}>Không</button>
                  </div>
                </div>
              </div>
            )}
            {editingStaff && (
              <div style={modalOverlayStyle}>
                <div style={modalContentStyle}>
                  <h4>Chỉnh sửa nhân viên</h4>
                  {[
                    { label: "Rạp", field: "rạp" },
                    { label: "Tên nhân viên", field: "name" },
                    { label: "SĐT", field: "phone" },
                    { label: "Ngày tháng năm sinh", field: "dob" },
                    { label: "Quyền hạn", field: "role" },
                  ].map((item, idx) => (
                    <div key={idx} style={{ marginBottom: "8px" }}>
                      <div>{item.label}</div>
                      {item.field === "role" ? (
                        <select
                          value={editingStaff.role}
                          onChange={(e) => handleEditInputChange(e, 'role')}
                          style={{ width: "100%", padding: "6px", borderRadius: "4px", border: "none", background: "#7e57c2", color: "white" }}
                        >
                          <option value="Cashier">Cashier</option>
                        </select>
                      ) : item.field === "rạp" ? (
                        <select
                          value={editingStaff.rạp}
                          onChange={(e) => handleEditInputChange(e, 'rạp')}
                          style={{ width: "100%", padding: "6px", borderRadius: "4px", border: "none", background: "#7e57c2", color: "white" }}
                        >
                          <option value="A01">A01</option>
                          <option value="A02">A02</option>
                          <option value="A03">A03</option>
                          <option value="A04">A04</option>
                        </select>
                      ) : (
                        <input
                          type="text"
                          value={editingStaff[item.field as keyof Omit<EditingStaff, 'index'>]}
                          onChange={(e) => handleEditInputChange(e, item.field as keyof Omit<EditingStaff, 'index'>)}
                          style={{ width: "100%", padding: "6px", borderRadius: "4px", border: "none", background: "#7e57c2", color: "white" }}
                        />
                      )}
                    </div>
                  ))}
                  <div style={{ textAlign: "center", marginTop: "12px" }}>
                    <button onClick={handleSaveEdit} style={{ marginRight: "8px", padding: "6px 12px", border: "none", borderRadius: "4px", background: "lightgreen", color: "black" }}>Lưu</button>
                    <button onClick={() => setEditingStaff(null)} style={{ padding: "6px 12px", border: "none", borderRadius: "4px", background: '#cc3380', color: "white" }}>Hủy</button>
                  </div>
                </div>
              </div>
            )}
          </div>
        )}

        {activeTab === "rap" && (
          <div style={{
            display: "flex",
            flexDirection: "column",
            alignItems: "center"
          }}>
            <h3 style={{ marginTop: "24px" }}>Chỉnh sửa Rạp</h3>
            <div style={{ marginTop: "16px", maxWidth: "600px", display: "grid", gridTemplateColumns: "200px 1fr", gap: "8px" }}>
              <div style={{ backgroundColor: "#ddd", color: "#000", borderRadius: "4px", padding: "6px" }}>Tên rạp</div>
              <input
                name="name"
                value={rap.name}
                onChange={handleRapChange}
                placeholder="Tên rạp"
                style={{ background: "#7e57c2", color: "white", border: "none", borderRadius: "4px", padding: "6px" }}
              />
              <div style={{ backgroundColor: "#ddd", color: "#000", borderRadius: "4px", padding: "6px" }}>Địa chỉ</div>
              <input
                name="diachi"
                value={rap.diachi}
                onChange={handleRapChange}
                placeholder="Địa chỉ"
                style={{ background: "#7e57c2", color: "white", border: "none", borderRadius: "4px", padding: "6px" }}
              />
              <div style={{ backgroundColor: "#ddd", color: "#000", borderRadius: "4px", padding: "6px" }}>Miêu tả</div>
              <input
                name="mota"
                value={rap.mota}
                onChange={handleRapChange}
                placeholder="Miêu tả"
                style={{ background: "#7e57c2", color: "white", border: "none", borderRadius: "4px", padding: "6px" }}
              />
              <div style={{ backgroundColor: "#ddd", color: "#000", borderRadius: "4px", padding: "6px" }}>Số hotline</div>
              <input
                name="hotline"
                value={rap.hotline}
                onChange={handleRapChange}
                placeholder="Số hotline"
                style={{ background: "#7e57c2", color: "white", border: "none", borderRadius: "4px", padding: "6px" }}
              />
            </div>
            <div style={{ marginTop: "16px" }}>
              <button onClick={handleSave} style={{
                backgroundColor: "#add8e6", color: "black", padding: "8px 24px",
                border: "none", borderRadius: "8px"
              }}>Lưu</button>
            </div>
          </div>
        )}

        {activeTab === "phong" && (
          <div style={{
            display: "flex",
            flexDirection: "column",
            alignItems: "center"
          }}>
            <h3 style={{ marginTop: "24px" }}>Phòng chiếu</h3>
            <div style={{ marginTop: "16px", maxWidth: "600px", display: "grid", gridTemplateColumns: "200px 1fr", gap: "8px" }}>
              <div style={{ backgroundColor: "#ddd", color: "#000", borderRadius: "4px", padding: "6px" }}>Số phòng chiếu</div>
              <select
                name="soPhong"
                value={phong.soPhong}
                onChange={handlePhongChange}
                style={{ background: "#7e57c2", color: "white", border: "none", borderRadius: "4px", padding: "6px" }}
              >
                <option value="">Chọn</option>
                <option value="1">1</option>
                <option value="2">2</option>
              </select>
              <div style={{ backgroundColor: "#ddd", color: "#000", borderRadius: "4px", padding: "6px" }}>Rạp</div>
              <select
                name="rap"
                value={phong.rap}
                onChange={handlePhongChange}
                style={{ background: "#7e57c2", color: "white", border: "none", borderRadius: "4px", padding: "6px" }}
              >
                <option value="">Chọn</option>
                <option value="A01">A01</option>
                <option value="A02">A02</option>
              </select>
              <div style={{ backgroundColor: "#ddd", color: "#000", borderRadius: "4px", padding: "6px" }}>Định dạng hình ảnh</div>
              <input
                name="dinhDang"
                value={phong.dinhDang}
                onChange={handlePhongChange}
                style={{ background: "#7e57c2", color: "white", border: "none", borderRadius: "4px", padding: "6px" }}
              />
              <div style={{ backgroundColor: "#ddd", color: "#000", borderRadius: "4px", padding: "6px" }}>SL ghế</div>
              <select
                name="slGhe"
                value={phong.slGhe}
                onChange={handlePhongChange}
                style={{ background: "#7e57c2", color: "white", border: "none", borderRadius: "4px", padding: "6px" }}
              >
                <option value="">Chọn</option>
                <option value="50">50</option>
                <option value="100">100</option>
              </select>
            </div>
            <div style={{ marginTop: "16px" }}>
              <button onClick={handleSave} style={{
                backgroundColor: "#add8e6", color: "black", padding: "8px 24px",
                border: "none", borderRadius: "8px"
              }}>Lưu</button>
            </div>
          </div>
        )}

        {showLogoutModal && (
          <div style={{
            position: "fixed", top: 0, left: 0, right: 0, bottom: 0,
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