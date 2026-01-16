let numero;
function GeneraNumero(){
    numero = Math.floor(Math.random() * 101) + 100;
    console.log(numero);

    let immDiv = document.getElementById("ImageContainer");
    if (numero < 120){
        immDiv.innerHTML = '<img src="./Images/Immagine1.png" alt="imm1">';
    }
    else if (numero < 140){
        immDiv.innerHTML = '<img src="./Images/Immagine2.jpg" alt="imm1">';
    }
    else if (numero < 160){
        immDiv.innerHTML = '<img src="./Images/Immagine3.png" alt="imm1">';
    }
    else if (numero < 180){
        immDiv.innerHTML = '<img src="./Images/Immagine4.jpg" alt="imm1">';
    }
    else{
        immDiv.innerHTML = '<img src="./Images/Immagine5.jpg" alt="imm1">';
    }
}

function IndovinaNumero(){
    let guess = document.getElementById("guessBox").value;
    let resCon = document.getElementById("ResultContainer");
    let diff = guess - numero;
    if(guess == numero){
        resCon.innerHTML='<p>Risposta Corretta</p>'
    }
    else{
        resCon.innerHTML='<p>La differenza tra il numero scelto e quello generato è: </p>' + diff;
    }

}

