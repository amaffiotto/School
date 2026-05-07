"use strict"
const symbols = ['💻', '🌐', '🗄️', '🐛', '🔑', '📦', '🔒', '☁️'];

const CONFIG = {
    maxLives: 3,
    inputSeconds: 60,
    numRound: 10
}

const gameState = {
    sequence: [],
    round: 0,
    score: 0,
    lives: CONFIG.maxLives
}

const btnGrid       = document.querySelector(".griglia-carte");
const scoreDisplay  = document.getElementById("punteggio");
const roundNum      = document.getElementById("numero-round");
const livesRow      = document.getElementById("vite");
const btnStart      = document.getElementById("bottone-inizio");
const seqContainer  = document.getElementById("mostra-sequenza");
const seqLenDisplay = document.getElementById("lunghezza-sequenza");
const testoRis      = document.getElementById("testo-risultato");
const timerDisplay  = document.getElementById("timer");

let playerSequence = [];
let numClick = 0;
let timerInterval = null;
let tempoRimasto = 0;

function getSeqBoxes() {
    return seqContainer.querySelectorAll('.box-sequenza');
}

window.onload = function () {
    const carte = btnGrid.querySelectorAll('.carta');
    carte.forEach((carta, pos) => {
        carta.addEventListener('click', () => chooseSymbol(pos));
    });

    btnGrid.classList.add("disabledButtons");
    aggiornaVite();
};


function start() {
    gameState.round = 1;
    gameState.score = 0;
    gameState.lives = CONFIG.maxLives;

    btnStart.disabled = true;
    btnStart.innerHTML = '▶ INIZIA PARTITA';

    scoreDisplay.innerHTML = gameState.score;
    testoRis.innerHTML = '-';
    aggiornaVite();

    iniziaRound();
}


function iniziaRound() {
    numClick = 0;
    playerSequence = [];
    gameState.sequence = [];

    roundNum.innerHTML = gameState.round;
    btnGrid.classList.add("disabledButtons");

    const boxes = getSeqBoxes();
    boxes.forEach((box, i) => {
        if (i < gameState.round) {
            box.classList.remove("disabled");
            box.innerHTML = '?';
        } else {
            box.classList.add("disabled");
            box.innerHTML = '';
        }
    });

    setSymbol(gameState.round);
}

function setSymbol(round) {
    seqLenDisplay.innerHTML = round;

    for (let i = 0; i < round; i++) {
        gameState.sequence[i] = symbols[Math.floor(Math.random() * symbols.length)];
    }
    console.log("Sequenza da indovinare:", gameState.sequence);

    for (let i = 0; i < round; i++) {
        setTimeout(() => visSymbol(i), 800 * (i + 1));
    }

    setTimeout(() => hydeSymbols(round), 800 * (round + 1));
}

function visSymbol(i) {
    const boxes = getSeqBoxes();
    boxes[i].innerHTML = gameState.sequence[i];
    boxes[i].classList.add("attivo");
}

function hydeSymbols(round) {
    const boxes = getSeqBoxes();
    for (let i = 0; i < round; i++) {
        boxes[i].innerHTML = '?';
        boxes[i].classList.remove("attivo");
    }
    btnGrid.classList.remove("disabledButtons");
    avviaTimer();
}


function avviaTimer() {
    tempoRimasto = CONFIG.inputSeconds;
    timerDisplay.innerHTML = tempoRimasto;

    timerInterval = setInterval(() => {
        tempoRimasto--;
        timerDisplay.innerHTML = tempoRimasto;

        if (tempoRimasto <= 0) {
            fermaTimer();
            btnGrid.classList.add("disabledButtons");
            gameState.lives--;
            gameState.score = Math.max(0, gameState.score - 50);
            aggiornaVite();
            scoreDisplay.innerHTML = gameState.score;

            if (gameState.lives <= 0) {
                finePartita(false);
            } else {
                testoRis.innerHTML = `Tempo scaduto! -50 punti. Ti restano ${gameState.lives} vite. Riprova il round.`;
                setTimeout(() => iniziaRound(), 2000);
            }
        }
    }, 1000);
}

function fermaTimer() {
    clearInterval(timerInterval);
    timerInterval = null;
    timerDisplay.innerHTML = '-';
}

function chooseSymbol(pos) {
    const boxes = getSeqBoxes();

    boxes[numClick].innerHTML = symbols[pos];
    playerSequence.push(symbols[pos]);
    numClick++;

    if (numClick === gameState.round) {
        btnGrid.classList.add("disabledButtons");
        fermaTimer();
        controllaSequenza();
    }
}

function controllaSequenza() {
    let seqCorretta = true;

    for (let i = 0; i < gameState.round; i++) {
        if (gameState.sequence[i] !== playerSequence[i]) {
            seqCorretta = false;
            break;
        }
    }

    if (seqCorretta) {
        gameState.score += 100;
        scoreDisplay.innerHTML = gameState.score;

        if (gameState.round >= CONFIG.numRound) {
            finePartita(true);
        } else {
            testoRis.innerHTML = `✅ Sequenza corretta! +100 punti. Round ${gameState.round + 1} tra poco...`;
            gameState.round++;
            setTimeout(() => iniziaRound(), 2000);
        }

    } else {
        gameState.lives--;
        gameState.score = Math.max(0, gameState.score - 50);
        aggiornaVite();
        scoreDisplay.innerHTML = gameState.score;

        if (gameState.lives <= 0) {
            finePartita(false);
        } else {
            testoRis.innerHTML = `❌ Sequenza errata! -50 punti. Ti restano ${gameState.lives} vite. Riprova.`;
            setTimeout(() => iniziaRound(), 2000);
        }
    }
}

function finePartita(vittoria) {
    btnGrid.classList.add("disabledButtons");
    fermaTimer();

    if (vittoria) {
        testoRis.innerHTML = `🏆 Hai completato tutti i round! Punteggio finale: ${gameState.score}`;
    } else {
        testoRis.innerHTML = `💀 Game Over! Punteggio finale: ${gameState.score}`;
    }

    btnStart.disabled = false;
    btnStart.innerHTML = '▶ NUOVA PARTITA';
}

function aggiornaVite() {
    livesRow.innerHTML = '';
    for (let i = 0; i < gameState.lives; i++) {
        livesRow.innerHTML += '🖤';
    }
}
