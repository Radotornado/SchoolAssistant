int message = 0;
int LEDPin = 11;

void setup()
{
 Serial.begin(9600);
 pinMode(LEDPin, OUTPUT);     
}

void loop()
{
 if (Serial.available() > 0)
 {
  message = Serial.read();
  if (message == 'A')
   {
   digitalWrite(LEDPin, HIGH);
   delay(3000);
   digitalWrite(LEDPin, LOW);
  }
  if (message == 'B')
  {
   digitalWrite(LEDPin, HIGH);
   delay(2000);
   digitalWrite(LEDPin, LOW);
   delay(1000);
   digitalWrite(LEDPin, HIGH);
   delay(2000);
   digitalWrite(LEDPin, LOW);
  }
  if (message == 'C')
  {
   digitalWrite(LEDPin, HIGH);
   delay(10000);
   digitalWrite(LEDPin, LOW);
  }
 }
}
