#include <Arduino.h>
#include <painlessMesh.h>
#include <PubSubClient.h>
#include <ESP8266WiFi.h>

#define   MESH_PREFIX     "MeshNet" // pas aan
#define   MESH_PASSWORD   "87654321" // pas aan
#define   MESH_PORT       5555 // mag een andere port zijn, maar 5555 is standaard voor Mesh netwerken
#define   BATT_MAX_V 12.0

#define ssid "FredNet" // SSID name
#define password "12345678" // SSID_Password

const int mqttPort = 1883; // 1883 is de default MQTT poort

const char* mqttUser = "Jeff"; // de gebruikersnaam van uw verzender, in dit voorbeeld is dit Jeff
const char* mqttPassword = "123"; // het wachtwoord dat hoort bij de gebruiker, in dit geval 123

const char* clientID =  "MESHSERVER";// MQTT client ID - Hiermee weet de MQTT Broker wie een bericht stuurt.

// Prototypes
void receivedCallback( const uint32_t &from, const String &msg );
void mqttCallback(char* topic, byte* payload, unsigned int length);

IPAddress getlocalIP();

IPAddress myIP(0,0,0,0);
IPAddress mqttBroker(192, 168, 37, 1); // het IP adres van je MQTT broker

painlessMesh  mesh;
WiFiClient wifiClient;
PubSubClient mqttClient(mqttBroker, mqttPort, mqttCallback, wifiClient);

void setup() {
  Serial.begin(115200);

  mesh.setDebugMsgTypes( ERROR | STARTUP | CONNECTION );  // set before init() so that you can see startup messages
  mesh.init( MESH_PREFIX, MESH_PASSWORD, MESH_PORT, WIFI_AP_STA);
  mesh.onReceive(&receivedCallback);

  WiFi.begin(ssid,password);
  mesh.stationManual(ssid, password);
  mesh.setHostname(clientID);

  // Bridge node, should (in most cases) be a root node. See [the wiki](https://gitlab.com/painlessMesh/painlessMesh/wikis/Possible-challenges-in-mesh-formation) for some background
  mesh.setRoot(true);
  // This node and all other nodes should ideally know the mesh contains a root, so call this on all nodes
  mesh.setContainsRoot(true);
}

void loop() {
  mesh.update();
  mqttClient.loop();
  if (myIP != getlocalIP()) {
    myIP = getlocalIP();
    Serial.println("My IP is " + myIP.toString());
    if (mqttClient.connect(clientID, mqttUser, mqttPassword)) {
      mqttClient.publish("painlessMesh/from/gateway", "Ready!");
      mqttClient.subscribe("painlessMesh/to/#");
    }
  } 
}

void receivedCallback( const uint32_t &from, const String &msg ) {
  Serial.printf("bridge: Received from %u msg=%s\n", from, msg.c_str());
  String topic = "painlessMesh/from/" + String(from);
  mqttClient.publish(topic.c_str(), msg.c_str());
  mesh.sendSingle(from, "I am Master");
}

void mqttCallback(char* topic, uint8_t* payload, unsigned int length) {
  char* cleanPayload = (char*)malloc(length + 1);
  memcpy(cleanPayload, payload, length);
  cleanPayload[length] = '\0';
  String msg = String(cleanPayload);
  free(cleanPayload);

  String targetStr = String(topic).substring(16);

  if (targetStr == "gateway")
  {
    if (msg == "getNodes")
    {
      auto nodes = mesh.getNodeList(true);
      String str;
      for (auto && id : nodes)
        str += String(id) + String(" ");
      mqttClient.publish("painlessMesh/from/gateway", str.c_str());
    }
    if (msg == "getMyPub")
    {
      String mes= String(mesh.getNodeId());
       mqttClient.publish("painlessMesh/from/gateway", &mes[0]);
    }
  }
  else if (targetStr == "broadcast")
  {
    mesh.sendBroadcast(msg);
  }
  else
  {
    uint32_t target = strtoul(targetStr.c_str(), NULL, 10);
    if (mesh.isConnected(target))
    {
      mesh.sendSingle(target, msg);
    }
    else
    {
      mqttClient.publish("painlessMesh/from/gateway", "Client not connected!");
    }
  }
}

IPAddress getlocalIP() {
  return IPAddress(mesh.getStationIP());
}
