using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone iPhone:");
Smartphone iPhone = new Iphone(numero: "1234", modelo: "iPhone SE", imei: "654231", memoria: 128 );
iPhone.Ligar();
iPhone.InstalarAplicativo("YouTube");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "46512", modelo: "Nokia Tijolo", imei: "56423", memoria: 4);
nokia.Ligar();
nokia.InstalarAplicativo("Jogo da cobrinha");