// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*
Blackjack, se juntan 21 pidiendo cartas o en caso de tener menos
de 21 igual tener mayor puntuación que el dealer
*/

int totalJ = 25;
int totalD = 15;
String message = "";
//USO DE IF, ELSE Y ELSE IF
//Implementación de operadores

if(totalJ > totalD && totalJ < 22)
{
    message = "Venciste al dealer, felicidades";
}
else if (totalJ >= 22)
{
    message = "Perdiste vs el dealer,te pasaste de 21 ";
}
else if (totalJ <= totalD)
{
    message = "Perdiste vs el dealer, lo siento";
}
else {
    message = "Condición no válida";
}
Console.WriteLine(message);