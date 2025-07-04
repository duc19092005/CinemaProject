import React, { useState } from "react";

const thStyle = { padding: "8px", textAlign: "center" };
const tdStyle = { padding: "6px", textAlign: "center", border: "1px solid #ccc" };
const modalOverlayStyle = {
  position: "fixed", top:0, left:0, right:0, bottom:0,
  background: "rgba(0,0,0,0.5)", display: "flex", alignItems: "center", justifyContent: "center"
};
const modalContentStyle = {
  background: "#1a1143", color: "white", padding: "20px",
  borderRadius: "8px", minWidth: "300px"
};

export default function StaffManager() {
  const [staffList, setStaffList] = useState([
    { email:"test@email.com", password:"1234", name: "Nguyễn Văn A", phone: "123456789", dob: "01-01-2000", role: "Cashier" },
  ]);
  const [formData, setFormData] = useState({ email:"", password:"", name: "", phone: "", dob: "", role: "" });
  const [showConfirmModal, setShowConfirmModal] = useState(false);
  const [editingStaff, setEditingStaff] = useState(null);

  // Hàm thực sự lưu nhân viên mới
  const saveStaff = () => {
    if (!formData.name) return;
    setStaffList([...staffList, formData]);
    setFormData({ email:"", password:"", name: "", phone: "", dob: "", role: "" });
  };

  const handleDelete = (index) => {
    const newList = [...staffList];
    newList.splice(index, 1);
    setStaffList(newList);
  };

  const handleEdit = (index) => {
    setEditingStaff({ ...staffList[index], index });
  };

  const handleSaveEdit = () => {
    const newList = [...staffList];
    newList[editingStaff.index] = {
      email: editingStaff.email,
      password: editingStaff.password,
      name: editingStaff.name,
      phone: editingStaff.phone,
      dob: editingStaff.dob,
      role: editingStaff.role
    };
    setStaffList(newList);
    setEditingStaff(null);
  };

  return (
    <div style={{ backgroundColor: "#231C60", color: "white", minHeight: "100vh", padding: "16px", display:"flex", flexDirection:"column", alignItems:"center" }}>

      {/* Header */}
      <div style={{ width:"100%", maxWidth:"900px", display: "flex", justifyContent: "space-between", alignItems: "center", paddingBottom: "8px", borderBottom: "1px solid #555" }}>
        <div style={{ display: "flex", alignItems: "center" }}>
          <img src="/images/logo.png" alt="Logo" style={{ height: "40px", marginRight: "8px" }} />
          <span style={{ fontWeight: "bold", fontSize: "20px" }}>Cinema</span>
          <span style={{ color: "rgba(255,255,255,0.7)", marginLeft: "8px" }}>@Cnpm2025</span>
        </div>
        <span style={{ fontSize: "28px" }}>👤</span>
      </div>

      {/* Form thêm nhân viên */}
      <h3 style={{ marginTop: "24px" }}>Thêm nhân viên</h3>
      <div style={{
        display: "grid", gridTemplateColumns: "200px 1fr", gap: "8px",
        maxWidth: "600px", marginTop: "16px"
      }}>
        {[
          {label:"Email Đăng nhập", field:"email"},
          {label:"Mật khẩu", field:"password"},
          {label:"Ngày tháng năm sinh", field:"dob"},
          {label:"SĐT", field:"phone"},
          {label:"Tên nhân viên", field:"name"},
          {label:"Quyền hạn", field:"role"},
        ].map((item, idx) => (
          <React.Fragment key={idx}>
            <div style={{ backgroundColor: "#ddd", color: "#000", borderRadius: "4px", padding: "6px" }}>{item.label}</div>
            <input
              type={item.field==="password" ? "password":"text"}
              value={formData[item.field]}
              onChange={e => setFormData({...formData, [item.field]: e.target.value })}
              style={{ backgroundColor: "#7e57c2", color: "white", border: "none", borderRadius: "4px", padding: "6px" }}
            />
          </React.Fragment>
        ))}
      </div>

      {/* Nút lưu */}
      <div style={{ marginTop: "16px" }}>
        <button onClick={() => setShowConfirmModal(true)} style={{
          backgroundColor: "#add8e6", color: "black", padding: "8px 24px",
          border: "none", borderRadius: "8px"
        }}>Lưu</button>
      </div>

      {/* Danh sách */}
      <h3 style={{ marginTop: "24px" }}>Danh sách nhân viên</h3>
      <div style={{ maxWidth: "900px", width:"100%" }}>
        <table style={{ width: "100%", borderCollapse: "collapse" }}>
          <thead>
            <tr style={{ backgroundColor: "#4a80d6", color: "white" }}>
              <th style={thStyle}>STT</th>
              <th style={thStyle}>Tên nhân viên</th>
              <th style={thStyle}>SĐT</th>
              <th style={thStyle}>Ngày tháng năm sinh</th>
              <th style={thStyle}>Role</th>
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
                <td style={tdStyle}>
                  <button onClick={() => handleDelete(idx)} style={{ backgroundColor: "red", color: "white", border: "none", borderRadius: "4px", padding: "4px 8px" }}>Xóa</button>
                  <button onClick={() => handleEdit(idx)} style={{ backgroundColor: "#ccc", color: "black", border: "none", borderRadius: "4px", padding: "4px 8px", marginLeft: "4px" }}>Sửa</button>
                </td>
              </tr>
            ))}
          </tbody>
        </table>
      </div>

      {/* Modal xác nhận */}
      {showConfirmModal && (
        <div style={modalOverlayStyle}>
          <div style={{ background:"#4c65a8", padding:"24px", borderRadius:"8px", textAlign:"center", color:"white", width:"300px" }}>
            <div style={{ display:"flex", justifyContent:"center" }}>
                <img src="/images/warning.png" alt="!" style={{ width:"40px", marginBottom:"8px" }} />
            </div>
            <p>Bạn có chắc chắn muốn lưu nhân viên này?</p>
            <div style={{ display:"flex", justifyContent:"space-around", marginTop:"16px" }}>
              <button onClick={() => { saveStaff(); setShowConfirmModal(false); }}>Có</button>
              <button onClick={() => setShowConfirmModal(false)}>Không</button>
            </div>
          </div>
        </div>
      )}

      {/* Modal chỉnh sửa */}
      {editingStaff && (
        <div style={modalOverlayStyle}>
          <div style={modalContentStyle}>
            <h4>Chỉnh sửa nhân viên</h4>
            {[
              {label:"Email Đăng nhập", field:"email"},
              {label:"Mật khẩu (để trống nếu giữ nguyên)", field:"password"},
              {label:"Tên nhân viên", field:"name"},
              {label:"SĐT", field:"phone"},
              {label:"Ngày tháng năm sinh", field:"dob"},
              {label:"Quyền hạn", field:"role"},
            ].map((item, idx) => (
              <div key={idx} style={{ marginBottom: "8px" }}>
                <div>{item.label}</div>
                <input
                  type={item.field==="password" ? "password":"text"}
                  value={editingStaff[item.field]}
                  onChange={e => setEditingStaff({...editingStaff, [item.field]: e.target.value })}
                  style={{ width: "100%", padding: "6px", borderRadius: "4px", border: "none", background: "#7e57c2", color: "white" }}
                />
              </div>
            ))}
            <div style={{ textAlign:"center", marginTop:"12px" }}>
              <button onClick={handleSaveEdit} style={{ marginRight:"8px", padding:"6px 12px", border:"none", borderRadius:"4px", background:"lightgreen", color:"black" }}>Lưu</button>
              <button onClick={() => setEditingStaff(null)} style={{ padding:"6px 12px", border:"none", borderRadius:"4px", background:"grey", color:"white" }}>Hủy</button>
            </div>
          </div>
        </div>
      )}

    </div>
  );
}
