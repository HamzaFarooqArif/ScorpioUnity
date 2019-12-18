#include "WiFi.h"
#include "ESPAsyncWebServer.h"
 
const char* ssid = "ZONG MBB-E5573-AE26";
const char* password =  "58688303";

char out_str[40];  

AsyncWebServer server(80);

int paramArray[10] = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
 
void setup(){
  Serial.begin(115200);
  
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
    Serial.println(paramsNr);
 
    for(int i=0;i<paramsNr;i++){
 
        AsyncWebParameter* p = request->getParam(i);
        paramArray[i] = p->value().toInt();
        Serial.print("Param index: ");
        //Serial.println(p->name());
        Serial.println(i);
        Serial.print("Param value: ");
        Serial.println(paramArray[i]);
        Serial.println("------");
    }
 
    request->send(200, "text/plain", "message received");
  });
 
  server.begin();
}
 
void loop(){}
