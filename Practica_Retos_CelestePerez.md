// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");

using System.Globalization;



**//1.string.Concat() Une el nombre del personaje “Bitín” con la palabra “Explorador” y muestra el resultado.**

String todo = "";

String nombre = "Bitín";

string profesion = "Explorador";



todo = string.Concat(nombre," ", profesion,"     ");

Console.WriteLine(todo);



resultado:

Bitín Explorador



**//2.string.Join()Separa el cuento en oraciones por “.” y únelas nuevamente con el separador " | ".**

String Join1 = "caminaba por el mundo";

string Join2 = "en busca de extraños tesoros";

String Join3 = "";



Join3 = string.Join(".",Join1,Join2);

Console.WriteLine(Join3);



resultado:

caminaba por el mundo.en busca de extraños tesoros





**//3.string.Format() Muestra en consola: “El cuento tiene X caracteres y Y palabras” usando formato.**

int Ora1 = Join1.Length;

int Nom = nombre.Length;

String FormOra = "";



FormOra = string.Format("Una oración tiene {0} caracteres y el nombre {1}",Ora1,Nom);

Console.WriteLine(FormOra);



resultado: 

Una oración tiene 21 caracteres y el nombre 5



**//4.string.Interpolation ($"...") Usa interpolación para mostrar: “El protagonista es {nombre} y busca {meta}”.**

String Inter = "";



Inter = $"El protagonista se llama {nombre} y va {Join2}";

Console.WriteLine(Inter);



resultado: 

El protagonista se llama Bitín y va en busca de extraños tesoros



**//5.Convert.ToString() Convierte un número (ej. la longitud del cuento) a cadena y muéstralo concatenado con un mensaje.**

string messa = "";



messa = "El nombre del protagonista tiene " + Nom.ToString()+ " caracteres";

Console.WriteLine(messa);



resultado:

El nombre del protagonista tiene 5 caracteres



**//6.IndexOf() Encuentra la primera posición donde aparece la palabra “mundo”.**

int IndiMun = 0;



IndiMun = Join1.IndexOf("mundo");

Console.WriteLine(IndiMun);



resultado:

16



**//7.LastIndexOf() Encuentra la última vez que aparece la palabra “ceros”.**

int Nindice= 0;



Nindice = Join2.LastIndexOf("extraños");

Console.WriteLine(Nindice);



resultado:

12



**//8.Contains() verifica si el cuento menciona la palabra "Nube" y muestra un mensaje de condirmación**

String cadenaB = "";



cadenaB = "nube";

if (Join2.Contains((cadenaB)))

{

&nbsp;   Console.WriteLine("El texto 1:"+Join2+", si contiene esta palabra: "+cadenaB);

}

else

{

&nbsp;   Console.WriteLine("El texto 1:" + Join2 + ",no  contiene esta palabra: " + cadenaB );

}



resultado:

El texto 1:en busca de extraños tesoros,no  contiene esta palabra: nube



**//reto 9:StartsWith comprueba  si el cuento inicia con "En el vaso universo"** 

bool empieza = false;



empieza = Join2.StartsWith("en el vasto universo");

Console.WriteLine(empieza);



resultado:

false





**//reto 10:EndsWith comprueba si el cuento termina con "ceros y unos"** 

bool termina = false;



termina = Join2.EndsWith("ceros y unos");



resultado:

false



**//reto 11:Substring() Extrae la palabra "ciudades luminosas" del texto original.**

string extrae = "";



extrae = Join2.Substring(12);

Console.WriteLine(extrae);



resultado:

extraños tesoros



**//reto 12:Remove() Elimina los primeros 15 caracteres del cuento y muestra el resto.**

String remueve = "";



remueve = Join2.Remove(0,15);

Console.WriteLine(remueve);



respuesta:

raños tesoros



**//reto 13: Replace() Sustituye todas las apariciones de "Bitin" por "ProgramaX".**

String anade = "";



anade = nombre.Replace("Bitín","Programa X");

Console.WriteLine(anade);



respuesta:

Programa X



**//reto 14:Insert() Inserta la palabra "(IMPORTANTE)" después de la palabra "firewall".**

string Join4 = "la empresa instalo un nuevo firewall para mayor seguridad";

string insertar = "";



insertar = Join4.Insert(36, "IMPORTANTE");

Console.WriteLine(insertar);



resultado:

la empresa instalo un nuevo firewallIMPORTANTE para mayor seguridad



