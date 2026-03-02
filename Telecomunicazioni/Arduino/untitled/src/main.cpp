#include <Arduino.h>
// C++ code
//

int count = 0;
void setup()
{
    pinMode(2, INPUT);
    pinMode(3, INPUT);
    pinMode(7, OUTPUT);
    pinMode(8, OUTPUT);
    pinMode(9, OUTPUT);
    pinMode(10, OUTPUT);
}

void loop()
{
    if (digitalRead(2) == HIGH) {
        if (count < 9) count++;
        delay(250);
    }

    if (digitalRead(3) == HIGH) {
        if (count > 0) count--;
        delay(250);
    }

    switch (count) {
        case 0: digitalWrite(7, 0); digitalWrite(8, 0); digitalWrite(9, 0); digitalWrite(10, 0); break;
        case 1: digitalWrite(7, 1); digitalWrite(8, 0); digitalWrite(9, 0); digitalWrite(10, 0); break;
        case 2: digitalWrite(7, 0); digitalWrite(8, 1); digitalWrite(9, 0); digitalWrite(10, 0); break;
        case 3: digitalWrite(7, 1); digitalWrite(8, 1); digitalWrite(9, 0); digitalWrite(10, 0); break;
        case 4: digitalWrite(7, 0); digitalWrite(8, 0); digitalWrite(9, 1); digitalWrite(10, 0); break;
        case 5: digitalWrite(7, 1); digitalWrite(8, 0); digitalWrite(9, 1); digitalWrite(10, 0); break;
        case 6: digitalWrite(7, 0); digitalWrite(8, 1); digitalWrite(9, 1); digitalWrite(10, 0); break;
        case 7: digitalWrite(7, 1); digitalWrite(8, 1); digitalWrite(9, 1); digitalWrite(10, 0); break;
        case 8: digitalWrite(7, 0); digitalWrite(8, 0); digitalWrite(9, 0); digitalWrite(10, 1); break;
        case 9: digitalWrite(7, 1); digitalWrite(8, 0); digitalWrite(9, 0); digitalWrite(10, 1); break;
    }

}