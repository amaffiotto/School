//Replicare la seguente grafica con HTML e CSS.

//formato: "numero-seme-punti-forza"
//PUNTI 1=11, 3=10, 10=4, 9=3, 8=2, tutti gli altri 0
//FORZA 1=10, 3=9, 10=8,
const carte = ["1-B-11-10", "2-B-0-1", "3-B-10-9", "4-B-0-2", "5-B-0-3", "6-B-0-4", "7-B-0-5", "8-B-2-6", "9-B-3-7", "10-B-4-8",
"1-O-11-10", "2-O-0-1", "3-O-10-9", "4-O-0-2", "5-O-0-3", "6-O-0-4", "7-O-0-5", "8-O-2-6", "9-O-3-7", "10-O-4-8",
"1-S-11-10", "2-S-0-1", "3-S-10-9", "4-S-0-2", "5-S-0-3", "6-S-0-4", "7-S-0-5", "8-S-2-6", "9-S-3-7", "10-S-4-8",
"1-C-11-10", "2-C-0-1", "3-C-10-9", "4-C-0-2", "5-C-0-3", "6-C-0-4", "7-C-0-5", "8-C-2-6", "9-C-3-7", "10-C-4-8"];

//window.onload  --> Fa' la funzione al caricamento della pagina
window.onload = function(){
    playerPoints    = document.getElementById("h2-punti-usr");
    cpuPoints       = document.getElementById("h2-punti-cpu");
    deckCount       = document.getElementById("cont-mazzo");
    briscolaCardImg = document.getElementById("carta-briscola");
    playerPlayedImg = document.getElementById("carta-tavolo-usr");
    cpuPlayedImg    = document.getElementById("carta-tavolo-cpu");
    turnPlayer      = document.getElementById("cont-turno");
    turnoGiocatore  = document.getElementById("cont-turno");
    statusText      = document.getElementById("status-text");
    carteUser = [
        document.getElementById("carta-usr-1"),
        document.getElementById("carta-usr-2"),
        document.getElementById("carta-usr-3")
    ];
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
let briscola;
let manoUser = Array(3);
let manoPc = Array(3);
let indiceCartaGiocata;
let indiceCartaGiocataPc;

function NuovaPartita()
{
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
    cartaGiocataComputer = null;
    cartaGiocataUtente = null;
    deckCount.textCount = "40";
}

function mischiaMazzo()
{
    /*[-1; -1; -1; .....] 40 posizioni
    nessuna carta è ancora uscita
    */
    for(let i = 0; i < 40; i++)
    {
        carteUscite[i] = -1;
    }

    for(let i = 0; i < 40; i++)
    {
        let carta;
        do{
            carta = Math.floor(Math.random() * 40);            
        }while(carteUscite.includes(carta));

        carteUscite[i] = carta;
        mazzo[i] = carte[carta];
    }

    console.log(mazzo);
}

function daiCartePrimaMano()
{

}

function getPathFile(carta)
{
    let parti = carta.split("-");

    return "img/CARTE/" + cartaBriscola.split("-")[0] + "-" + cartaBriscola.split("-")[1] + ".png";
}


function determinaBriscola()
{
    let cartaBriscola = mazzo[39];
    /*FUNZIONE SPLIT  "1-B-11-10"  --->  [1, B, 11, 10] */
    briscola = cartaBriscola.split("-")[0] + "-" + cartaBriscola.split("-")[1];

    console.log("La briscola è: " + briscola);
    briscolaCardImg.src = getPathFile(cartaBriscola);
}

function daiCartePrimaMano()
{
    for(let i = 0; i < 3; i++)
    {
        manoUser[i] = mazzo[i*2];
        manoPc[i] = mazzo[i*2 + 1];

        carteUser[i].src = getPathFile(manoUser[i]);
        carteUser[i].style.display = "";
        carteUser[i].classList.remove("card--disabled");  //carteUser[i].classList.remove("classe1"); Se voglio rimuovere la classe --> .add Se voglio aggiungere        
    }
    indexMazzo = 6; //le prime 6 carte sono state distribuite
    deckCount.textContent = 40 - indexMazzo;        
}

//pointer-events: none  --> fa in modo nel css che non ci siano :hover, :clicked ...

function GiocaCarta(indice)
{
    console.log("Il turno è " + turno);

    if(turno != "user")
    {
        alert("Non è il tuo turno");
        return;
    }

    console.log("La carta giocata è " + manoUser[indice]);
    playerPlayedImg.src = getPathFile(manoUser[indice]);
    playerPlayedImg.style.display = "block";
    carteUser[indice].style.display = "none";
    indiceCartaGiocata = indice;
    cartaGiocataUtente = manoUser[indice];
    manoUser[indice] = null;
    //disabilitato le altre carte che ha in mano il giocatore
    for(let i = 0; i < 3; i++)
    {
        if(i != indice && manoUser[i] != null)
        {
            carteUser[i].classList.add("card--disabled");
        }
    }

    if(cartaGiocataComputer != null)
    {
        calcolaPunteggio();
        turno = "user";
    }
    else{
        turno = "computer";
        turnPlayer.textContent = turno;
        setTimeout(function(){GiocaComputer();}, 1000);        
    }
}

function GiocaComputer()
{
    turno = "computer";
    console.log("Il computer sta giocando...");
    indiceCartaGiocataPc = Math.floor(Math.random * 3);
    cpuPlayedImg.src = getPathFile(manoPc[indiceCartaGiocataPc]);
    cpuPlayedImg.style.display = "block";
    cartaGiocataComputer = manoPc[indiceCartaGiocata];
    console.log("Il piccirilli ha stampato: " + cartaGiocataComputer);
    manoPc[indiceCartaGiocata] = null;

    if(cartaGiocataUtente != null)
    {
        //l'utente ha giocato
        calcolaPunteggio();
    }
    else{
        turno = "user";
        turnoGiocatore.textContent = "tu";        

        for(let i = 0; i < 3; i++)
        {
            if(manoUser[i] != null)
            {
                carteUser[i].classList.remove("card--disabled");
            }
        }
    }
}


function calcolaPunteggio()
{
    if(cartaGiocataUtente == null || cartaGiocataComputer == null)
    {
        return;
    }

    console.log("Calcola punteggio tra " + cartaGiocataComputer + " e " + cartaGiocataUtente);

    let puntiUtente = parseInt(cartaGiocataUtente.split("-")[2]);
    let puntiComputer = parseInt(cartaGiocataComputer.split("-")[2]);
    let semeUtente = cartaGiocataUtente.split("-")[1];
    let semeComputer = cartaGiocataComputer.split("-")[1];
    let forzaUtente = parseInt(cartaGiocataUtente.split("-")[3]);
    let forzaComputer = parseInt(cartaGiocataComputer.split("-")[3]);

    let puntiTotali = puntiComputer + puntiUtente;
    let vincitore;

    if(semeUtente == semeComputer)
    {
        vincitore = forzaUtente > forzaComputer ? "utente" : "computer";
    }else if(semeUtente == briscola && semeComputer != briscola)
    {
        vincitore = "utente";
    }else if(semeUtente != briscola && semeComputer == briscola)
    {
        vincitore = "computer";
    }else if(semeUtente != briscola && semeComputer != briscola)
    {
        vincitore = turno == "user" ? "computer" : "user";
    }
    else{
        vincitore = forzaUtente > forzaComputer ? "utente" : "computer";
    }

    aggiornaEMostraPunteggio(vincitore, puntiTotali);
}

function aggiornaEMostraPunteggio(vincitore, puntiTotali)
{
    if(vincitore == "utente")
    {
        statusText.textContent = "Prendi tu! Hai guadagnato " + puntiTotali + " punti.";
        puntiUser += puntiTotali;
        playerPoints.textContent = puntiUser;
    }
    else
    {
        statusText.textContent = "Prende il computer! Ha guadagnato " + puntiTotali + " punti.";
        puntiComputer += puntiTotali;
        cpuPoints.textContent = puntiComputer;
    }

    cartaGiocataUtente = null;
    cartaGiocataComputer = null;
}