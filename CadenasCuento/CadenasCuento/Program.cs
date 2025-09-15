// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//1.
using System.Globalization;
String todo = "";
String nombre = "Bitín";
string profesion = "Explorador";

//2.
String Join1 = "caminaba por el mundo";
string Join2 = "en busca de extraños tesoros";
String Join3 = "";

//3.
int Ora1 = Join1.Length;
int Nom = nombre.Length;
String FormOra = "";

//4.
String Inter = "";

//5.
string messa = "";

//6.
int IndiMun = 0;

//7.
int Nindice= 0;

//8.
String cadenaB = "";

//reto 9:
bool empieza = false;

//reto 10:
bool termina = false;

//reto 11:
string extrae = "";

//reto 12:
String remueve = "";

//reto 13:
String anade = "";

//reto 14:
string Join4 = "la empresa instalo un nuevo firewall para mayor seguridad";
string insertar = "";

//reto 15:
String reuMas = "";

//reto 16:
String n2 = "nube";
string inserI = "";

//reto 17:
String texto1 = "   firewall   ";
string texto2 = "";

//reto 18:
String texto3 = " Mundo Binario";
string texto4 = "";

//reto 19:
string texto5 = "";

//reto 20:
string[] palabra;
char[] delim = { ' ' };

//reto 21:
String n3 = "nuVe";
bool igual = false;

//reto 22:
int compara = 0;
string compara1 = "firewall";

//reto 23:
int compara2 = 0;
String texto6 = "Cielo";

//treto 24:
string vacio = null;

//reto 25:
string vacio2 = "     ";
bool esvacio2 = false;

//reto 26:
string minu = "";

//reto 27:
string mayu = "";

//reto 28:
string minuI = "";

//reto 29:
string mayuI = "";

//reto 1:
todo = string.Concat(nombre," ", profesion,"     ");
Console.WriteLine(todo);

//reto 2:
Join3 = string.Join(".",Join1,Join2);
Console.WriteLine(Join3);

//reto 3:
FormOra = string.Format("Una oración tiene {0} caracteres y el nombre {1}",Ora1,Nom);
Console.WriteLine(FormOra);

//reto 4:
Inter = $"El protagonista se llama {nombre} y va {Join2}";
Console.WriteLine(Inter);

//reto 5:
messa = "El nombre del protagonista tiene " + Nom.ToString()+ " caracteres";
Console.WriteLine(messa);

//reto 6:
IndiMun = Join1.IndexOf("mundo");
Console.WriteLine(IndiMun);

//reto 7:
Nindice = Join2.LastIndexOf("extraños");
Console.WriteLine(Nindice);

//reto 8:
cadenaB = "nube";
if (Join2.Contains((cadenaB)))
{
    Console.WriteLine("El texto 1:"+Join2+", si contiene esta palabra: "+cadenaB);
}
else
{
    Console.WriteLine("El texto 1:" + Join2 + ",no  contiene esta palabra: " + cadenaB );
}

//reto 9: 
empieza = Join2.StartsWith("en el vasto universo");
Console.WriteLine(empieza);

//reto 10:
termina = Join2.EndsWith("ceros y unos");
Console.WriteLine(termina);
Console.WriteLine("AQUIIII");

//reto 11:
extrae = Join2.Substring(12);
Console.WriteLine(extrae);

//reto 12:
remueve = Join2.Remove(0,15);
Console.WriteLine(remueve);

//reto 13:
anade = nombre.Replace("Bitín","Programa X");
Console.WriteLine(anade);

//reto 14:
insertar = Join4.Insert(36, "IMPORTANTE");
Console.WriteLine(insertar);

//reto 15:
reuMas = nombre.PadLeft(10, '*');
Console.WriteLine(reuMas);

//reto 16:
inserI = n2.PadRight(12, '-');
Console.WriteLine(inserI);

//reto 17:
texto2 = texto1.Trim();
Console.WriteLine(texto2);

//reto 18:
texto4 = texto3.TrimStart();
Console.WriteLine(texto4);

//reto 19:
texto5 = todo.TrimEnd();
Console.WriteLine(texto5);

//reto 20:
palabra = Join2.Split(delim);
Console.WriteLine(string.Join(',', palabra));

//reto 21:
igual = n2.Equals(n3);
Console.WriteLine(igual);

//reto 22:
/*si es 0 las cadenas tienen igual nivel de jerarquia alfabeticamente
 * si es < 0 la cadena1 va antes de la cadena 2
 * si > 0 la cadena 1 va despues de cadena
*/

compara = String.Compare(nombre, compara1);
if (compara < 0)
{
Console.WriteLine($"{nombre} va antes que {compara1}");
}
else if (compara > 0)
{
Console.WriteLine($"{compara1} va antes que {nombre}");
}
else
{
 Console.WriteLine($"{nombre} y {compara1} son iguales");
}

//reto 23:
compara2 = n2.CompareTo(texto6);

if (compara2 < 0)
{
    Console.WriteLine(compara2+$"   : < 0 si cadena va antes que cadena");
}
else if(compara2 > 0)
{
    Console.WriteLine(compara2 + $" : > 0 si cadena 1 va después que cadena 2");
}
else
{
    Console.WriteLine(compara2 + $" : si son iguales");
}

//reto 24
if (string.IsNullOrEmpty(vacio))
{
    Console.WriteLine("la cadena esta vacia");
}
else
{
    Console.WriteLine("la cadena no esta vacia");
}

//reto 25:
esvacio2 = string.IsNullOrWhiteSpace(vacio2);
Console.WriteLine(esvacio2);

//reto 26:
minu = nombre.ToLower();
Console.WriteLine(minu);

//reto 27:
mayu = nombre.ToUpper();
Console.WriteLine(mayu);

//reto 28:
minuI = nombre.ToLowerInvariant();
Console.WriteLine(minuI);

//reto 29:
mayuI = nombre.ToUpperInvariant();
Console.WriteLine(mayuI);