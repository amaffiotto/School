function saluto() {
    console.log("Ciao");
}

function cambiaTesto() {
    let titolo = document.getElementById("test");
    titolo.textContent = "Titolo cambiato";
}

function ripristinaTesto() {
    let titolo = document.getElementById("test");
    titolo.textContent = "Titolo originale";
}
