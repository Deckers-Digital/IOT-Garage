#include "painlessMesh.h"

// MESH Details
#define   MESH_PREFIX     "MeshNet" //name for your MESH
#define   MESH_PASSWORD   "87654321" //password for your MESH
#define   MESH_PORT       5555 //default port

uint32_t masterId;

Scheduler userScheduler; // to control your personal task
painlessMesh  mesh;

void sendMessage (uint32_t Master = 0) {
  float value = analogRead(A0)*100/1024;
  String msg="mac:";
  msg.concat(mesh.getNodeId());
  msg.concat(",percentage:");
  msg.concat(String(value,0));
  if (Master == 0) {
    mesh.sendBroadcast(msg);
  } else {
    mesh.sendSingle(Master, msg);
  }
}

void receivedCallback( const uint32_t &from, const String &msg) {
  if (msg == "I am Master") {
    masterId = from;
    return;
  }
  if (masterId == from) {
    sendMessage(masterId);
  }
  Serial.printf("Received from %u msg=%s\n", from, msg.c_str());
}

void newConnectionCallback(uint32_t nodeId) {
  sendMessage();
  Serial.printf("New Connection, nodeId = %u\n", nodeId);
}

void changedConnectionCallback() {
  Serial.printf("Changed connections\n");
}

void nodeTimeAdjustedCallback(int32_t offset) {
  Serial.printf("Adjusted time %u. Offset = %d\n", mesh.getNodeTime(), offset);
}

void setup() {
  Serial.begin(115200);
  mesh.setDebugMsgTypes( ERROR | STARTUP );  // set before init() so that you can see startup messages

  mesh.init( MESH_PREFIX, MESH_PASSWORD, &userScheduler, MESH_PORT );
  mesh.onReceive(&receivedCallback);
  mesh.onNewConnection(&newConnectionCallback);
  mesh.onChangedConnections(&changedConnectionCallback);
  mesh.onNodeTimeAdjusted(&nodeTimeAdjustedCallback);
}

void loop() {
  mesh.update();
}
