let mazzo = [
  "1-B", "2-B", "3-B", "4-B", "5-B", "6-B", "7-B", "8-B", "9-B", "10-B",
  "1-C", "2-C", "3-C", "4-C", "5-C", "6-C", "7-C", "8-C", "9-C", "10-C",
  "1-O", "2-O", "3-O", "4-O", "5-O", "6-O", "7-O", "8-O", "9-O", "10-O",
  "1-S", "2-S", "3-S", "4-S", "5-S", "6-S", "7-S", "8-S", "9-S", "10-S"
];

let turno = 0;
let punteggioUsr = 0;
let punteggioCpu = 0;
let semeBriscola = "";
let stringaCartaTavoloUsr = "";
let stringaCartaTavoloCpu = "";
let carteUsate = [];
let manoUsrCarte = [];
let manoCpuCarte = [];

let divCartaUsr1 = document.getElementById("carta-usr-1");
let divCartaUsr2 = document.getElementById("carta-usr-2");
let divCartaUsr3 = document.getElementById("carta-usr-3");
let divCartaCpu1 = document.getElementById("carta-cpu-1");
let divCartaCpu2 = document.getElementById("carta-cpu-2");
let divCartaCpu3 = document.getElementById("carta-cpu-3");
let cartaTavoloUsr = document.getElementById("carta-tavolo-usr");
let cartaTavoloCpu = document.getElementById("carta-tavolo-cpu");
let cartaBriscola = document.getElementById("carta-briscola");

function IsCartaUsata(carta) {
    return carteUsate.includes(carta);
}

function CartaCasuale() {
    if (carteUsate.length >= 40) return null;
    let carta;
    do {
        let rnd = Math.floor(Math.random() * 40);
        carta = mazzo[rnd];
    } while (IsCartaUsata(carta));
    carteUsate.push(carta);
    return carta;
}

function SemeCarta(carta) {
    switch (carta[carta.length - 1]) {
        case "B": return "Bastoni";
        case "C": return "Coppe";
        case "O": return "Oro";
        case "S": return "Spade";
        default:
            console.error("Carta non trovata/Seme");
            return null;
    }
}

function AumentaTurno() {
    let contTurno = document.getElementById("cont-turno");
    contTurno.textContent = "Turno: " + turno;
}

function visualizzaCarta(carta, elemento) {
    let imgPath = "";
    elemento.textContent = "";
    switch (carta) {
        case "1-B": imgPath = "img-carte/1-B.png"; break;
        case "2-B": imgPath = "img-carte/2-B.png"; break;
        case "3-B": imgPath = "img-carte/3-B.png"; break;
        case "4-B": imgPath = "img-carte/4-B.png"; break;
        case "5-B": imgPath = "img-carte/5-B.png"; break;
        case "6-B": imgPath = "img-carte/6-B.png"; break;
        case "7-B": imgPath = "img-carte/7-B.png"; break;
        case "8-B": imgPath = "img-carte/8-B.png"; break;
        case "9-B": imgPath = "img-carte/9-B.png"; break;
        case "10-B": imgPath = "img-carte/10-B.png"; break;
        case "1-C": imgPath = "img-carte/1-C.png"; break;
        case "2-C": imgPath = "img-carte/2-C.png"; break;
        case "3-C": imgPath = "img-carte/3-C.png"; break;
        case "4-C": imgPath = "img-carte/4-C.png"; break;
        case "5-C": imgPath = "img-carte/5-C.png"; break;
        case "6-C": imgPath = "img-carte/6-C.png"; break;
        case "7-C": imgPath = "img-carte/7-C.png"; break;
        case "8-C": imgPath = "img-carte/8-C.png"; break;
        case "9-C": imgPath = "img-carte/9-C.png"; break;
        case "10-C": imgPath = "img-carte/10-C.png"; break;
        case "1-O": imgPath = "img-carte/1-O.png"; break;
        case "2-O": imgPath = "img-carte/2-O.png"; break;
        case "3-O": imgPath = "img-carte/3-O.png"; break;
        case "4-O": imgPath = "img-carte/4-O.png"; break;
        case "5-O": imgPath = "img-carte/5-O.png"; break;
        case "6-O": imgPath = "img-carte/6-O.png"; break;
        case "7-O": imgPath = "img-carte/7-O.png"; break;
        case "8-O": imgPath = "img-carte/8-O.png"; break;
        case "9-O": imgPath = "img-carte/9-O.png"; break;
        case "10-O": imgPath = "img-carte/10-O.png"; break;
        case "1-S": imgPath = "img-carte/1-S.png"; break;
        case "2-S": imgPath = "img-carte/2-S.png"; break;
        case "3-S": imgPath = "img-carte/3-S.png"; break;
        case "4-S": imgPath = "img-carte/4-S.png"; break;
        case "5-S": imgPath = "img-carte/5-S.png"; break;
        case "6-S": imgPath = "img-carte/6-S.png"; break;
        case "7-S": imgPath = "img-carte/7-S.png"; break;
        case "8-S": imgPath = "img-carte/8-S.png"; break;
        case "9-S": imgPath = "img-carte/9-S.png"; break;
        case "10-S": imgPath = "img-carte/10-S.png"; break;
        default:
            console.error("Carta non trovata");
            return;
    }
    elemento.style.backgroundImage = `url('${imgPath}')`;
    elemento.style.backgroundSize = "contain";
    elemento.style.backgroundRepeat = "no-repeat";
    elemento.style.backgroundPosition = "center";
}

