let lettereIndovinate = "";
let zonaParola = document.getElementById("parola");
let zonaGioca = document.getElementById("zona-btn-gioca");
let zonaInput = document.getElementById("input-lettera");
let zonaArt = document.getElementById("art-impiccato");
let vite = 7;

function Gioca() {
    zonaGioca.innerHTML = `<button onclick="Guess()">Indovina</button>`;
    zonaInput.innerHTML = `<input type="text" id="ins-lettera" maxlength="1" placeholder="...">`;
    lettereIndovinate = "";
    vite = 7;
    Aggiorna();
}

function Aggiorna() {
    let mask = "";
    for (let l of parolaSegreta) {
        if(lettereIndovinate.includes(l)){
            mask += `<span>${l}</span>`;
        }
        else{
            mask += `<span>_</span>`;
        }
    }
    zonaParola.innerHTML = mask;

    switch (vite) {
        case 6: zonaArt.innerHTML = `<img src="./img/stage1.png">`; break;
        case 5: zonaArt.innerHTML = `<img src="./img/stage2.png">`; break;
        case 4: zonaArt.innerHTML = `<img src="./img/stage3.png">`; break;
        case 3: zonaArt.innerHTML = `<img src="./img/stage4.png">`; break;
        case 2: zonaArt.innerHTML = `<img src="./img/stage5.png">`; break;
        case 1: zonaArt.innerHTML = `<img src="./img/stage6.png"> <p class="warning">⚠️ ULTIMA OCCASIONE! ⚠️</p>`; break;
        case 0: zonaArt.innerHTML = `<h1 class="lose">HAI PERSO!</h1>`; break;
        default: zonaArt.innerHTML = ""; break;
    }
}

function Guess() {
    let campo = document.getElementById("ins-lettera");
    let l = campo.value.toUpperCase();

    if (l === "" || vite <= 0) return;

    if (lettereIndovinate.includes(l)) {
        alert("Lettera già inserita!");
        campo.value = "";
        return;
    }

    if (!parolaSegreta.includes(l)) {
        vite--;
    }

    lettereIndovinate += l;
    Aggiorna();

    if (!zonaParola.innerText.includes("_")) {
        zonaArt.innerHTML = `<h1 class="win">HAI VINTO! 🏆</h1>`;
        zonaInput.innerHTML = ""; 
        zonaGioca.innerHTML = `<button onclick="location.reload()">Riprova</button>`;
    } else if (vite <= 0) {
        zonaInput.innerHTML = "";
        zonaGioca.innerHTML = `<button onclick="location.reload()">Riprova</button>`;
    }

    campo.value = "";
    campo.focus();
}