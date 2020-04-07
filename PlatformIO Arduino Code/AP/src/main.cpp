#include <WiFi.h>
#include "esp_wifi.h"
#include <WiFiClient.h>
#include <WiFiAP.h>
#include <ESP32Servo.h>

#define LED_BUILTIN 2

// Set these to your desired credentials.
const char *ssid = "esp32"; //const char *ssid = "ZONG MBB-E5573-AE26";
const char *password = "12345678";        //const char *password = "58688303";

tcpip_adapter_sta_list_t adapter_sta_list;
char* message = "";

const int chCount = 9;
int paramArray[chCount] = {85, 85, 85, 85, 85, 85, 85, 85, 85};
int pinsArray[chCount] = {15, 2, 4, 16, 17, 5, 18, 19, 21};

#define LEDC_TIMER_13_BIT  13
#define LEDC_BASE_FREQ     5000
Servo ch1Servo;
Servo ch2Servo;
Servo ch3Servo;
Servo ch4Servo;
Servo ch5Servo;
Servo ch6Servo;
Servo ch7Servo;
Servo ch8Servo;
Servo ch9Servo;

WiFiServer server(80);

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
  ch1Servo.setPeriodHertz(50);
  ch2Servo.setPeriodHertz(50);
  ch3Servo.setPeriodHertz(50);
  ch4Servo.setPeriodHertz(50);
  ch5Servo.setPeriodHertz(50);
  ch6Servo.setPeriodHertz(50);
  ch7Servo.setPeriodHertz(50);
  ch8Servo.setPeriodHertz(50);
  ch9Servo.setPeriodHertz(50);
  
  ch1Servo.attach(pinsArray[0], 1000, 2000); //ch1Servo.attach(pinsArray[0], 530, 2200);
  ch2Servo.attach(pinsArray[1], 1000, 2000); //ch2Servo.attach(pinsArray[1], 530, 2200);
  ch3Servo.attach(pinsArray[2], 1000, 2000); //ch3Servo.attach(pinsArray[2], 530, 2200);
  ch4Servo.attach(pinsArray[3], 1000, 2000); //ch4Servo.attach(pinsArray[2], 530, 2200);
  ch5Servo.attach(pinsArray[4], 1000, 2000); //ch5Servo.attach(pinsArray[2], 530, 2200);
  ch6Servo.attach(pinsArray[5], 1000, 2000); //ch6Servo.attach(pinsArray[2], 530, 2200);
  ch7Servo.attach(pinsArray[6], 1000, 2000); //ch7Servo.attach(pinsArray[2], 530, 2200);
  ch8Servo.attach(pinsArray[7], 1000, 2000); //ch8Servo.attach(pinsArray[2], 530, 2200);
  ch9Servo.attach(pinsArray[8], 1000, 2000); //ch9Servo.attach(pinsArray[2], 530, 2200);
}
void ledcAnalogWrite(uint8_t channel, uint32_t value, uint32_t valueMax = 255) {
  uint32_t duty = (8191 / valueMax) * min(value, valueMax);
  ledcWrite(channel, duty);
}
String printArray()
{
  String result = "";
  for(int i = 0; i < chCount; i++)
    {
      String temp = String(paramArray[i]);
      result += temp + " ";
      Serial.print(temp + " ");
    }
    Serial.println();
    return result;
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
  ch3Servo.write(paramArray[2]);
  ch4Servo.write(paramArray[3]);
  ch5Servo.write(paramArray[4]);
  ch6Servo.write(paramArray[5]);
  ch7Servo.write(paramArray[6]);
  ch8Servo.write(paramArray[7]);
  ch9Servo.write(paramArray[8]);
}
void refreshStaList()
{
  wifi_sta_list_t wifi_sta_list;
  memset(&wifi_sta_list, 0, sizeof(wifi_sta_list));
  memset(&adapter_sta_list, 0, sizeof(adapter_sta_list));
  esp_wifi_ap_get_sta_list(&wifi_sta_list);
  tcpip_adapter_get_sta_list(&wifi_sta_list, &adapter_sta_list);
}
void printStaList()
{
  for (int i = 0; i < adapter_sta_list.num; i++) {
 
    tcpip_adapter_sta_info_t station = adapter_sta_list.sta[i];
 
    Serial.print("station no. ");
    Serial.println(i);
 
    Serial.print("MAC: ");
 
    for(int i = 0; i< 6; i++){
       Serial.print(station.mac[i],HEX);
      //Serial.printf("%02X", station.mac[i]);  
      if(i<5)Serial.print(":");
    }
 
    Serial.print("\nIP: ");  
    Serial.println(ip4addr_ntoa(&(station.ip)));    
  }
 
  Serial.println("-----------");
}
char* getCameraIp()
{
  refreshStaList();
  byte camMac[] = { 0xA4, 0xCF, 0x12, 0x9B, 0x31, 0xCC };
  char* result = "";
  for (int i = 0; i < adapter_sta_list.num; i++){
    tcpip_adapter_sta_info_t station = adapter_sta_list.sta[i];
    for(int i = 0; i< 6; i++){
      if(station.mac[i] != camMac[i])
      {
        break;
      }
      if(i == 5)
      {
        return ip4addr_ntoa(&(station.ip));
      }
    }
  }
  return result;
}
bool parseArgs(String str)
{
  if(str.startsWith("GET /?"))
  {
    int i;
    String argsStr = "";
    for(i = 5; i < str.length(); i++)
    {
      if(str[i] == ' ') break;
    }
    argsStr = str.substring(6, i);

    if(argsStr.length() > 0)
    {
      String param = "";
      String value = "";

      bool incParam = true;
      bool incValue = false;
      for(int i = 0; i < argsStr.length(); i++)
      {
        if(argsStr[i] == '=')
        {
          incParam = false;
          incValue = true;
          i++;
        }
        else if(argsStr[i] == '&')
        {
          if(value.toInt() > 180) paramArray[param.toInt()] = 180;
          else if(value.toInt() < 0) paramArray[param.toInt()] = 0;
          else paramArray[param.toInt()] = value.toInt();
          
          param = "";
          value = "";
          incParam = true;
          incValue = false;
          i++;
        }
        if(incParam)
        {
          param += argsStr[i]; 
        }
        else if(incValue)
        {
          value += argsStr[i];
        }
      }
      if(param != "" && value != "")
      {
        if(value.toInt() > 180) paramArray[param.toInt()] = 180;
        else if(value.toInt() < 0) paramArray[param.toInt()] = 0;
        else paramArray[param.toInt()] = value.toInt();
          
      }
      writeServoValue();
      return true;
    }
  }
  return false;
}

