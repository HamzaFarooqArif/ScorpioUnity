#include <WebServer.h>
#include "index_html.h"

#define LEDn    12
//#define LEDpwm   2

#define LEDC_CHANNEL_0     0
#define LEDC_TIMER_13_BIT  13
#define LEDC_BASE_FREQ     5000
#define LED_PIN            2


//Define name of the Wifi & password for creating an access point
const char* ssid = "esp32";           //"ZONG MBB-E5573-AE26";
//!!!Your password MUST be a minimum of 8 characters...otherwise neither password nor ssid will be accepted -> default or old ssid&pwd will show up!!! 
const char* password = "12345678";    //"58688303";


WebServer server(80);

bool led;
int pwm;
int pwmCount;

void ledON(){
  led=1;
}

void ledOFF(){
  led=0;  
}
//pwm functions - if pwm is set to 1/-1 it will in-/decrease pwmCounter in loop()
void plus(){
  pwm=3;  
}

void minus(){
  pwm=-3;  
}

void stopPWM(){
  pwm=0;  
}
//----------------------------------------------------------------------------------
void handleRoot(){
  server.send(200, "text/html", webpage);  
}

void ledcAnalogWrite(uint8_t channel, uint32_t value, uint32_t valueMax = 255) 
{
  uint32_t duty = (8191 / valueMax) * min(value, valueMax);
  ledcWrite(channel, duty);
}

void setup() {
  //Setup Analog________________
  ledcSetup(LEDC_CHANNEL_0, LEDC_BASE_FREQ, LEDC_TIMER_13_BIT);
  ledcAttachPin(LED_PIN, LEDC_CHANNEL_0);
  //Setup Serial________________
  Serial.begin(9600);
  //Set LED pins to output________________
  pinMode(LEDn,OUTPUT);
  //pinMode(LEDpwm,OUTPUT);
  //Wifi as access point__________________
  WiFi.mode(WIFI_AP);
  IPAddress apLocalIp(2,2,2,2);
  IPAddress apSubnetMask(255,255,255,0);
  WiFi.softAPConfig(apLocalIp,apLocalIp,apSubnetMask);
  WiFi.softAP(ssid, password);
  //Server________________________________
  server.begin();
  server.on("/", handleRoot);
  server.on("/LEDon", ledON);     
  server.on("/LEDoff", ledOFF);   
  server.on("/minus", minus);   
  server.on("/plus", plus);   
  server.on("/stop", stopPWM);   
  //initialize variables__________________
  pwm=0;
  pwmCount=0;
  led=0;
}

void loop() {
  server.handleClient();
  //turns LED ON/OFF (GPIO 2/D4)
  digitalWrite(LEDn, led);
  
  //in-/decreases pwmCount(=brightness)
  pwmCount+=pwm;
  //to hold pwmCount in it's range (min 0 - max 1024)
  if(pwmCount>1024)pwmCount=1024;
  if(pwmCount<0)pwmCount=0;
  //Serial.println(pwmCount);
  //sets pwmCount to PWM value of GPIO 12/D6
  //analogWrite(LEDpwm, pwmCount);
  ledcAnalogWrite(LEDC_CHANNEL_0, pwmCount);
  delay(10);
}
