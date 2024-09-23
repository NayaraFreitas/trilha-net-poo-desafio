using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia :");
Smartphone nokiaG60 = new Nokia(numero:"454645646",modelo:"G60",imei:"1984548943", memoria:128);
nokiaG60.Ligar();
nokiaG60.InstalarAplicativo("Telegram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone :");
Smartphone iphone14 = new Iphone(numero:"2020202020",modelo:"14 pro", imei:"1984548943",memoria:254);
iphone14.ReceberLigacao();
iphone14.InstalarAplicativo("Photoshop");