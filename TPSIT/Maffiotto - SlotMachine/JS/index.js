let num1;
let num2;
let num3;
let slot1 = document.getElementById("n1");
let slot2 = document.getElementById("n2");
let slot3 = document.getElementById("n3");
let areaMessaggio;

function gioca(){
    num1 = Math.floor(Math.random() * 9);
    num2 = Math.floor(Math.random() * 9);
    num3 = Math.floor(Math.random() * 9);
    slot1.textContent = displayEmoji(num1);
    slot2.textContent = displayEmoji(num2);
    slot3.textContent = displayEmoji(num3);

areaMessaggio = document.getElementById("messaggio");

    if (num1 == num2 && num2 == num3){
        areaMessaggio.textContent = "Jackpot";
    }
    else if(num1 == num2 || num2 == num3 || num1 == num3){
        areaMessaggio.textContent = "Ci sei quasi";
    }
    else{
        areaMessaggio.textContent = "Riprova";
    }
}

function displayEmoji(num){
    let slot;
    switch(num) {
    case 0:
        slot = "🍒";
        break;
    case 1:
        slot = "🍋";
        break;
    case 2:
        slot = "🍊";
        break;
    case 3:
        slot = "🔔";
        break;
    case 4:
        slot = "🍇";
        break;
    case 5:
        slot = "💎";
        break;
    case 6:
        slot = "🍀";
        break;
    case 7:
        slot = "🎰";
        break;
    case 8:
        slot = "💰";
        break;
    default:
        alert("ERRORE");
        break;
        }
    return slot;
    }
