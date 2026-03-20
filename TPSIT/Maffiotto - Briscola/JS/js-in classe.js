//formato: "numero-seme-punti-forza"
//PUNTI 1=11, 3=10, 10=4, 9=3, 8=2, tutti gli altri 0
//FORZA 1=10, 3=9, 10=8,
const carte = ["1-B-11-10", "2-B-0-1", "3-B-10-9", "4-B-0-2", "5-B-0-3", "6-B-0-4", "7-B-0-5", "8-B-2-6", "9-B-3-7", "10-B-4-8",
    "1-O-11-10", "2-O-0-1", "3-O-10-9", "4-O-0-2", "5-O-0-3", "6-O-0-4", "7-O-0-5", "8-O-2-6", "9-O-3-7", "10-O-4-8",
    "1-S-11-10", "2-S-0-1", "3-S-10-9", "4-S-0-2", "5-S-0-3", "6-S-0-4", "7-S-0-5", "8-S-2-6", "9-S-3-7", "10-S-4-8",
    "1-C-11-10", "2-C-0-1", "3-C-10-9", "4-C-0-2", "5-C-0-3", "6-C-0-4", "7-C-0-5", "8-C-2-6", "9-C-3-7", "10-C-4-8"];

window.onload = function() {
    //let carta1 = documento.getElementById("cartaPc1")
    cartaPc1.src = "img/CARTE/retro.jpg";
    cartaPc2.src = "img/CARTE/retro.jpg";
    cartaPc3.src = "img/CARTE/retro.jpg";
    cartaUser1.src = "img/CARTE/retro.jpg";
    cartaUser2.src = "img/CARTE/retro.jpg";
    cartaUser3.src = "img/CARTE/retro.jpg";
}

//variabili globali
let mazzo = Array(40); 
let indexMazzo = 0; 
let turno = "user";
let puntiComputer = 0;
let puntiUser = 0;
let cartaGiocataComputer;
let cartaGiocataUtente;
let carteUscite = Array(40);
let manoUsr = Array(3);
let manoCpu = Array(3);

function start(){
    resetStatoIniziale();
    mischiaMazzo();
    daiCartePrimaMano();
    determinaBriscola();
}

function resetStatoIniziale(){
    puntiUser = 0;
    puntiComputer = 0;
    playerPoints.textContent = "0";
    cpuPoints.textContent = "0";
    cartaGiocataUtente = null;
    cartaGiocataComputer = null;
    deckCount.textContent = "40"
}

function mischiaMazzo(){

    //Nessuna carta è ancora uscita
    for(let i = 0; i < 40; i++){
        carteUscite[i] = -1;
    }

    for(let i = 0; i < 40; i++)
    {
        let carta;
        do{
            carta = Math.floor(Math.random()*40);
        }while(carteUscite.includes(carta));

        carteUscite[i] = carta;
        mazzo[i] = carte[carta];
    }

    console.log(mazzo);
}

function daiCartePrimaMano(){
    for(let i = 0; i < 3; i++)
    {
        manoUsr[i] = mazzo[i * 2];
        manoCpu[i] = mazzo[i*2 + 1];
        carteUser[i]
    }
    indexMazzo = 6;
}


function determinaBriscola(){
    let cartaBriscola = mazzo[39];

    
    briscola = cartaBriscola.split('-')
    console.log("la briscola è " + briscola);
    briscolaCardImg.src = 'img/CARTE/' + cartaBriscola.split("-")[0] + "-" + cartaBriscola.split("-")[1]
}
