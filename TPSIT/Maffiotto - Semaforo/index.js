let tempo = 0;

let active;

let btnAttiva = document.getElementById("btn-attiva")
let btnFerma = document.getElementById("btn-ferma")

let verde = document.getElementById("h2-gre")
let giallo = document.getElementById("h2-yel")
let rosso = document.getElementById("h2-red")

let divVerde = document.querySelector(".verde")
let divGiallo = document.querySelector(".giallo")
let divRosso = document.querySelector(".rosso")

function Avvia(){
    active = setInterval(ScorriTempo, 1000)
    btnAttiva.disabled = true;
    btnFerma.disabled = false;
}

function Ferma(){
    clearInterval(active);
    active = null;
    btnAttiva.disabled = false;
    btnFerma.disabled = true;
}

function ScorriTempo()
{
    if(tempo <= 0)
    {
        tempo = 18
    }

    divVerde.classList.remove("v-acc")
    divGiallo.classList.remove("g-acc")
    divRosso.classList.remove("r-acc")

    if(tempo > 10)
    {
        let tempoh2 = tempo - 10;
        verde.textContent = tempoh2
        giallo.textContent = "";
        rosso.textContent = "";
        divVerde.classList.add("v-acc")
    }
    else if(tempo > 5)
    {
        let tempoh2 = tempo - 5;
        verde.textContent = "";
        giallo.textContent = tempoh2;
        rosso.textContent = "";
        divGiallo.classList.add("g-acc")
    }
    else
    {
        let tempoh2 = tempo;
        verde.textContent = "";
        giallo.textContent = "";
        rosso.textContent = tempoh2;
        divRosso.classList.add("r-acc")
    }

    tempo--;
}

