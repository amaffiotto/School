const chat = document.getElementById("chat")

function invia(user){
    let testo = document.getElementById("testo")
    let nuovo_div = document.createElement("div")
    nuovo_div.textContent = testo.value

    if(testo.value)
    {
        if(user === 1)
        {
            nuovo_div.className = "msg user1"
        }
        else
        {
            nuovo_div.className = "msg user2"
        }
    
        chat.appendChild(nuovo_div)
    }
}

function ModificaUltimoMessaggio(){
    let ultimoMess = chat.lastElementChild;

    let testo = document.getElementById("testo")
    if(testo.value)
    {
        ultimoMess.textContent = testo.value;

        let br = document.createElement("br");
        ultimoMess.appendChild(br);

        let span = document.createElement("span");
        span.textContent = " (modificato)";
        span.style.color = "grey"
        ultimoMess.appendChild(span);
    }
}

function metti(emoji) {
    let ultimoMess = chat.lastElementChild;
    if (!ultimoMess) return;

    // Rimuovi reazione esistente prima di aggiungerne una nuova
    let esistente = ultimoMess.querySelector(".emoji-reaction");
    if (esistente) esistente.remove();

    let span = document.createElement("span");
    span.textContent = " " + emoji;
    span.className = "emoji-reaction";
    ultimoMess.appendChild(span);
}

function togliEmoji() {
    let ultimoMess = chat.lastElementChild;
    if (!ultimoMess) return;

    let reazione = ultimoMess.querySelector(".emoji-reaction");
    if (reazione) reazione.remove();
}