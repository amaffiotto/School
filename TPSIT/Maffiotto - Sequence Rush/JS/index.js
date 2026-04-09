"use strict"
const symbols = [ '💻', '🌐', '🗄️', '🐛', '🔑', '📦', '🔒', '☁️'];

const CONFIG = {
    maxLives: 3,
    inputSeconds: 60,
    numRound: 10
}

const gameState = {
    sequence: [],
    round: 0,
    score: 0,
    lives: CONFIG.maxLives,
    inputSeconds: CONFIG.inputSeconds
}

const btnGrid = document.querySelector(".griglia-carte");
const scoreDisplay = document.getElementById("punteggio")
const roundNum = document.getElementById("numero-round")
const livesRow = document.getElementById("vite")
const btnStart = document.getElementById("bottone-inizio")
const roundSymbol = document.getElementById("mostra-sequenza")
const seqLenDisplay = document.getElementById("lunghezza-sequenza")

let numClick = 0;
let seqCorretta = false;

window.onload = function(){
    for(let i = 0; i < CONFIG.maxLives; i++)
    {
        livesRow.innerHTML += '🖤'
    }
    for(let i = 0; i < CONFIG.maxLives; i++)
    {
        roundSymbol[i].classList.add("disabled")
    }
    btnGrid.classList.add("disabledButtons")
}

function start(){
    
}