// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.WriteLine("Bienvenido Calculemos circulos");
//Formula para el calculo Pi*radio*radio


var radio = 0d;
var resultado = 0d;

//const double Pi = 3.14;

//tambien puede declarar asi:
//var radio = 1.1;
//var resultado = 1.1;

Console.WriteLine("Ingrese el valor del radio");
radio = Convert.ToDouble(Console.ReadLine());

//Para Pi podemos usar la libreria de Math o hacer una constante
resultado = Math.PI * radio * radio;

Console.WriteLine("El area de tu circulo es:  " + resultado);