//Incluimos primero las librerías instaladas/
#include "DHT.h"
#include "LiquidCrystal.h"

#include "AsyncUDP.h"
#include "WiFi.h"

//Definimos que el Pin de Datos del sensor estará conectado al pin 23 del ESP32/
#define DHTPIN 23           
//Definimos que el tipo de sensor que estamos utilizando es un DHT11/
#define DHTTYPE DHT11     // DHT 11
//Se actualizan algunos parámetros del DHT11 con los puntos definidos anteriormente/ 
DHT dht(DHTPIN, DHTTYPE);



//Definimos las variables que se medirán y que serán publicadas en la plataforma Ubidots/
const char *VARIABLE_LABEL_1 = "temperatura"; 
const char *VARIABLE_LABEL_2 = "humedad"; 
const char *VARIABLE_LABEL_3 = "luz"; 
//Definimos la frecuencia de publicación de 5 segundos/
const int PUBLISH_FREQUENCY = 5000; 
//Definimos unas variables extra, que incluye la librería/
unsigned long timer;
uint8_t analogPin = 34; 

char salida_PIN33 = 0;
LiquidCrystal lcd(22,21,19,18,17,16);

//Variables para fotorresistenica
int LDR = 33;
int VALOR;


// WiFi card example
const char *ssid = "pabloh";      
const char *pass = "Trucopablo11";         // your SSID Password

IPAddress client_address (192,168,188,172);  
int udpPort = 2000;
String received_message;

AsyncUDP udp;

void initWiFi(){
  WiFi.mode(WIFI_STA);
  WiFi.config(INADDR_NONE, INADDR_NONE, INADDR_NONE, INADDR_NONE);
  //WiFi.setHostname(hostname.c_str());
  WiFi.begin(ssid,pass);
  Serial.print("Connecting to WiFi ...");
  while (WiFi.status() != WL_CONNECTED){
    Serial.print('.');
    delay(1000);
  }
  Serial.println("Wifi.localIP: ");
  Serial.println(WiFi.localIP());
}



//Definimos la función Setup() para iniciar nuestro circuito/
void setup()
{
  delay(5000);
  //Iniciamos el terminal Serial a 115200/
  Serial.begin(115200);     
  //Imprimimos el siguiente texto para asegurar el encendido del circuito/
  Serial.println("Medición inciada");
  Serial.println("DHT11 Encendido");
  //Iniciamos nuestro sensor DHT11/
  dht.begin();

  pinMode(32,OUTPUT); //Buzzer
  pinMode(25,OUTPUT); //Peltier //posiblemente usamos el pin 30 par revevador
  pinMode(26,OUTPUT); //Ventilador
  lcd.begin(20, 4);
  pinMode(LDR, INPUT); //Fotorresistencia

  delay(3000);
  initWiFi();
  WiFi.setSleep(false);

  // put your setup code here, to run once:
  udp.connect(client_address, udpPort);
  Serial.println("Connected es: ");
  Serial.println(udp.connected());
  Serial.println("");
  Serial.println("");
}

/*Iniciamos el bucle de la función Loop()*/
void loop()
{
    int h = dht.readHumidity();
    int t = dht.readTemperature();
    VALOR = analogRead(LDR);

    Serial.print("El nivel de Luz es: ");
    Serial.println(VALOR);
    Serial.println("Temperatura: " + String(t));
    Serial.println("Humedad: " + String(h));
    Serial.println("-----------------------------------------");
  

   if(VALOR != 0){
    salida_PIN33 =! salida_PIN33;
    digitalWrite(32,LOW);
    digitalWrite(25,LOW);
    digitalWrite(26,LOW);

    }
    else{
      digitalWrite(32,LOW);
      digitalWrite(32,HIGH);
      digitalWrite(25,HIGH);
      digitalWrite(26,HIGH);
    }
 


//Pantalla
  lcd.clear();
   //Nos posicionamos en la posiciocion 0,0 del display
  lcd.setCursor(0, 0);
  //Escribimos la palabra
  lcd.print("Temperatura: ");
  String myString = "";      // empty string
  myString.concat(t);
  lcd.print(myString);
  lcd.print((char)223);
  lcd.print("C");
  
  //Nos posicionamos en la posiciocion 0,1 del display
  lcd.setCursor(0, 1);
  //Escribimos la palabra 
  lcd.print("Humedad: ");
  myString = "";      // empty string
  myString.concat(h);
  lcd.print(myString);
  lcd.print("%");

  //Nos posicionamos en 0,2
  lcd.setCursor(0,2);
  lcd.print("Nivel de luz: ");
  myString = "";
  myString.concat(VALOR);
  lcd.print(myString);

  //Movemos el texto de derecha a izquierda
  //lcd.scrollDisplayLeft(); 

  //------------------------------------------------------------------------------------
  int modulo;
  uint8_t dato;

  delay(500);
  udp.write('T');
  

  //Temperatura---------------
  delay(500);
  modulo = t % 10;
  t = t /10;
  udp.write(modulo + 48);

  delay(500);
  modulo = t % 10;
  t = t /10;
  udp.write(modulo + 48);

  //Humedad-------------------
  delay(500);
  udp.write('H');
  

  delay(500);
  modulo = h % 10;
  h = h /10;
  udp.write(modulo + 48);

  delay(500);
  modulo = h % 10;
  h = h /10;
  udp.write(modulo + 48);


  //Luz
  delay(500);
  udp.write('L');

  delay(500);
  if(VALOR > 0){
    udp.write('1');
  }else{
    udp.write('0');
  }

  delay(500);
  udp.write('0');


  //Agregamos un delay de 10 segundos para el envío, y que luego de este tiempo, se proceda a reiniciar el bucle/
  delay(5000); 
}