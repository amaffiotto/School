#include <Arduino.h>
void setup() {
    pinMode(9, OUTPUT);
    pinMode(5, OUTPUT);
    pinMode(8, OUTPUT);
}
void loop() {

    digitalWrite(8, HIGH);
    delayMicroseconds(167);
    digitalWrite(8, LOW);
    delayMicroseconds(167);
}