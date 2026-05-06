const products = [
    { id: 1, nome: "Cuffie Wireless",     desc: "Suono immersivo, autonomia 30h.",         prezzo: 89.99,  sconto: 0,   emoji: "🎧" },
    { id: 2, nome: "Smartphone Pro",      desc: "Display AMOLED, 256 GB.",                 prezzo: 699.00, sconto: 10,  emoji: "📱" },
    { id: 3, nome: "Laptop Slim",         desc: "Intel i7, 16 GB RAM, SSD 512 GB.",        prezzo: 999.00, sconto: 20,  emoji: "💻" },
    { id: 4, nome: "Smartwatch",          desc: "GPS, cardiofrequenzimetro, IP68.",         prezzo: 199.00, sconto: 0,   emoji: "⌚" },
    { id: 5, nome: "Fotocamera",          desc: "24 Megapixel, obiettivo 18–55 mm.",       prezzo: 549.00, sconto: 0,   emoji: "📷" },
    { id: 6, nome: "Tastiera Meccanica",  desc: "Switch Red, retroilluminazione RGB.",      prezzo: 129.00, sconto: 15,  emoji: "⌨️" },
    { id: 7, nome: "Monitor 4K",          desc: "27 pollici, 144 Hz, IPS.",                prezzo: 449.00, sconto: 5,   emoji: "🖥️" },
    { id: 8, nome: "Mouse Gaming",        desc: "16000 DPI, 7 pulsanti programmabili.",    prezzo: 69.99,  sconto: 0,   emoji: "🖱️" },
    { id: 9, nome: "SSD Esterno",         desc: "1 TB, USB 3.2, velocità 1050 MB/s.",      prezzo: 109.00, sconto: 10,  emoji: "💾" },
    { id: 10, nome: "Webcam HD",          desc: "1080p 60fps, microfono integrato.",        prezzo: 79.00,  sconto: 0,   emoji: "📸" },
    { id: 11, nome: "Speaker Bluetooth",  desc: "360° surround, impermeabile IPX7.",       prezzo: 149.00, sconto: 25,  emoji: "🔊" },
    { id: 12, nome: "Tablet 10\"",        desc: "Octa-core, 128 GB, schermo OLED.",        prezzo: 329.00, sconto: 8,   emoji: "📟" },
];

let cartCount = 0;
let isTableView = false;

function prezzoScontato(prezzo, sconto) {
    return (prezzo - (prezzo * sconto / 100)).toFixed(2);
}

function renderGrid() {
    const grid = document.getElementById("productGrid");
    grid.innerHTML = "";

    products.forEach(p => {
        const hasSale = p.sconto > 0;
        const col = document.createElement("div");
        col.className = "col";
        col.innerHTML = `
            <div class="card shadow-sm h-100 position-relative">
                ${hasSale ? `<div class="badge-sconto">-${p.sconto}%</div>` : ""}
                <div class="card-img-top">${p.emoji}</div>
                <div class="card-body d-flex flex-column">
                    <h5 class="card-title fw-bold mb-1">${p.nome}</h5>
                    <p class="card-text text-muted small flex-grow-1">${p.desc}</p>
                    <div class="d-flex justify-content-between align-items-center mt-2">
                        <div>
                            ${hasSale ? `<span class="price-original">€ ${p.prezzo.toFixed(2)}</span><br>` : ""}
                            <span class="price">€ ${hasSale ? prezzoScontato(p.prezzo, p.sconto) : p.prezzo.toFixed(2)}</span>
                        </div>
                        <button class="btn btn-primary btn-sm px-3" onclick="addToCart()">Aggiungi</button>
                    </div>
                </div>
            </div>`;
        grid.appendChild(col);
    });
}

function renderTable() {
    const tbody = document.getElementById("productTableBody");
    tbody.innerHTML = "";

    products.forEach((p, i) => {
        const hasSale = p.sconto > 0;
        const tr = document.createElement("tr");
        tr.innerHTML = `
            <td class="fw-semibold">${i + 1}</td>
            <td>${p.emoji} ${p.nome}</td>
            <td class="text-muted">${p.desc}</td>
            <td>
                ${hasSale ? `<span class="price-original">€ ${p.prezzo.toFixed(2)}</span><br>` : ""}
                <span class="price">€ ${hasSale ? prezzoScontato(p.prezzo, p.sconto) : p.prezzo.toFixed(2)}</span>
            </td>
            <td>${hasSale ? `<span class="sconto-badge">-${p.sconto}%</span>` : '<span class="text-muted small">Nessuno</span>'}</td>`;
        tbody.appendChild(tr);
    });
}

function toggleView() {
    const gridView = document.getElementById("gridView");
    const tableView = document.getElementById("tableView");
    const btn = document.getElementById("toggleBtn");

    isTableView = !isTableView;

    if (isTableView) {
        gridView.classList.add("d-none");
        tableView.classList.remove("d-none");
        btn.textContent = "VISUALIZZA GRIGLIA";
        btn.classList.replace("btn-outline-primary", "btn-outline-secondary");
    } else {
        tableView.classList.add("d-none");
        gridView.classList.remove("d-none");
        btn.textContent = "VISUALIZZA TABELLA";
        btn.classList.replace("btn-outline-secondary", "btn-outline-primary");
    }
}

function addToCart() {
    cartCount++;
    document.getElementById("cartCount").textContent = cartCount;
}

renderGrid();
renderTable();

function ricerca(){
    let testo = document.getElementById("ricerca").value.toLowerCase();

    for(let i = 0; i < products.length; i++)
    {
        let riga = document.querySelectorAll("#productTableBody tr")[i];
        let nomeOgg = products[i].nome.toLowerCase();

        if(testo != "" && nomeOgg.includes(testo))
        {
            riga.classList.remove("d-none");
        }
        else
        {
            riga.classList.add("d-none");
        }
    }
}