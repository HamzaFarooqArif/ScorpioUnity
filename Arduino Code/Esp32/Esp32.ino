#include "WiFi.h"
#include "ESPAsyncWebServer.h"
#include <ESP32Servo.h>

#define LEDC_TIMER_13_BIT  13
#define LEDC_BASE_FREQ     5000
 
//const char* ssid = "ZONG MBB-E5573-AE26";
//const char* password =  "58688303";
const char* ssid = "EVO-Charji-BF2C";
const char* password =  "HJhV7473";

char out_str[40];  

AsyncWebServer server(80);

const int chCount = 9;
int paramArray[chCount] = {0, 0, 0, 0, 0, 0, 0, 0, 0};
int pinsArray[chCount] = {15, 2, 4, 16, 17, 5, 18, 19, 21};

Servo ch1Servo;
Servo ch2Servo;

void setupAnalogWrite()
{
  for(int i = 0; i < chCount; i++)
  {
    ledcSetup(i, LEDC_BASE_FREQ, LEDC_TIMER_13_BIT);
    ledcAttachPin(pinsArray[i], i);
  }
}

void setupServoWrite()
{
  ch1Servo.attach(pinsArray[0], 530, 2200);
  ch2Servo.attach(pinsArray[1], 530, 2200);
}

void ledcAnalogWrite(uint8_t channel, uint32_t value, uint32_t valueMax = 255) {
  uint32_t duty = (8191 / valueMax) * min(value, valueMax);
  ledcWrite(channel, duty);
}


void printArray()
{
  for(int i = 0; i < chCount; i++)
    {
      String result = String(paramArray[i]);
      Serial.print(result + " ");
    }
    Serial.println();
}

void writeValue()
{
  for(int i = 0; i < chCount; i++)
  {
    ledcAnalogWrite(i, paramArray[i]);
  }
}

void writeServoValue()
{
  ch1Servo.write(paramArray[0]);
  ch2Servo.write(paramArray[1]);
}

void setup(){
  //setupAnalogWrite();
  setupServoWrite();  
  Serial.begin(115200);

  for(int i = 0; i < 9; i++)
  {
    pinMode(pinsArray[i], OUTPUT);
  }
  
  WiFi.begin(ssid, password);
  
  strcpy(out_str, "Connecting to ");
  strcat(out_str, ssid);
   
  while (WiFi.status() != WL_CONNECTED) {
    delay(1000);
    Serial.println(out_str);
  }
 
  Serial.println(WiFi.localIP());
 
  server.on("/", HTTP_GET, [](AsyncWebServerRequest *request){
 
    int paramsNr = request->params();
    //Serial.println(paramsNr);
 
    for(int i=0;i<paramsNr;i++){
 
        AsyncWebParameter* p = request->getParam(i);
        if(p->name().toInt() < chCount)
        {
          paramArray[p->name().toInt()] = p->value().toInt();
        }
        
        //paramArray[i] = p->value().toInt();
        //Serial.print("Param index: ");
        //Serial.println(p->name());
        //Serial.println(i);
        //Serial.print("Param value: ");
        //Serial.println(paramArray[i]);
        //Serial.println("------");
    }
    
    //writeValue();
    writeServoValue();
    printArray();
 
    request->send(200, "text/plain", "message received");
  });
 
  server.begin();
}
 
void loop(){}