function ValoreCarta(carta) {
    switch (parseInt(carta)) {
        case 2:
        case 4:
        case 5:
        case 6:
        case 7:
            return 0;
        case 1: return 11;
        case 3: return 10;
        case 8: return 2;
        case 9: return 3;
        case 10: return 4;
        default:
            console.error("Carta non trovata: " + carta);
            return 0;
    }
}

function AggiornaPunteggi() {
    document.getElementById("h2-punti-usr").textContent = "Punti: " + punteggioUsr;
    document.getElementById("h2-punti-cpu").textContent = "Punti: " + punteggioCpu;
}

function ImpostaRetro(elemento) {
    elemento.textContent = "";
    elemento.style.backgroundImage = "url('img-carte/retro.jpg')";
    elemento.style.backgroundSize = "contain";
    elemento.style.backgroundRepeat = "no-repeat";
    elemento.style.backgroundPosition = "center";
}

function ResetDivCarta(elemento, testo) {
    elemento.style.backgroundImage = "none";
    elemento.style.backgroundSize = "";
    elemento.style.backgroundRepeat = "";
    elemento.style.backgroundPosition = "";
    elemento.textContent = testo;
}

function ResetDivCartaCpu(elemento) {
    elemento.style.backgroundImage = "";
    elemento.style.backgroundSize = "";
    elemento.style.backgroundRepeat = "";
    elemento.style.backgroundPosition = "";
    elemento.textContent = "?";
}

function TutteLeCarteVuote() {
    return manoUsrCarte.every(c => c === null) && manoCpuCarte.every(c => c === null);
}

function GiocaCpu() {
    let miglioreIndice = -1;
    let miglioreValore = -1;

    for (let i = 0; i < 3; i++) {
        if (manoCpuCarte[i] === null) continue;
        let seme = SemeCarta(manoCpuCarte[i]);
        let valore = ValoreCarta(manoCpuCarte[i]);
        let semeUsr = SemeCarta(stringaCartaTavoloUsr);
        if (seme === semeBriscola) valore += 100;
        else if (seme === semeUsr) valore += 50;
        if (valore > miglioreValore) {
            miglioreValore = valore;
            miglioreIndice = i;
        }
    }

    if (miglioreIndice === -1) return;

    stringaCartaTavoloCpu = manoCpuCarte[miglioreIndice];
    visualizzaCarta(manoCpuCarte[miglioreIndice], cartaTavoloCpu);
    let nuovaCarta = CartaCasuale();
    let divMano = [divCartaCpu1, divCartaCpu2, divCartaCpu3];
    if (nuovaCarta !== null) {
        manoCpuCarte[miglioreIndice] = nuovaCarta;
        ImpostaRetro(divMano[miglioreIndice]);
    } else {
        manoCpuCarte[miglioreIndice] = null;
        ResetDivCartaCpu(divMano[miglioreIndice]);
    }
}

