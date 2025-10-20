using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


    }

}
