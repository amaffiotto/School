let tempo = 1;
let giri = 0;
let freq = 250;

function Avanti(){
    if(freq < 100)
    {
        Ferma();
        alert("Troppo Veloce");
        return;
    }

    if(tempo > 10)
    {
        tempo = 1;
    }

    let daIlluminare = document.getElementById("casella-" + tempo)
    let precedente;

    if(tempo == 1)
    {
        precedente = document.getElementById("casella-10")
    }
    else
    {
        precedente = document.getElementById("casella-"+ (tempo - 1));
    }

    let successivo
    if(tempo == 10)
    {
        successivo = document.getElementById("casella-1")
    }
    else
    {
        successivo = document.getElementById("casella-"+ (tempo + 1));
    }

    daIlluminare.classList.remove("prossima")
    daIlluminare.classList.add("accesa");
    successivo.classList.add("prossima");
    precedente.classList.remove("accesa")

    tempo++;
    giri++;
    freq -= 3;

    let h2 = document.getElementById("int-giri");
    h2.textContent("Frequenza: "+freq + " Giri: " + giri);

    clearInterval(attivo);
    attivo = setInterval(Avanti, freq);
}

let attivo;
function Avvia(){
    attivo = setInterval(Avanti, freq);
}

function Ferma(){
    clearInterval(attivo);
    attivo = null;
}
