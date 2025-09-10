// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Operaciones Relacionales ==, !=, <, >, >=, <=

var (valor1, valor2, valor3) = (10, 10, 2);
Console.WriteLine("Los valores son:  " + valor1 + valor2 + valor3);

//Operador == igual que
bool res1 = valor1 == valor2;
Console.WriteLine("El resultado de la comparación del valor1 y valor2: "+res1);

//Operador != diferente de
bool res2 = valor1 != valor2;
Console.WriteLine("El resultado de la comparación del valor1 != valor2: " + res2);

//Operadores de <,>
bool res3 = valor1 > valor2;
Console.WriteLine("El resultado de comparacion valor1 > valor2: "+ res3);

bool res4 = valor1 < valor2;
Console.WriteLine("El resultado de comparacion valor1 < valor2: " + res4);

bool res5 = valor1 >= valor2;
Console.WriteLine("El resultado de comparacion valor1 >= valor2: " + res5);

bool res6 = valor1 <= valor2;
Console.WriteLine("El resultado de comparacion valor1 <= valor2: " + res6);