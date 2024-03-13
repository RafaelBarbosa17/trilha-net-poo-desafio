using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "31982844409", modelo: "n-10", imei: "44224422", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "31981024183", modelo: "14 pro max", imei: "22172217", memoria: 128);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");