char* stringToChars(String str)
{
  char p[str.length()];
  int i; 
  for (i = 0; i < sizeof(p); i++) { 
      p[i] = str[i];  
  }
  return p;
}

void handleClient()
{
  WiFiClient client = server.available();   // listen for incoming clients
  
  if (client) {                             // if you get a client,
    //Serial.println("New Client.");           // print a message out the serial port
    String currentLine = "";                // make a String to hold incoming data from the client
    while (client.connected()) {            // loop while the client's connected
      if (client.available()) {             // if there's bytes to read from the client,
        char c = client.read();             // read a byte, then
        //Serial.write(c);                    // print it out the serial monitor
        if (c == '\n') {                    // if the byte is a newline character

          // if the current line is blank, you got two newline characters in a row.
          // that's the end of the client HTTP request, so send a response:
          //Serial.println(currentLine);
          if(parseArgs(currentLine))
          {
            
          }
          message = stringToChars(printArray());
          //printArray();
          
          if (currentLine.length() == 0) {
            // HTTP headers always start with a response code (e.g. HTTP/1.1 200 OK)
            // and a content-type so the client knows what's coming, then a blank line:
            client.println("HTTP/1.1 200 OK");
            client.println("Content-type:text/html");
            client.println();

            // the content of the HTTP response follows the header:
            //client.print("Click <a href=\"/H\">here</a> to turn ON the LED.<br>");
            //client.print("Click <a href=\"/L\">here</a> to turn OFF the LED.<br>");
            client.print(message);
            if(message != "")
            {
              Serial.println(message);
            }
            message = "";
            
            // The HTTP response ends with another blank line:
            //client.println();
            // break out of the while loop:
            break;
          } else {    // if you got a newline, then clear currentLine:
            currentLine = "";
          }
        } 
        else if (c != '\r') {  // if you got anything else but a carriage return character,
          currentLine += c;      // add it to the end of the currentLine
        }

        // Check to see if the client request was "GET /H" or "GET /L":
        /*if (currentLine.endsWith("GET /H")) {
          digitalWrite(LED_BUILTIN, HIGH);               // GET /H turns the LED on
        }
        if (currentLine.endsWith("GET /L")) {
          digitalWrite(LED_BUILTIN, LOW);                // GET /L turns the LED off
        }*/
        if (currentLine.endsWith("GET /camip")) {
          //refreshStaList();
          //printStaList();
          
          message = getCameraIp();
        }
        else if (currentLine.endsWith("GET /restartmain")) {
          ESP.restart();
        }
      }
    }
  }
}


void setup() {
  pinMode(LED_BUILTIN, OUTPUT);
  Serial.begin(115200);

  setupServoWrite();
  for(int i = 0; i < 9; i++)
  {
    pinMode(pinsArray[i], OUTPUT);
  }
  
  Serial.println();
  Serial.println("Configuring access point...");
  WiFi.softAP(ssid, password);
  IPAddress myIP = WiFi.softAPIP();
  Serial.print("AP IP address: ");
  Serial.println(myIP);
  server.begin();
  Serial.println("Server started");

}


 
void loop() {
  //refreshStaList();
  //printStaList(); 
  //delay(1000);
  handleClient();
    // close the connection:
    //client.stop();
    //Serial.println("Client Disconnected.");
  
}