using DesafioPOO.Models;

Smartphone nokia = new Nokia("123456789", "Nokia Model", "IMEI123", 64);
Smartphone iphone = new Iphone("987654321", "iPhone Model", "IMEI456", 128);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");