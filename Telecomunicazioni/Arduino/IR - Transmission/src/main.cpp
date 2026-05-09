#include <Arduino.h>
const int txIR = 9;   // Trasmettitore IR
const int rxIR = 2;   // Ricevitore IR
const int led = 3;    // LED visibile

void setup() {

    // Pin trasmettitore
    pinMode(txIR, OUTPUT);

    // Pin ricevitore con pull-up interna
    pinMode(rxIR, INPUT_PULLUP);

    // LED uscita
    pinMode(led, OUTPUT);
}

void loop() {

    // ===== TRASMISSIONE ON =====
    digitalWrite(txIR, HIGH);

    // Mantiene acceso il LED se il fascio è presente
    if (digitalRead(rxIR) == LOW) {

        digitalWrite(led, HIGH);

    } else {

        digitalWrite(led, LOW);
    }

    delay(2000);


    // ===== TRASMISSIONE OFF =====
    digitalWrite(txIR, LOW);

    // Controllo ricevitore
    if (digitalRead(rxIR) == LOW) {

        digitalWrite(led, HIGH);

    } else {

        digitalWrite(led, LOW);
    }

    delay(2000);
}