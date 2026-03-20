//formato: "numero-seme-punti-forza"
//PUNTI 1=11, 3=10, 10=4, 9=3, 8=2, tutti gli altri 0
//FORZA 1=10, 3=9, 10=8,
const carte = ["1-B-11-10", "2-B-0-1", "3-B-10-9", "4-B-0-2", "5-B-0-3", "6-B-0-4", "7-B-0-5", "8-B-2-6", "9-B-3-7", "10-B-4-8",
"1-O-11-10", "2-O-0-1", "3-O-10-9", "4-O-0-2", "5-O-0-3", "6-O-0-4", "7-O-0-5", "8-O-2-6", "9-O-3-7", "10-O-4-8",
"1-S-11-10", "2-S-0-1", "3-S-10-9", "4-S-0-2", "5-S-0-3", "6-S-0-4", "7-S-0-5", "8-S-2-6", "9-S-3-7", "10-S-4-8",
"1-C-11-10", "2-C-0-1", "3-C-10-9", "4-C-0-2", "5-C-0-3", "6-C-0-4", "7-C-0-5", "8-C-2-6", "9-C-3-7", "10-C-4-8"];

// Queste cose venogno fatte nel momento in cui viene caricata la pagine
window.onload = function() {
    // Let Carta 1 0 document.getelementById("divCartaCpu1");
    cartaCpu1.src = 'path'
    // ...  
}

let mazzo = Array(40);
let indexMazzo = 0;
let turno = "user";
let puntiCpu = 0;
let puntiUsr = 0;
let cartaGiocataCpu;
let CartaGiocataUtente;
let carteUscite = Array(40);


function start(){
    resetStatoIniziale();
    mischiaMazzo();
    daiCartePrimaMano();
    determinaBriscola();
}

function resetStatoIniziale(){
    puntiUser = 0;
    puntiCpu = 0;
    playerPoints.textContent = puntiUsr
    cpuPoints.textContent = puntiCpu
    cartaGiocataCpu = null;
    CartaGiocataUtente = null;
    deckCount.textContent = "40"
}

function mischiaMazzo(){
    carteUscite.forEach(element => {
        element = -1;
    });
}