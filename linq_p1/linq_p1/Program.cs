// See https://aka.ms/new-console-template for more information
using linq_p1;
using static System.Reflection.Metadata.BlobBuilder;

LinqQueries queries = new LinqQueries();

//Toda la colleción:
//ImprimirValores(queries.TodaColletion());

//Libros despues del 2000
//ImprimirValores(queries.LibrosDespuesdel2000());

//Libros que tienen mas de 250 páginas y tienen en el titulo la palabra "in action"
//ImprimirValores(queries.LibrosConMas250PagConPalabrasInAction());

//Todos los libros tienen Status
//Console.WriteLine($"Todos los libros tienen status: - {queries.TodosLibrosTienenStatus()}");

//Si algun libro fue publicado en 2005
// Console.WriteLine($"Algun libro fue publicado en 2005?: - {queries.SiAlgunLibroPUblicado2005()}");

//Libros de Python
//ImprimirValores(queries.LibrosPython());

//Libros de Java
//ImprimirValores(queries.LibrosJavaPorNombreAscendente());

//Libros que tienen mas de 450 paginas ordenas por cantidad de página
//ImprimirValores(queries.Librosmas450pagOrdenadosPorNumPagDescendente());

//3 primero libros de java  publicados  recientemente
//ImprimirValores(queries.TresPrimerosLibrosOrdenadosPorFecha());

//Tercer y cuarto libro de mas de 400 páginas
//ImprimirValores(queries.TercerCuartoLibroDeMas499Pag());

//Tres primeros libros filtrados por select
//ImprimirValores(queries.TresPrimerosLIbrosCollection());



//Videos 17 al 26 

//Libros que contienen en entre 200 y 500 paginas.
//Console.WriteLine($"La cantidad de libros que tienen entre 200 y 500 paginas es: {queries.Librosentre200_500pag()}");

//Fecha de la menor publicación de un libro
//Console.WriteLine($"Fecha de la publicacion antiguo: { queries.FechaMenor()}");

//Paginas del libro con la mayor cantidad
//Console.WriteLine($"La cantidad de paginas del libro con mas de estas es: {queries.Libromasgrande()} paginas");

//Paginas del libro con menos paginas
Book LibMin = queries.Libroconpocaspaginas();
//Console.WriteLine($"El libro con el menor numero de paginas es : {LibMin.Title}  y tiene {LibMin.PageCount} paginas");

//Libro con la publicacion mas reciente.
Book Libnew = queries.Libromasreciente();
//Console.WriteLine($"El libro con la más reciente publicacion es : {Libnew.Title}  y fue publicado en:  {Libnew.PublishedDate} ");

//Suma de los libros que tienen entre 0 y 500 paginas
  //Console.WriteLine($"La suma de los libros entre 0 y 500 paginas es : { queries.Sumalibros()} paginas");

//Libros que fueron publicados despues del 2015
//  Console.WriteLine(queries.Libros2015publi());

//Promedio del los caracteres que tiene los libros 
  //Console.WriteLine($"El promedio de caracteres en los titulos de los libros es de: {queries.PromCaracLib()}");

//Libros publicados a partir del año 2000 presentados de forma agrupada
  //ImprimirGrupo(queries.Librosdp200Agrupados());

//Diccionario de libros por letras del abecedario
  var dicionario = queries.LibrosporLetra();
  //ImprimirDiccionario(dicionario,'A');

//Libros con Join Filtrado
ImprimirValores(queries.JoinLibros());



void ImprimirValores(IEnumerable<Book> listdelibros)
{
    Console.WriteLine("{0,-60} {1,15} {2,15} \n", "Titulo", "N.Paginas", "Fecha publicacion");
    foreach(var item in listdelibros)
    {
        Console.WriteLine("{0,-60} {1,15} {2,15}", item.Title, item.PageCount, item.PublishedDate.ToShortDateString());
    }
}

void ImprimirGrupo(IEnumerable<IGrouping<int, Book>> listadeLibros)
{

    foreach (var grupo in listadeLibros)
    {
        Console.WriteLine("");
        Console.WriteLine($"Grupo: {grupo.Key}");
        Console.WriteLine("{0, -60}, {1,15}, {2,15} ", "Titulo", "N. Paginas", "Fecha de Publicacion");
        foreach (var item in grupo)
        {
            Console.WriteLine("{0, -60}, {1,15}, {2,15} ", item.Title, item.PageCount, item.PublishedDate);
        }


    }
}

void ImprimirDiccionario(ILookup<char, Book> listadeLibros, char letra)
{
    Console.WriteLine("{0, -60}, {1,7}, {2,11} \n ", "Titulo", "N. Paginas", "Fecha de Publicacion");
    foreach (var item in listadeLibros[letra])
    {
        Console.WriteLine("{0, -60}, {1,7}, {2,11} ", item.Title, item.PageCount, item.PublishedDate);
    }
}