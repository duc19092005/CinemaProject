import React from "react";
import logo from '../image/logocinema1.png';

function Bottom() {

    return (
        <footer className=" text-center py-4 text-sm text-gray-400 bg-sky-900 w-auto ">
            <div className="flex flex-row justify-center items-center gap-4">
                <ul>
                    <li>
                        <img
                            src={logo} alt="logo"
                            className="w-50 h-20 hover:scale-105 transition-transform duration-300"
                        />
                    </li>
                    <li>
                        <a className="underline text-base " href="https://cinestar.com.vn/chinh-sach-bao-mat/">
                            Chính sách khách hàng thường xuyên
                        </a>
                    </li>
                    <li>
                        <a className="underline text-base" href="https://cinestar.com.vn/chinh-sach-bao-mat/">
                            Chính sách bảo mật
                        </a>
                    </li>
                    <li>
                        <a className="underline text-base" href="https://cinestar.com.vn/chinh-sach-bao-mat/">
                            Điều khoản sử dụng
                        </a>
                    </li>
                    <li>
                        <span>CÔNG TY TNHH CINEMA VIỆT NAM</span>
                    </li>
                    <li>
                        <span>Giấy CNĐKDN: 9999999999 , đăng ký lần đầu ngày 20/02/2002,  cấp bởi Sở KHĐT Thành phố Hồ Chí Minh</span>
                    </li>
                    <li>
                        <span>Địa chỉ: Tầng 6, 828 Sư Vạn Hạnh, Phường Hòa Hưng, Thành phố Hồ Chí Minh,Việt Nam</span>
                    </li>
                    <li>
                        <span>Hotline: (028) 7777 8888</span>
                    </li>
                    <li>
                        <span>COPYRIGHT © CINEMA.COM - ALL RIGHTS RESERVED.</span>
                    </li>
                </ul></div>


        </footer>
    )
}
export default Bottom;