**//reto 15:PadLeft() Rellena la palabra "Bitin" a la izquierda con '\*' hasta tener 10 caracteres.**

String reuMas = "";



reuMas = nombre.PadLeft(10, '\*');

Console.WriteLine(reuMas);



respuesta: 

\*\*\*\*\*Bitín



**//reto 16:PadRight() Rellena la palabra "Nube" a la derecha con '-' hasta tener 12 caracteres.**

String n2 = "nube";

string inserI = "";



inserI = n2.PadRight(12, '-');

Console.WriteLine(inserI);



respuestas:

nube--------



**//reto 17: Trim() Toma un fragmento con espacios extras (" firewall ") y elimina los espacios.**

String texto1 = "   firewall   ";

string texto2 = "";



texto2 = texto1.Trim();

Console.WriteLine(texto2);



resultado:

firewall



**//reto 18: TrimStart() Elimina solo los espacios iniciales de la frase " Mundo binario"**

String texto3 = " Mundo Binario";

string texto4 = "";



texto4 = texto3.TrimStart();

Console.WriteLine(texto4);



respuestas:

Mundo Binario



**//reto 19: TrimEnd() Elimina solo los espacios finales de la frase "Bitin explorador ".**

string texto5 = "";



texto5 = todo.TrimEnd();

Console.WriteLine(texto5);



resultado:

Bitín Explorador



**//reto 20:Split() Divide el cuento en palabras individuales y muestra las primeras 10.**

string\[] palabra;

char\[] delim = { ' ' };



palabra = Join2.Split(delim);

Console.WriteLine(string.Join(',', palabra));



resultados:

en,busca,de,extraños,tesoros



**//reto 21:Equals()Compara si "Nube" y "nube" son iguales (sensible a mayúsculas/minúsculas).**

String n3 = "nuVe";

bool igual = false;



igual = n2.Equals(n3);

Console.WriteLine(igual);



respuesta:

false



**//reto 22:Compare() Compara alfabéticamente "Bitin" y "Firewall" e indica cuál va primero.**

int compara = 0;

string compara1 = "firewall";



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

&nbsp;Console.WriteLine($"{nombre} y {compara1} son iguales");

}



respuesta:

Bitín va antes que firewall



**//reto 23:CompareTo() Aplica CompareTo() entre "Nube" y "Cielo" y explica el resultado numérico.**

int compara2 = 0;

String texto6 = "Cielo";



compara2 = n2.CompareTo(texto6);



if (compara2 < 0)

{

&nbsp;   Console.WriteLine(compara2+$"   : < 0 si cadena va antes que cadena");

}

else if(compara2 > 0)

{

&nbsp;   Console.WriteLine(compara2 + $" : > 0 si cadena 1 va después que cadena 2");

}

else

{

&nbsp;   Console.WriteLine(compara2 + $" : si son iguales");

}



resultado:

1 : > 0 si cadena 1 va después que cadena 2



**//treto 24:IsNullOrEmpty() Declara una cadena vacía y verifica si lo es.**

string vacio = null;



if (string.IsNullOrEmpty(vacio))

{

&nbsp;   Console.WriteLine("la cadena esta vacia");

}

else

{

&nbsp;   Console.WriteLine("la cadena no esta vacia");

}



respuesta:

la cadena esta vacia



**//reto 25:IsNullOrWhiteSpace() Declara una cadena con solo espacios y valida el resultado.**

string vacio2 = "     ";

bool esvacio2 = false;



esvacio2 = string.IsNullOrWhiteSpace(vacio2);

Console.WriteLine(esvacio2);



respuesta:

true



**//reto 26: ToLower() Convierte todo el cuento a minúsculas.**

string minu = "";



minu = nombre.ToLower();

Console.WriteLine(minu);



respuesta:

bitín



**//reto 27: ToUpper() Convierte todo el cuento a mayúsculas.**

string mayu = "";



mayu = nombre.ToUpper();

Console.WriteLine(mayu);



BITÍN



**//reto 28: ToLowerInvariant()Convierte la palabra "NUBE" a minúsculas con ToLowerInvariant().**

string minuI = "";



minuI = nombre.ToLowerInvariant();

Console.WriteLine(minuI);



bitín



**//reto 29: ToUpperInvariant()Convierte la palabra "bitín" a mayúsculas con ToUpperInvariant().**

string mayuI = "";



mayuI = nombre.ToUpperInvariant();

Console.WriteLine(mayuI);



respuestas:

BITÍN

