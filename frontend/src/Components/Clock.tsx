import React, { useState, useEffect, useRef } from "react";

interface ClockProps {
    seconds: number;
    onTimeout: () => void; // Thêm prop này
}

function Clock({ seconds, onTimeout }: ClockProps) {
    const [clock, setClock] = useState<number>(seconds);
    const timerId = useRef<NodeJS.Timeout | null>(null);

    useEffect(() => {
        if (seconds <= 0) return;

        setClock(seconds);

        timerId.current = setInterval(() => {
            setClock((prevClock) => {
                if (prevClock <= 1) {
                    if (timerId.current !== null) {
                        clearInterval(timerId.current);
                    }
                    onTimeout(); // Gọi callback
                    return 0;
                }
                return prevClock - 1;
            });
        }, 1000);

        return () => {
            if (timerId.current !== null) {
                clearInterval(timerId.current);
            }
        };
    }, [seconds, onTimeout]);

    const formatTime = (totalSeconds: number): string => {
        const minutes = Math.floor(totalSeconds / 60);
        const seconds = totalSeconds % 60;
        return `${minutes.toString().padStart(2, "0")}:${seconds
            .toString()
            .padStart(2, "0")}`;
    };

    return (
        <div>
            <ul className="flex flex-col justify-between font-bold text-black items-center bg-yellow-400 p-2 rounded">
                <li className="text-xs">Thời gian giữ vé</li>
                <li className="text-xl">{formatTime(clock)}</li>
            </ul>
        </div>
    );
}

export default Clock;
