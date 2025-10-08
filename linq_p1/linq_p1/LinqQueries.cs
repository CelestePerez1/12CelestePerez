using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace linq_p1
{
    internal class LinqQueries
    {
        private List<Book> librosCollection = new List<Book>();

        public LinqQueries() {
            using (StreamReader reader = new StreamReader("books.json"))
            {
                string json = reader.ReadToEnd();
                this.librosCollection = System.Text.Json.JsonSerializer.Deserialize<List <Book>>(json, new System.Text.Json.JsonSerializerOptions() {PropertyNameCaseInsensitive = true});
            }
        }
        public IEnumerable <Book> TodaColletion()
        {
            return librosCollection;
        }

        //reto 1:
        public IEnumerable <Book> LibrosDespuesdel2000()
        {
            //extension metho
            //return librosCollection.Where(p => p.PublishedDate.Year > 2000);

            //query expression
            return from l in librosCollection where l.PublishedDate.Year > 2000 select l;
        }

        //reto 2: 
        public IEnumerable <Book> LibrosConMas250PagConPalabrasInAction()
        {
            //extension metho
            //return librosCollection.Where(p => p.PageCount > 250 && p.Title.Contains("in Action"));

            //Querie expression
            return from l in librosCollection where l.PageCount > 250 && l.Title.Contains("in Action") select l;
        }

        //reto 3: All
        public bool TodosLibrosTienenStatus()
        {
            return librosCollection.All(p => p.Status != string.Empty);
        }

        //reto 4: Any
        public bool SiAlgunLibroPUblicado2005()
        {
            return librosCollection.Any(p => p.PublishedDate.Year == 2005);
        }

        //Reto 5: Contains
        public IEnumerable<Book> LibrosPython()
        {
            return librosCollection.Where(p => p.Categories.Contains("Python"));
        }

        //Reto 6: OrderBy
        public IEnumerable<Book> LibrosJavaPorNombreAscendente()
        {
            return librosCollection.Where(p => p.Categories.Contains("Java")).OrderBy(p=> p.Title);
        }

        //Reto 7: OrderByDescending
        public IEnumerable <Book> Librosmas450pagOrdenadosPorNumPagDescendente()
        {
            return librosCollection.Where(p => p.PageCount > 450).OrderByDescending(p => p.PageCount);
        }

        //reto 8: Take
        public IEnumerable <Book> TresPrimerosLibrosOrdenadosPorFecha()
        {
            return librosCollection.Where(p => p.Categories.Contains("Java"))
                .OrderByDescending(p => p.PublishedDate)
                .Take(3);
                //.TakeLast(3) si quieres los ultimos
        }


        //reto 9: Skip
        public IEnumerable <Book> TercerCuartoLibroDeMas499Pag()
        {
            return librosCollection.Where(p => p.PageCount > 400)
                .Take(4)
                .Skip(2); //omite los 2 primeros

        }

        public  IEnumerable <Book>  TresPrimerosLIbrosCollection()
        {
            return librosCollection.Take(3)
            .Select(p => new Book() { Title=p.Title, PageCount=p.PageCount });
        }


        // Agregado de los videos 17 al 26 
        public int Librosentre200_500pag()
        {
            //return ColeccionLibros.Count(v => v.PageCount > 200 && v.PageCount < 500); 
            //Modificación aplicada con el filtro Count que seria similar a lo aplicado en el video con LongCount

            return (int)librosCollection.LongCount(v => v.PageCount > 200 && v.PageCount < 500);
            //Aplico la función de Long Count en la misma linea para hacer la diferencia, aunque
            //el resutlado de la misma va a ser el mismo que la función anterior, pero es mas por su forma de alojar los datos

            //A como es un long se hace cast explicito para que la función pueda usarse con el int
        }

        //Min:
        public DateTime FechaMenor()
        {
            return librosCollection.Min(d => d.PublishedDate);
        }

        //Max
        public int Libromasgrande()
        {
            return librosCollection.Max(e => e.PageCount);
        }
        
        //MinBy:
        public Book Libroconpocaspaginas()
        {
            return librosCollection.Where(y => y.PageCount > 0).MinBy(y => y.PageCount);
        }

        
        //MaxBy:
        public Book Libromasreciente()
        {
            return librosCollection.MaxBy(u => u.PublishedDate);
        }

        //Sum:
        public int Sumalibros()
        {
            return librosCollection.Where(r => r.PageCount >= 0 && r.PageCount < 500).Sum(r => r.PageCount);
        }

        //Aggregate: combinar todos los elementos, en un unico resultado
        public string Libros2015publi()
        {
            return librosCollection
                .Where(t => t.PublishedDate.Year > 2015).
                Aggregate("", (TituloLibros, next) =>
                {
                    if (TituloLibros != string.Empty)
                        TituloLibros += "  -  " + next.Title;
                    else
                        TituloLibros += next.Title;
                    return TituloLibros;
                });
        }

        //Average:Promedio 
        public double PromCaracLib()
        {
            return librosCollection.Average(i => i.Title.Length);
        }

        //GroupBy:Devuelve grupos
        public IEnumerable<IGrouping<int, Book>> Librosdp200Agrupados()
        {
            return librosCollection.Where(g => g.PublishedDate.Year >= 2000).GroupBy(g => g.PublishedDate.Year);
        }

        //ToLookup: Devuelve grupos
        public ILookup<char, Book> LibrosporLetra()
        {
            return librosCollection.ToLookup(x => x.Title[0], x => x);
        }

        //Join: union 
        public IEnumerable<Book> JoinLibros()
        {
            var Librosdp2005 = librosCollection.Where(q => q.PublishedDate.Year >= 2005);

            var Libros500pag = librosCollection.Where(q => q.PageCount > 500);

            return Librosdp2005.Join(Libros500pag, q => q.Title, l => l.Title, (q, l) => l);

        }

    }

}
