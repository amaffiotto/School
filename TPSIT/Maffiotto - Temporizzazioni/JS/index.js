"option strict"
let index = 1;
let ruota;

function EseguiCambioImg(){
    h3img.textContent = `Immagine n.${index}`
    imgCarta.src = `img/q${index}.gif`;
    index++;
    if(index > 9)
    {
        index = 1;
    }
}

function CambiaImg(){
    setTimeout(EseguiCambioImg, 3000)
}

// Set interval(funzione, ms):
// Esegue la funzione che gli passo ripetutamente ogni n millisecondi
// Restituisce un indice numerico 
function RuotaImg(){
    ruota = setInterval(EseguiCambioImg, 1500)
}

// clearInterval - ferma un setInterval
// parametro è l'indice numerico ritornato dalla setInterva
function StopRotazione(){
    clearInterval(ruota)
    ruota = null
}

function ApriFinestra(){
    window.open("new.html", "", "width=350,height=200,left=100,top=100");
}