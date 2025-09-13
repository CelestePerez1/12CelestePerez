// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*
Blackjack, se juntan 21 pidiendo cartas o en caso de tener menos
de 21 igual tener mayor puntuación que el dealer
*/

int totalJ = 25;
int totalD = 15;
String message = "";
String switchC = "21";
//USO Switch
//Implementación de default

switch (switchC)
{
    case "menu":
        Console.WriteLine("Bienvenido al  c a s i n o");
        Console.WriteLine("Escriba '21' para jugar al 21");
        switchC = Console.ReadLine();
        break;

    case "21":

        if (totalJ > totalD && totalJ < 22)
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
        else
        {
            message = "Condición no válida";
        }
        Console.WriteLine(message);
        break;
        default:
        Console.WriteLine("Valor ingresado no válido en el C A S I N O");
        break;
}


       


