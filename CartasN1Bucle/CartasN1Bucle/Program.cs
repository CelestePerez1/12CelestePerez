// See https://aka.ms/new-console-template for more information

/*
Blackjack, se juntan 21 pidiendo cartas o en caso de tener menos
de 21 igual tener mayor puntuación que el dealer
*/
System.Random random = new System.Random();
int totalJ = 0;
int totalD = 0;
int num = 0;
String message = "";
String switchC = "menu";

string controlOtraCarta = "";
//USO el bucle WHILE, DO WHILE
//Implementación de default

while (true)
{
    totalD = 0;
    totalJ = 0;
    switch (switchC)
    {
        case "menu":
            Console.WriteLine("Bienvenido al  c a s i n o");
            Console.WriteLine("Escriba '21' para jugar al 21");
            switchC = Console.ReadLine();
            break;

        case "21":
            do
            {

                num = random.Next(1, 12);
                totalJ = totalJ + num;
                Console.WriteLine("Toma tu carta, jugador");
                Console.WriteLine("Te salió el: " + num);
                Console.WriteLine("¿Deseas otra carta ?");
                controlOtraCarta = Console.ReadLine();


            } while (controlOtraCarta == "Si" || controlOtraCarta == "si" || controlOtraCarta == "yes");

            totalD = random.Next(12, 23);
            Console.WriteLine($"El dealer tiene {totalD}  !");
            if (totalJ > totalD && totalJ < 22)
            {
                message = "Venciste al dealer, felicidades";
                switchC = "menu";
            }
            else if (totalJ >= 22)
            {
                message = "Perdiste vs el dealer,te pasaste de 21 ";
                switchC = "menu";
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
}
