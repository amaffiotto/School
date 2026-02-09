#include <Arduino.h>

void setup()
{
    pinMode(2, OUTPUT);
    pinMode(8, INPUT);
    pinMode(7, INPUT);
    pinMode(6, OUTPUT);
}

void loop()
{
    int statoPulsante = digitalRead(7);
    digitalWrite(2, statoPulsante);

    int segnaleRicevuto = digitalRead(8);
    digitalWrite(6, segnaleRicevuto);
    delay(500);
}