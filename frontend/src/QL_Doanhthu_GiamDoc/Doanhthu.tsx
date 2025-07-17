import React, { useState, useEffect } from "react";
import './style.css';
import { Chart as ChartJS, ArcElement, Tooltip, Legend } from 'chart.js';
import { Doughnut } from 'react-chartjs-2';
import { useNavigate } from 'react-router-dom'; 


ChartJS.register(ArcElement, Tooltip, Legend);

interface Revenue {
  stt: number;
  ngay: string; 
  tongDoanhThu: string;
}

const thStyle: React.CSSProperties = { padding: "8px", textAlign: "center" };
const tdStyle: React.CSSProperties = { padding: "6px", textAlign: "center", border: "1px solid #ccc" };
const modalOverlayStyle: React.CSSProperties = {
  position: "fixed", top: 0, left: 0, right: 0, bottom: 0,
  background: "rgba(0,0,0,0.5)", display: "flex", alignItems: "center", justifyContent: "center", zIndex: 1000
};


const MonthlyRevenueChart: React.FC<{ currentRevenue: number; onClose: () => void }> = ({ currentRevenue, onClose }) => {
  const targetRevenue = 100000000; 
  const remaining = Math.max(0, targetRevenue - currentRevenue); 
  const achievedPercentage = (targetRevenue > 0) ? (currentRevenue / targetRevenue) * 100 : 0; 

  const data = {
    labels: [`Doanh thu đã đạt (${achievedPercentage.toFixed(1)}%)`, 'Còn lại để đạt mục tiêu'],
    datasets: [
      {
        data: [currentRevenue, remaining],
        backgroundColor: ['#000000', '#CAFF38'], 
        borderColor: ['#fff', '#fff'],
        borderWidth: 1,
      },
    ],
  };

  const options = {
    responsive: true,
    plugins: {
      legend: {
        position: 'top' as const,
        labels: {
          color: 'white', 
        }
      },
      tooltip: {
        callbacks: {
          label: function(context: any) {
            let label = context.label || '';
            if (label) {
              label += ': ';
            }
            if (context.parsed !== null) {
              label += new Intl.NumberFormat('vi-VN', { style: 'currency', currency: 'VND' }).format(context.parsed);
            }
            return label;
          }
        }
      }
    },
    cutout: '70%', 
  };

  return (
    <div style={{
      background: "#231C60", padding: "24px", borderRadius: "8px",
      textAlign: "center", color: "white", width: "400px", maxWidth: "90%",
      position: "relative",
    }}>
      <button
        onClick={onClose}
        style={{
          position: "absolute", top: "10px", right: "10px",
          background: "none", border: "none", color: "white",
          fontSize: "20px", cursor: "pointer",
        }}
      >
        &times;
      </button>
      <h4>Biểu đồ Doanh thu so với Mục tiêu</h4>
      <div style={{ width: '100%', height: 'auto', display: 'flex', justifyContent: 'center', alignItems: 'center' }}>
        <Doughnut data={data} options={options} />
      </div>
      <p style={{ marginTop: "15px", fontSize: "1.1em" }}>
        Tổng doanh thu: {new Intl.NumberFormat('vi-VN', { style: 'currency', currency: 'VND' }).format(currentRevenue)}
      </p>
      <p style={{ fontSize: "1.1em" }}>
        Mục tiêu: {new Intl.NumberFormat('vi-VN', { style: 'currency', currency: 'VND' }).format(targetRevenue)}
      </p>
    </div>
  );
};


