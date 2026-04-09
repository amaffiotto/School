
let secondiCrono = 0;
let minutiCrono = 0;
let oreCrono = 0;
let intervalCrono = null;

function avviaCronometro() {

    if (intervalCrono != null) return;

    intervalCrono = setInterval(function() {
        secondiCrono++;

        if (secondiCrono >= 60) {
            secondiCrono = 0;
            minutiCrono++;
        }

        if (minutiCrono >= 60) {
            minutiCrono = 0;
            oreCrono++;
        }

        aggiornaDisplayCrono();
    }, 1000);
}

function fermaCronometro() {
    clearInterval(intervalCrono);
    intervalCrono = null;
}

function resetCronometro() {
    fermaCronometro();
    secondiCrono = 0;
    minutiCrono = 0;
    oreCrono = 0;
    aggiornaDisplayCrono();
}

function aggiornaDisplayCrono() {
    let display = document.getElementById("display-cronometro");
    display.textContent = formatta(oreCrono) + ":" + formatta(minutiCrono) + ":" + formatta(secondiCrono);
}

let secondiTimer = 0;
let minutiTimer = 0;
let oreTimer = 0;
let intervalTimer = null;

function avviaTimer() {
    if (intervalTimer != null) return;

    if (secondiTimer == 0 && minutiTimer == 0 && oreTimer == 0) {
        oreTimer    = parseInt(document.getElementById("inp-ore").value)     || 0;
        minutiTimer = parseInt(document.getElementById("inp-minuti").value)  || 0;
        secondiTimer = parseInt(document.getElementById("inp-secondi").value) || 0;
    }

    if (oreTimer == 0 && minutiTimer == 0 && secondiTimer == 0) {
        document.getElementById("messaggio-timer").textContent = "Inserisci un tempo!";
        return;
    }

    document.getElementById("messaggio-timer").textContent = "";
    aggiornaDisplayTimer();

    intervalTimer = setInterval(function() {
        secondiTimer--;

        if (secondiTimer < 0) {
            secondiTimer = 59;
            minutiTimer--;
        }

        if (minutiTimer < 0) {
            minutiTimer = 59;
            oreTimer--;
        }

        aggiornaDisplayTimer();

        if (oreTimer == 0 && minutiTimer == 0 && secondiTimer == 0) {
            clearInterval(intervalTimer);
            intervalTimer = null;
            document.getElementById("messaggio-timer").textContent = "Tempo scaduto!";
        }

    }, 1000);
}

function fermaTimer() {
    clearInterval(intervalTimer);
    intervalTimer = null;
}

function resetTimer() {
    fermaTimer();
    secondiTimer = 0;
    minutiTimer = 0;
    oreTimer = 0;
    document.getElementById("messaggio-timer").textContent = "";
    document.getElementById("inp-ore").value = 0;
    document.getElementById("inp-minuti").value = 0;
    document.getElementById("inp-secondi").value = 0;
    aggiornaDisplayTimer();
}

function aggiornaDisplayTimer() {
    let display = document.getElementById("display-timer");
    display.textContent = formatta(oreTimer) + ":" + formatta(minutiTimer) + ":" + formatta(secondiTimer);
}

function formatta(numero) {
    if (numero < 10) {
        return "0" + numero;
    }
    return "" + numero;
}
