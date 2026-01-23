#include <Arduino.h>
const int Rosso1 = 8;
const int Giallo1 = 12;
const int Verde1 = 13;
const int Rosso2 = 7;
const int Giallo2 = 4;
const int Verde2 = 2;


void setup() {
    pinMode(Rosso1, OUTPUT);
    pinMode(Giallo1, OUTPUT);
    pinMode(Verde1, OUTPUT);
    pinMode(Rosso2, OUTPUT);
    pinMode(Giallo2, OUTPUT);
    pinMode(Verde2, OUTPUT);
}

void loop() {
    digitalWrite(Rosso1, HIGH);
    digitalWrite(Giallo1, LOW);
    digitalWrite(Verde1, LOW);
    digitalWrite(Verde2, HIGH);
    digitalWrite(Giallo2, LOW);
    digitalWrite(Rosso2, LOW);
    delay(3000);

    digitalWrite(Rosso1, LOW);
    digitalWrite(Verde1, LOW);
    digitalWrite(Giallo1, HIGH);
    digitalWrite(Verde2, LOW);
    digitalWrite(Giallo2, LOW);
    digitalWrite(Rosso2, HIGH);
    delay(1000);

    digitalWrite(Rosso1, LOW);
    digitalWrite(Verde1, HIGH);
    digitalWrite(Giallo1, LOW);
    digitalWrite(Verde2, LOW);
    digitalWrite(Giallo2, LOW);
    digitalWrite(Rosso2, HIGH);
    delay(3000);

    digitalWrite(Rosso1, HIGH);
    digitalWrite(Verde1, LOW);
    digitalWrite(Giallo1, LOW);
    digitalWrite(Verde2, LOW);
    digitalWrite(Giallo2, HIGH);
    digitalWrite(Rosso2, LOW);
    delay(1000);

}