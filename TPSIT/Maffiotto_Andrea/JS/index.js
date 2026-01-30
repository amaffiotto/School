let frame;
function mostraSezione() {
    iframee = document.getElementById('card');
    iframee.innerHTML = '<div class="cont-tut"><div class="quest-cont"><h3>Qualè il simbolo ufficiale delle olimpiadi?</h3><button class="reply" id="risposta0" onclick="selezionaRisposta(0)">Una torcia</button><button class="reply" id="risposta1" onclick="selezionaRisposta(1)">5 anelli intrecciati</button><button class="reply" id="risposta2" onclick="selezionaRisposta(2)">Una bandiera</button></div><button class="btn-oli" id="btn-ver" onclick="verificaRisposta()">Verifica</button><p id="output"></p></div>';
}
let rispostaSelezionata;
function selezionaRisposta(numeroRisposta) {
    let btn0 = document.getElementById("risposta0")
    let btn1 = document.getElementById("risposta1")
    let btn2 = document.getElementById("risposta2")
    if (numeroRisposta == 0) {
        rispostaSelezionata = 0;
        btn0.style.backgroundColor = " #e0e0e0";
    }
    else if (numeroRisposta == 1) {
        rispostaSelezionata = 1;
        btn1.style.backgroundColor = " #e0e0e0";
    }
    else {
        rispostaSelezionata = 2;
        btn2.style.backgroundColor = " #e0e0e0";
    }
}
function verificaRisposta() {
    let output = document.getElementById("output");
    if (rispostaSelezionata == 1) {
        let numero1 = Math.random()
        if (numero1 > 0.75) {
            numero1 = 3;
        }
        else if (numero1 > 0.50) {
            numero1 = 2;
        }
        else if (numero1 > 0.25) {
            numero1 = 1;
        }
        else {
            numero1 = 0;
        }

        if (numero1 == 3) {
            let numero2 = Math.random()
            if (numero1 > 0.75) {
                numero2 = 8;
                output.textContent = "COMPLIMENTI hai vinto un biglietto per pattinaggio";
            }
            else if (numero1 > 0.50) {
                numero2 = 7;
                output.textContent = "COMPLIMENTI hai vinto un biglietto per Bob";
            }
            else if (numero1 > 0.25) {
                numero2 = 6;
                output.textContent = "COMPLIMENTI hai vinto un biglietto per Slittino";
            }
            else {
                numero2 = 5;
                output.textContent = "COMPLIMENTI hai vinto un biglietto per Curling";
            }

        }
        else {
            output.textContent = "Risposta corretta, ma non hai vinto il biglietto";
        }
    }
    else {
        output.textContent = "Risposta sbagliata. Riprova!";
    }
}