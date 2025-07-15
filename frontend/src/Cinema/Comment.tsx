import React, { useState } from "react";
import { ChatBubbleLeftEllipsisIcon } from "@heroicons/react/24/solid";
import { useNavigate } from "react-router-dom";

function Commnent() {
    const navigate = useNavigate();
    
    const [comments, setComments] = useState([
        { name: "Tên người dùng___", content: "Nội dung bình luận____" },
        { name: "Tên người dùng___", content: "Nội dung bình luận____" },
    ]);
    const [input, setInput] = useState("");

    const handleSubmit = () => {
        if (input.trim()) {
            setComments([...comments, { name: "Bạn", content: input }]);
            setInput("");
        }
    };

    return (
        <div className="min-h-screen bg-[#16004c] text-white px-4 py-6">
            <div className="max-w-6xl mx-auto grid md:grid-cols-3 gap-10">
                <div className="md:col-span-1">
                    <img
                        src="https://static2.vieon.vn/vieplay-image/poster_v4/2024/06/14/h1u4l1k8_660x946-buon-than-ban-thanh-t16-.jpg"
                        alt="poster"
                        className="rounded-xl w-full object-cover"
                    />
                </div>

                <div className="md:col-span-2 space-y-4">
                    <h1 className="text-2xl md:text-4xl font-bold">Buôn Thần Bán Thánh (T16)</h1>
                    <div className="flex flex-wrap gap-3 text-sm">
                        <span className="border px-2 py-1 rounded-md">Tâm lí</span>
                        <span className="border px-2 py-1 rounded-md">125'</span>
                        <span className="border px-2 py-1 rounded-md">Khác</span>
                    </div>
                    <div className="text-yellow-400 font-medium text-sm">
                        Phim dành cho khán giả từ đủ 16 tuổi trở lên (16+)
                    </div>
                    <div>
                        <h2 className="font-bold">Mô tả</h2>
                        <p>Đạo diễn: Pae Arak Amornsupasiri & Wutthiphong Sukanin</p>
                        <p>Khởi chiếu: Thứ sáu, 23/05/2025</p>
                    </div>
                    <div>
                        <h2 className="font-bold">Nội dung phim</h2>
                        <p>
                            Vì muốn cứu cha, chàng trai Ake buộc phải bán đi bộ sưu tập bùa cổ của gia đình. Những tưởng bất ngờ, trong đó lại có một bùa vật liên quan đến vụ thành trừng đẫm máu xa xưa mà cậu từng suýt mất mạng. Giờ đây, cậu bị cả thế giới chơi bùa lẫn những bóng ma quá khứ truy đuổi để tìm lại lá bùa thất lạc...
                        </p>
                    </div>
                </div>
            </div>

            <div className="max-w-4xl mx-auto mt-16 space-y-6">
                <div className="flex items-center gap-2 text-white text-lg font-bold">
                    <ChatBubbleLeftEllipsisIcon className="w-6 h-6 text-yellow-400" />
                    Bình luận
                </div>

                <div className="bg-gray-900 rounded-xl overflow-hidden">
                    <textarea
                        value={input}
                        onChange={(e) => setInput(e.target.value)}
                        placeholder="Viết bình luận"
                        className="w-full bg-gray-900 text-white p-4 resize-none focus:outline-none"
                        rows={3}
                    ></textarea>
                    <div className="text-right p-3">
                        <button
                            onClick={handleSubmit}
                            className="bg-yellow-500 text-white px-4 py-2 rounded hover:bg-yellow-400 transition"
                        >
                            Gửi
                        </button>
                    </div>
                </div>

                {comments.map((cmt, index) => (
                    <div
                        key={index}
                        className="bg-gray-600 text-white px-6 py-4 rounded-xl flex justify-between items-start"
                    >
                        <div>
                            <div className="font-semibold">{cmt.name}</div>
                            <div className="text-sm">{cmt.content}</div>
                        </div>
                        <div className="text-xl text-white">...</div>
                    </div>
                ))}
            </div>
        </div>
    );
}

export default Commnent;
