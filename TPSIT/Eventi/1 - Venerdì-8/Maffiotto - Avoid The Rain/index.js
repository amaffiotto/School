const player = document.getElementById("player");
const gameWidth = 700;
const playerWidth = 50;
let playerX = 325;

function movePlayer() {
    player.style.left = playerX + "px";
}

window.addEventListener("keydown", (event) => {
    const step = 20;

    if (event.key === "ArrowRight") {
        if (playerX + playerWidth + step <= gameWidth) {
            playerX += step;
        } else {
            playerX = gameWidth - playerWidth;
        }
    } 
    else if (event.key === "ArrowLeft") {
        if (playerX - step >= 0) {
            playerX -= step;
        } else {
            playerX = 0;
        }
    }
    movePlayer();
});

movePlayer();