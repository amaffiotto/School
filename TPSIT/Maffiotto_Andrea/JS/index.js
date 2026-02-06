let rispostaSelezionata = -1;

function renderQuiz() {
    let iframee = document.getElementById('card');
    let btn0Class = rispostaSelezionata === 0 ? 'reply selected' : 'reply';
    let btn1Class = rispostaSelezionata === 1 ? 'reply selected' : 'reply';
    let btn2Class = rispostaSelezionata === 2 ? 'reply selected' : 'reply';

    iframee.innerHTML = `
        <div class="cont-tut">
            <div class="quest-cont">
                <h3>Qual è il simbolo ufficiale delle olimpiadi?</h3>
                <button class="${btn0Class}" id="risposta0" onclick="selezionaRisposta(0)">Una torcia</button>
                <button class="${btn1Class}" id="risposta1" onclick="selezionaRisposta(1)">5 anelli intrecciati</button>
                <button class="${btn2Class}" id="risposta2" onclick="selezionaRisposta(2)">Una bandiera</button>
            </div>
            <button class="btn-oli" id="btn-ver" onclick="verificaRisposta()">Verifica</button>
            <p id="output"></p>
        </div>`;
}

function mostraSezione() {
    rispostaSelezionata = -1;
    renderQuiz();
}

function selezionaRisposta(numeroRisposta) {
    rispostaSelezionata = numeroRisposta;
    renderQuiz();
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