## Eventi Comuni

- click: Utente clicca su elemento
- mousehover: mouse passa sopra elemento
- mouseout: mouse esce da elemento
- keydown: l'utente preme un tasto da tastiera
- input: un elemento di tipologia input viene scritto dentro
- submit: viene inviato un form

## Eventlistener

Ascolta un determinato elemento per vedere se succede un evento del tipo specificato ed esegue la funzione specificata se quell'evento succede

### elemento.addEveentListener("tipo_evento", funzione)

````
    let b = document.getElementById("btn");
    b.addEventListener("click", function() { 
        alert("Hai cliccato qui");
    });
````

## Maniere diverse per scrivere la funzione
````
    elemento.addEveentListener("tipo_evento", function() {

    });

    elemento.addEveentListener("tipo_evento", () => {

    });

    elemento.addEveentListener("tipo_evento", funzione);

    //se la funziona ha parametri

    elemento.addEveentListener("tipo_evento", () => {funzione(x)});

    //oppure

    elemento.addEveentListener("tipo_evento", function() {
        funzione(x);
    });
````

## Prendere un tasto specifico in input
````
    elemento.addEveentListener("tipo_evento", (evento) => {
        if(evento.key === "tasto")
        {
            funzione(x);
        }
    });

    // il parametro della funzione anonima sarà sempre l'evento
````



