int lowerBit = 5;
int higherBit = 6;
int timeElapsed = 7;
int pulseLength = 100;

void setup()
{
  pinMode(lowerBit, INPUT);
  pinMode(higherBit, INPUT);
  pinMode(timeElapsed, OUTPUT);
}

void loop()
{
  if (lowerBit == HIGH && higherBit == LOW)
  {
    wait(1);
  }
  
  if (lowerBit == LOW && higherBit == HIGH)
  {
    wait(2);
  }
  
  if (lowerBit == HIGH && higherBit == HIGH)
  {
    wait(3);
  }
  
  delay(100);
}

void wait(int input)
{
  if (input == 1)
  {
    delay(5000);
    digitalWrite(timeElapsed, HIGH);
    delay(pulseLength);
    digitalWrite(timeElapsed, LOW);
  }
  
  if (input == 2)
  {
    delay(60000);
    digitalWrite(timeElapsed, HIGH);
    delay(pulseLength);
    digitalWrite(timeElapsed, LOW);
  }
  
  if (input == 3)
  {
    delay(180000);
    digitalWrite(timeElapsed, HIGH);
    delay(pulseLength);
    digitalWrite(timeElapsed, LOW);
  }
  
  digitalWrite(timeElapsed, LOW);
}
