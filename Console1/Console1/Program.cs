// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//Programa que calcula el área de un rectángulo
//Si se usa var  seria
var ladoA = 1.1;
var ladoB = 1.1;
var Rec = 1.1;
//int ladoA;
//int ladoB;
//int Rec;

Console.WriteLine("Calcula el área de un rectángulo");
Console.WriteLine("Ingrese el lado A:");
ladoA = Convert.ToDouble(Console.ReadLine());
//ladoA = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Ingrese el lado B: ");
ladoB = Convert.ToInt32(Console.ReadLine());

Rec = ladoA * ladoB;
Console.WriteLine("El área del rectángulo es: " + Rec);