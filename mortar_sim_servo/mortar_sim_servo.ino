
#include <Servo.h>
Servo myServo;

char c;
String DataIn;
int degree;

void setup() {
  Serial.begin(9600);
  myServo.attach(8);
}

void Receive_Serial_Data(){
   
  while(Serial.available()>0){
    c = Serial.read();
    if (c == '#') {
      break;
      }
    else          {
      DataIn+=c;
      }
  }
  
  if(c == '#')
  {
   degree = DataIn.toInt();
   c=0;
   DataIn="";
  }
  }

void loop() {
  // put your main code here, to run repeatedly:
  Receive_Serial_Data();
  myServo.write(degree);
}
