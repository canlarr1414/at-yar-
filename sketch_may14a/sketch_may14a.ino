#define trigPin 7
#define echoPin 8


const int sol_ileri = 2;

const int sol_geri = 3;

const int sag_ileri = 4;

const int sag_geri = 5;

long sure, mesafe;
// motor sürücünün 2,7,10 ve 15 nolu inputlarına dataship gönderebilmek için değişkenler tanımlandı.


void setup() {
Serial.begin(9600);
pinMode(trigPin,OUTPUT);
pinMode(echoPin,INPUT);
pinMode(sol_ileri,OUTPUT);
pinMode(sol_geri,OUTPUT);

pinMode(sag_ileri,OUTPUT);
pinMode(sag_geri,OUTPUT);
}
void loop() {
 digitalWrite(trigPin , HIGH);
delayMicroseconds(1000);
digitalWrite(trigPin , LOW);
sure = pulseIn(echoPin,HIGH);
mesafe = (sure/2) / 28.5;   //sensöreden gelen mesafe bilgisini elde etmek için, sensöre gerekli kodlar yazıldı.
Serial.println(mesafe);  //mesafe bilgisini ekrana yazdırmak için kod.
delay(500);   //değerlerin  hızlı akmaması için 500 ms’lik bir bekleme süresi belirledik.
if (mesafe < 40)
{
   digitalWrite(sol_ileri,1);//geri gitme
   digitalWrite(sol_geri,0);
   digitalWrite(sag_ileri,1);
   digitalWrite(sag_geri,0);
   delay(1000);
   digitalWrite(sol_ileri,1);//sola gitme
   digitalWrite(sol_geri,0);
   digitalWrite(sag_ileri,0);
   digitalWrite(sag_geri,1);


}
if (mesafe < 40)
{
digitalWrite(sol_ileri,1);
digitalWrite(sol_geri,0);
digitalWrite(sag_ileri,0);
digitalWrite(sag_geri,1);   //tek sensör kullandığımız için ve sensör robotun önünde olduğu için,robot engele 30 cm ‘den fazla yaklaştığında robotun sağa dönmesini istedik.Bunun için gerekli kodlar yazıldı.
}
//if (mesafe < 40)
//{
  // digitalWrite(sol_ileri,1);
   //digitalWrite(sol_geri,0);
   //digitalWrite(sag_ileri,0);
   //digitalWrite(sag_geri,1); //sol tarafa dönmesi için yazılan kodlar
 
//}
else
{
   digitalWrite(sol_ileri,0);
   digitalWrite(sol_geri,1);
   digitalWrite(sag_ileri,0);
   digitalWrite(sag_geri,1);  //sensör herhangi bir engelle karşılaşmadığında düz devam etmesi için gerekli kodlar yazıldı.
}
}