let citta = ["Milano", "Roma", "Torino", "Napoli", "Bologna", "Firenze"];

function renderMenu(listaDaVisualizzare) {
  let container = document.getElementById("submenu-citta");
  let htmlString = ""; 

  for (let i = 0; i < listaDaVisualizzare.length; i++)
  {
    htmlString += "<li>" + listaDaVisualizzare[i] + "</li>";
  }

  container.innerHTML = htmlString;
}

renderMenu(citta);

function aggiungiCitta() {
  let nuovaCitta = prompt("Inserisci il nome della città:");
  if (nuovaCitta)
  {
    citta.push(nuovaCitta);
    renderMenu(citta);
  }
}

function rimuoviCitta() {
  citta.pop();        
  renderMenu(citta);  
}

function mostraPrimeQuattro() {
  let ridotto = citta.slice(0, 4); 
  renderMenu(ridotto);             
}