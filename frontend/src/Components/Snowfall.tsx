import React, { useEffect } from "react";

const Snowfall = () => {
    useEffect(() => {
        const canvas = document.getElementById("snowfall") as HTMLCanvasElement;
        const ctx = canvas.getContext("2d");

        let width = window.innerWidth;
        let height = window.innerHeight;
        canvas.width = width;
        canvas.height = height;

        const snowflakes = Array.from({ length: 150 }).map(() => ({
            x: Math.random() * width,
            y: Math.random() * height,
            radius: Math.random() * 3 + 1,
            speed: Math.random() * 1 + 0.5,
        }));

        function draw() {
            if (!ctx) return;
            ctx.clearRect(0, 0, width, height);
            ctx.fillStyle = "white";
            ctx.beginPath();
            snowflakes.forEach(flake => {
                ctx.moveTo(flake.x, flake.y);
                ctx.arc(flake.x, flake.y, flake.radius, 0, Math.PI * 2, true);
            });
            ctx.fill();
            move();
        }

        function move() {
            snowflakes.forEach(flake => {
                flake.y += flake.speed;
                if (flake.y > height) {
                    flake.y = 0;
                    flake.x = Math.random() * width;
                }
            });
        }

        function update() {
            draw();
            requestAnimationFrame(update);
        }

        update();

        window.addEventListener("resize", () => {
            width = window.innerWidth;
            height = window.innerHeight;
            canvas.width = width;
            canvas.height = height;
        });
    }, []);

    return (
        <canvas
            id="snowfall"
            className="fixed top-0 left-0 w-full h-full pointer-events-none z-50 "
        ></canvas>
    );
};

export default Snowfall;