export default function QuanLy() {
  const [showAccountMenu, setShowAccountMenu] = useState(false);
  const [showLogoutModal, setShowLogoutModal] = useState(false);
  const [isLoading, setIsLoading] = useState(true);
  const [showRevenueChartModal, setShowRevenueChartModal] = useState(false);
   const navigate = useNavigate();

  const [revenueList] = useState<Revenue[]>([
    { stt: 1, ngay: "20/11/2025", tongDoanhThu: "VND 20.000" },
    { stt: 2, ngay: "19/11/2025", tongDoanhThu: "VND 120.000" },
    { stt: 3, ngay: "19/11/2025", tongDoanhThu: "VND 5.000.000" },
    { stt: 4, ngay: "20/11/2025", tongDoanhThu: "VND 70.000" },
    { stt: 5, ngay: "01/10/2025", tongDoanhThu: "VND 10.000" },
    { stt: 6, ngay: "15/10/2025", tongDoanhThu: "VND 30.000.000" },
    { stt: 7, ngay: "05/12/2025", tongDoanhThu: "VND 2.000.000" },
  ]);
  const [selectedRap, setSelectedRap] = useState("Chọn");
  const [filterDate, setFilterDate] = useState("");

  const formatDateForComparison = (dateStr: string): string => {
    if (!dateStr) return "";
    const [year, month, day] = dateStr.split("-");
    return `${day}/${month}/${year}`;
  };

  const getMonthYearFromDDMMYYYY = (dateStr: string): string => {
    if (!dateStr) return "";
    const parts = dateStr.split('/');
    return `${parts[1]}/${parts[2]}`; 
  };

  const getMonthYearFromYYYYMMDD = (dateStr: string): string => {
    if (!dateStr) return "";
    const parts = dateStr.split('-');
    return `${parts[1]}/${parts[0]}`; 
  };

  const parseCurrencyToNumber = (currencyStr: string): number => {
    return parseFloat(currencyStr.replace("VND ", "").replace(/\./g, "").replace(",", "."));
  };


  
  const totalRevenueForTable = revenueList
    .filter(item => !filterDate || formatDateForComparison(filterDate) === item.ngay)
    .reduce((sum, item) => sum + parseCurrencyToNumber(item.tongDoanhThu), 0);


  const formattedTotalRevenueForTable = totalRevenueForTable.toLocaleString('vi-VN', { style: 'currency', currency: 'VND' });

  useEffect(() => {
    const timer = setTimeout(() => {
      setIsLoading(false);
    }, 2000);
    return () => clearTimeout(timer);
  }, []);

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
      {isLoading ? (
        <div style={modalOverlayStyle}>
          <div className="dot-spinner">
            <div className="dot-spinner__dot"></div>
            <div className="dot-spinner__dot"></div>
            <div className="dot-spinner__dot"></div>
            <div className="dot-spinner__dot"></div>
            <div className="dot-spinner__dot"></div>
            <div className="dot-spinner__dot"></div>
            <div className="dot-spinner__dot"></div>
            <div className="dot-spinner__dot"></div>
          </div>
        </div>
      ) : (
        <>
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
            <h3>Bấm vào ô bên dưới để xuất chart doanh thu theo ngày so với mục tiêu</h3>
            <button
              className="button2"
              onClick={() => setShowRevenueChartModal(true)}
            >
              <span style={{ fontSize: "18px", marginRight: "8px" }}>☰</span> Doanh thu
            </button>
          </div>

          {/* Main content */}
          <div style={{ flex: 1, padding: "24px", marginLeft: "300px" }}>
            <div style={{ display: "flex", justifyContent: "space-between" }}>
              <h3>Xin chào Gíam đốc</h3>
              <div style={{ position: "relative" }}>
                <span style={{ fontSize: "28px", cursor: "pointer" }} onClick={() => setShowAccountMenu(!showAccountMenu)}>👤</span>
                {showAccountMenu && (
                  <div style={{
                    position: "absolute", right: 0, top: "36px",
                    background: "#231C60", color: "white", borderRadius: "4px",
                    padding: "8px", minWidth: "100px", textAlign: "center"
                  }}>
                    <button onClick={() => {  setShowLogoutModal(true); setShowAccountMenu(false); }}
                      style={{ background: "none", border: "none", color: "white", cursor: "pointer" }}>
                      Đăng xuất
                    </button>
                  </div>
                )}
              </div>
            </div>

            {/* Nội dung chính - Quản lý Doanh thu */}
            <div style={{ display: "flex", flexDirection: "column", alignItems: "center" }}>
              <h3 style={{ marginTop: "24px" }}>Quản lý Doanh thu</h3>
              <div style={{ display: "flex", alignItems: "center", gap: "10px", marginBottom: "20px" }}>
                <div style={{ backgroundColor: "#ddd", color: "#000", borderRadius: "4px", padding: "6px" }}>Rạp</div>
                <select
                  value={selectedRap}
                  onChange={(e) => setSelectedRap(e.target.value)}
                  style={{ backgroundColor: "#7e57c2", color: "white", border: "none", borderRadius: "4px", padding: "6px" }}
                >
                  <option value="Chọn">Chọn</option>
                  <option value="A01">A01</option>
                  <option value="A02">A02</option>
                  <option value="A03">A03</option>
                  <option value="A04">A04</option>
                </select>
                <div style={{ backgroundColor: "#ddd", color: "#000", borderRadius: "4px", padding: "6px" }}>Ngày</div>
                <input
                  type="date"
                  value={filterDate}
                  onChange={(e) => setFilterDate(e.target.value)}
                  style={{ backgroundColor: "#7e57c2", color: "white", border: "none", borderRadius: "4px", padding: "6px" }}
                />
              </div>

              <table className="revenue-table">
                <thead>
                  <tr>
                    <th style={thStyle}>STT</th>
                    <th style={thStyle}>Ngày</th>
                    <th style={thStyle}>Tổng Doanh Thu</th>
                  </tr>
                </thead>
                <tbody>
                  {revenueList
                    .filter(item => !filterDate || formatDateForComparison(filterDate) === item.ngay)
                    .map((item) => (
                      <tr key={item.stt}>
                        <td style={tdStyle}>{item.stt}</td>
                        <td style={tdStyle}>{item.ngay}</td>
                        <td style={tdStyle}>{item.tongDoanhThu}</td>
                      </tr>
                    ))}
                </tbody>
                <tfoot>
                  {/* Hàng tổng doanh thu hiện tại của các mục đã lọc */}
                  <tr className="total-row">
                    <td style={tdStyle}>Tổng Doanh Thu Hiện Tại</td>
                    <td style={tdStyle}></td>
                    <td style={tdStyle}>{formattedTotalRevenueForTable}</td>
                  </tr>
                </tfoot>
              </table>
            </div>

            {/* Modal Đăng xuất */}
            {showLogoutModal && (
              <div style={modalOverlayStyle}>
                <div style={{ background: "#4c65a8", padding: "24px", borderRadius: "8px", textAlign: "center", color: "white", width: "300px" }}>
                  <div style={{ marginBottom: "8px" }}>
                    <div style={{ display: "flex", justifyContent: "center", marginBottom: "8px" }}>
                      <img src="/images/warning.png" alt="!" style={{ width: "40px" }} />
                    </div>
                  </div>
                  <p>Bạn chắc chắn muốn đăng xuất không?</p>
                  <div style={{ display: "flex", justifyContent: "space-around", marginTop: "16px" }}>
                    <button onClick={() => { setShowLogoutModal(false);
                      navigate("/"); setShowLogoutModal(false);alert("Đã đăng xuất"); /* navigate("/"); */ }}
                      style={{ padding: "6px 12px", border: "none", borderRadius: "4px", background: "lightgreen", color: "black" }}>Có</button>
                    <button onClick={() => setShowLogoutModal(false)}
                      style={{ padding: "6px 12px", border: "none", borderRadius: "4px", background: '#cc3380', color: "white" }}>Không</button>
                  </div>
                </div>
              </div>
            )}

            {/* Modal Biểu đồ Doanh thu */}
            {showRevenueChartModal && (
              <div style={modalOverlayStyle}>
                <MonthlyRevenueChart
                  currentRevenue={totalRevenueForTable} // THAY ĐỔI TẠI ĐÂY: Truyền tổng doanh thu đã lọc
                  onClose={() => setShowRevenueChartModal(false)} // Hàm đóng modal
                />
              </div>
            )}
          </div>
        </>
      )}
    </div>
  );
}