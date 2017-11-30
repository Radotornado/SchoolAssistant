int message = 0;
int relay = 11;
int onPin = 12;

void setup()
{
 Serial.begin(9600);
 pinMode(relay, OUTPUT);     
 pinMode(onPin, OUTPUT);    
}

void loop()
{
  digitalWrite(onPin, HIGH);
 if (Serial.available() > 0)
 {
  message = Serial.read();
  if (message == 'A')
   {
   digitalWrite(relay, HIGH);
   delay(3000);
   digitalWrite(relay, LOW);
  }
  if (message == 'B')
  {
   digitalWrite(relay, HIGH);
   delay(2000);
   digitalWrite(relay, LOW);
   delay(1000);
   digitalWrite(relay, HIGH);
   delay(2000);
   digitalWrite(relay, LOW);
  }
  if (message == 'C')
  {
   digitalWrite(relay, HIGH);
   delay(10000);
   digitalWrite(relay, LOW);
  }
 }
}
