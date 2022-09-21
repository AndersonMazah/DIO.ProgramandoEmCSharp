using System;
using DesafioPOO.Models;


Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia(numero: "123456789", modelo: "Tijolo", imei: "001100110011", memoria: 8);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsaap");

Console.WriteLine("Smartphone Iphone:");
Iphone iphone = new Iphone(numero: "123456789", modelo: "Ouro", imei: "110011001100", memoria: 512);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");