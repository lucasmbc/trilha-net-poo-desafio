using DesafioPOO.Models;

Console.WriteLine("Smartfone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "11111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("Smartfone Iphone:");
Smartphone iphone = new Iphone(numero: "9999999", modelo: "Iphone 15", imei: "11111111", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");