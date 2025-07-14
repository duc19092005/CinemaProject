import React, { useState } from 'react';


function Food() {
    const [foodCounts, setFoodCounts] = useState<{ [key: string]: number }>({});

    const food = [
        { key: "Coke", img: "https://api-website.cinestar.com.vn/media/.thumbswysiwyg/pictures/HinhQuayconnew/coca.png?rand=1719572301", label: "Coke 32oz", price: 109000 },
        { key: "Fanta", img: "https://api-website.cinestar.com.vn/media/.thumbswysiwyg/pictures/HinhQuayconnew/fanta.jpg?rand=1719572506", label: "Fanta 32oz", price: 129000 },
        { key: "CokeZero", img: "https://api-website.cinestar.com.vn/media/.thumbswysiwyg/pictures/PICCONNEW/CNS034_COMBO_PARTY.png?rand=1723084117", label: "Coke Zero 32oz", price: 129000 },
        { key: "Sprite", img: "https://api-website.cinestar.com.vn/media/.thumbswysiwyg/pictures/PICCONNEW/CNS034_COMBO_PARTY.png?rand=1723084117", label: "Sprite 32oz", price: 129000 },
    ];
    const food2 = [
        { key: "Coke", img: "https://api-website.cinestar.com.vn/media/.thumbswysiwyg/pictures/HinhQuayconnew/coca.png?rand=1719572301", label: "Coke 32oz", price: 109000 },
        { key: "Fanta", img: "https://api-website.cinestar.com.vn/media/.thumbswysiwyg/pictures/HinhQuayconnew/fanta.jpg?rand=1719572506", label: "Fanta 32oz", price: 129000 },
        { key: "CokeZero", img: "https://api-website.cinestar.com.vn/media/.thumbswysiwyg/pictures/PICCONNEW/CNS034_COMBO_PARTY.png?rand=1723084117", label: "Coke Zero 32oz", price: 129000 },
        { key: "Sprite", img: "https://api-website.cinestar.com.vn/media/.thumbswysiwyg/pictures/PICCONNEW/CNS034_COMBO_PARTY.png?rand=1723084117", label: "Sprite 32oz", price: 129000 },
    ];
    const totalfood = Object.entries(foodCounts).reduce(
        (sum, [key, count]) =>
            sum + (food.find((c) => c.key === key)?.price || 0) * count,
        0
    );

    return (
        <div>
            {/* drink Selector */}
            <div className="mb-6 flex flex-col items-center">
                <p className="text-xl font-bold text-yellow-400 mb-4 uppercase">Nước ngọt</p>
                <div className="grid grid-cols-1 md:grid-cols-3 gap-4">
                    {food.map((c) => (
                        <div key={c.key} className="bg-transparent p-4 rounded border border-zinc-100 w-96 flex flex-row justify-center items-center gap-16">
                            <div>
                                <img src={c.img} alt={c.label} className="w-full h-32 object-cover mb-2 rounded" />
                            </div>
                            <div>
                                <p className=" text-white uppercase font-bold hover:text-yellow-300 transition-colors">{c.label}</p>
                                <p className="text-yellow-400">{c.price.toLocaleString()} VND</p>
                                <div className="flex items-center gap-2 mt-2">
                                    <button onClick={() => setFoodCounts((prev) => ({ ...prev, [c.key]: Math.max((prev[c.key] || 0) - 1, 0) }))} className="bg-slate-300 px-2 hover:bg-yellow-300">-</button>
                                    <span className="text-white">{foodCounts[c.key] || 0}</span>
                                    <button onClick={() => setFoodCounts((prev) => ({ ...prev, [c.key]: (prev[c.key] || 0) + 1 }))} className="bg-slate-300 px-2 hover:bg-yellow-300">+</button>
                                </div>
                            </div>
                        </div>
                    ))}
                </div>
            </div>
            {/* food Selector */}
            <div className="mb-6 flex flex-col items-center">
                <p className="text-xl font-bold text-yellow-400 mb-4 uppercase">Snacks</p>
                <div className="grid grid-cols-1 md:grid-cols-3 gap-4">
                    {food2.map((c) => (
                        <div key={c.key} className="bg-transparent p-4 rounded border border-zinc-100 w-96 flex flex-row justify-center items-center gap-16">
                            <div>
                                <img src={c.img} alt={c.label} className="w-full h-32 object-cover mb-2 rounded" />
                            </div>
                            <div>
                                <p className=" text-white uppercase font-bold hover:text-yellow-300 transition-colors">{c.label}</p>
                                <p className="text-yellow-400">{c.price.toLocaleString()} VND</p>
                                <div className="flex items-center gap-2 mt-2">
                                    <button onClick={() => setFoodCounts((prev) => ({ ...prev, [c.key]: Math.max((prev[c.key] || 0) - 1, 0) }))} className="bg-slate-300 px-2 hover:bg-yellow-300">-</button>
                                    <span className="text-white">{foodCounts[c.key] || 0}</span>
                                    <button onClick={() => setFoodCounts((prev) => ({ ...prev, [c.key]: (prev[c.key] || 0) + 1 }))} className="bg-slate-300 px-2 hover:bg-yellow-300">+</button>
                                </div>
                            </div>
                        </div>
                    ))}
                </div>
            </div>
        </div>
    );
}

export default Food;