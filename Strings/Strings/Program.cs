// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.WriteLine("Ricardo Pérez ID: ");
int altura = 168;
int edad = 89;
String nombre = "Ricardo Pérez";
String infor = "Nació en Hidalgo, es estudiante de gastronomía y astronomía";
var hobby = "deportista";

String tarjetaID =  $"La información de {nombre} es la siguiente, "+ 
    $"\n su edad es {edad} \n"+
    $" su altura es de {altura} cm \n  información relevante {infor} \n además, " +
    $"su hobby es de: {hobby}";

Console.WriteLine(tarjetaID);