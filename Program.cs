using DesafioPOO.Models;

// Testes realizados!!!
Console.WriteLine("Testando Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "011958180540", modelo: "Modelo X30", imei: "IMEI: 35 361265 724865 9", memoria: 126);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
nokia.MensagemDeTexto();

Console.WriteLine("\n");

Console.WriteLine("Testando Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "011988719121", modelo: "Modelo 8 Plus", imei:"IMEI 35 297452 852746 1", memoria: 512);
iphone.Ligar();
iphone.InstalarAplicativo("Facebook");
iphone.ReceberLigacao();