function GiocaCarta(numeroCarta) {
    if (turno >= 20) return;
    if (manoUsrCarte[numeroCarta] === null) return;
    stringaCartaTavoloUsr = manoUsrCarte[numeroCarta];
    visualizzaCarta(manoUsrCarte[numeroCarta], cartaTavoloUsr);
    let nuovaCarta = CartaCasuale();
    let divMano = [divCartaUsr1, divCartaUsr2, divCartaUsr3];
    if (nuovaCarta !== null) {
        manoUsrCarte[numeroCarta] = nuovaCarta;
        visualizzaCarta(nuovaCarta, divMano[numeroCarta]);
    } else {
        manoUsrCarte[numeroCarta] = null;
        ResetDivCarta(divMano[numeroCarta], "");
    }
    GiocaCpu();
    CalcolaVincitore();
    if (TutteLeCarteVuote()) FinePartita();
}

function FinePartita() {
    if (punteggioUsr > punteggioCpu) {
        alert("Hai vinto! " + punteggioUsr + " a " + punteggioCpu);
    } else if (punteggioCpu > punteggioUsr) {
        alert("Ha vinto il computer! " + punteggioCpu + " a " + punteggioUsr);
    } else {
        alert("Pareggio! " + punteggioUsr + " a " + punteggioCpu);
    }
}

function CalcolaVincitore() {
    let semeUsr = SemeCarta(stringaCartaTavoloUsr);
    let semeCpu = SemeCarta(stringaCartaTavoloCpu);
    let valoreUsr = ValoreCarta(stringaCartaTavoloUsr);
    let valoreCpu = ValoreCarta(stringaCartaTavoloCpu);
    let punti = valoreUsr + valoreCpu;
    let vince = "";

    if (semeUsr === semeCpu) {
        vince = valoreUsr >= valoreCpu ? "usr" : "cpu";
    } else if (semeUsr === semeBriscola) {
        vince = "usr";
    } else if (semeCpu === semeBriscola) {
        vince = "cpu";
    } else {
        vince = "usr";
    }

    if (vince === "usr") {
        punteggioUsr += punti;
    } else {
        punteggioCpu += punti;
    }

    turno++;
    AumentaTurno();
    AggiornaPunteggi();
}

function NuovaPartita() {
    punteggioCpu = 0;
    punteggioUsr = 0;
    turno = 0;
    carteUsate = [];

    ResetDivCarta(cartaTavoloUsr, "Vuoto");
    ResetDivCarta(cartaTavoloCpu, "Vuoto");
    ResetDivCarta(cartaBriscola, "briscola");
    ResetDivCarta(divCartaUsr1, "?");
    ResetDivCarta(divCartaUsr2, "?");
    ResetDivCarta(divCartaUsr3, "?");
    ResetDivCartaCpu(divCartaCpu1);
    ResetDivCartaCpu(divCartaCpu2);
    ResetDivCartaCpu(divCartaCpu3);

    let briscola = CartaCasuale();
    semeBriscola = SemeCarta(briscola);
    visualizzaCarta(briscola, cartaBriscola);

    manoUsrCarte = [CartaCasuale(), CartaCasuale(), CartaCasuale()];
    manoCpuCarte = [CartaCasuale(), CartaCasuale(), CartaCasuale()];

    visualizzaCarta(manoUsrCarte[0], divCartaUsr1);
    visualizzaCarta(manoUsrCarte[1], divCartaUsr2);
    visualizzaCarta(manoUsrCarte[2], divCartaUsr3);

    ImpostaRetro(divCartaCpu1);
    ImpostaRetro(divCartaCpu2);
    ImpostaRetro(divCartaCpu3);

    AggiornaPunteggi();
    AumentaTurno();
}