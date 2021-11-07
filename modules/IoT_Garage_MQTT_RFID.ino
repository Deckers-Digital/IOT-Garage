#include <ESP8266WiFi.h>
#include <PubSubClient.h>
#include <SPI.h>
#include <MFRC522.h>
#include <WiFiClientSecure.h>

#define SS_PIN 15
#define RST_PIN 0

const char* ssid = "FredNet"; // de naam van uw draadloos netwerk
const char* password = "12345678" ;// het wachtwoord van uw draadloos netwerk
const char* mqttServer = "192.168.37.1"; // het IP adres van uw MQTT-Broker (het IP adres van uw Raspberry Pi)
const int mqttPort = 1883; // 1883 is de default MQTT poort
const char* mqttUser = "Jeff"; // Dit is de gebruikernaam van de MQTT zender/gebruiker
const char* mqttPassword = "123"; // Dit is het wachtwoord voor de MQTT gebruiker
String clientID2 = "RFID " + WiFi.macAddress(); // om de adressen van de MQTT servers uniek te houden maken wij gebruik van hun MAC adressen
const char* clientID =  &clientID2[0];// MQTT client ID - Hiermee weet de MQTT Broker wie een bericht stuurt.

void callback(char* topic, byte* payload, unsigned int length) {
  for (byte i = 0; i < 4; i++) {
    nuidPICC[i] = 0;
  }
}

WiFiClient espClient;
PubSubClient client(mqttServer, mqttPort, callback, espClient);

MFRC522 rfid(SS_PIN, RST_PIN); // Instance of the class
byte nuidPICC[4];

String card_String() {
  String content = " ";
  byte letter;
  for (byte i = 0; i < rfid.uid.size; i++) {
    Serial.print(rfid.uid.uidByte[i] < 0x10 ? "0" : "");
    Serial.print(rfid.uid.uidByte[i], HEX);
    content.concat(String(rfid.uid.uidByte[i] < 0x10 ? "0" : ""));
    content.concat(String(rfid.uid.uidByte[i], HEX));
  }
  for (byte i = 0; i < 4; i++) {
    nuidPICC[i] = rfid.uid.uidByte[i];
  }
  return content;
}

void setup() {
  Serial.begin(115200);
  WiFi.begin(ssid, password);
  while (WiFi.status() != WL_CONNECTED) {
    delay(500);
    Serial.println("Connecting to WiFi..");
  }
  Serial.println("Connected to the WiFi network");
  SPI.begin(); // Init SPI bus
  rfid.PCD_Init(); // Init MFRC522
  for (byte i = 0; i < 4; i++) {
    nuidPICC[i] = 0;
  }
}

void loop() {
  while (!client.connected()) {
    Serial.println("Connecting to MQTT...");
    if (client.connect(clientID , mqttUser, mqttPassword )) {
      Serial.println("connected");
      client.subscribe("RFID/read");
    } else {
      Serial.print("failed with state ");
      Serial.print(client.state());
      delay(2000);
    }
  }
  client.loop(); 
  if ( ! rfid.PICC_IsNewCardPresent())
    return;
  if ( ! rfid.PICC_ReadCardSerial())
    return;
  if (rfid.uid.uidByte[0] != nuidPICC[0] ||
      rfid.uid.uidByte[1] != nuidPICC[1] ||
      rfid.uid.uidByte[2] != nuidPICC[2] ||
      rfid.uid.uidByte[3] != nuidPICC[3] ) {
    String card_str = card_String();
    client.publish("RFID", card_str.c_str());
  } else {
    return;
  }
  delay(100);
  client.disconnect();
  delay(250);
}
