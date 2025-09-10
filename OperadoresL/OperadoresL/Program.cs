// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//operadores &&, ||, !, ^

/*
bool valor1 = true;
bool valor2 = false;
bool valor3 = true;
*/

var (valor1,valor2,valor3) = (true, true , true);

//operador AND &&
bool result = valor1 && valor2 && valor3;
Console.WriteLine(result);  

//operador OR ||
bool result2 = valor1 || valor2 ||  valor3; 
Console.WriteLine(result2);

bool result3 = (valor1 && valor2) || valor3;
Console.WriteLine(result2);

//operador NOT !
bool result4 = !valor1;
Console.WriteLine(result4);

//operador XOR ^ se usa para ver si los valores son diferentes
bool result5 = valor1^valor2 ^valor3;
Console.WriteLine(result5);