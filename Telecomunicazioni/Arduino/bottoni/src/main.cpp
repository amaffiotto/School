#include <Arduino.h>

int led = 0;
int ultimoStato = 0;

void setup() {
    pinMode(11, INPUT);
    pinMode(4, OUTPUT);
    pinMode(2, OUTPUT);
}

void loop() {
    int lettura = digitalRead(11);

    if (lettura == HIGH && ultimoStato == LOW) {
        led = !led;
    }

    digitalWrite(2, led);
    digitalWrite(4, !(led));
    ultimoStato = lettura;
    delay(50);
}