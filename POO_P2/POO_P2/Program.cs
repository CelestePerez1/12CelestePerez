// See https://aka.ms/new-console-template for more information

using POO_P2.Models;
using System.Text;

var poderVolar = new SuperPoder();
poderVolar.nombre = "Volar";
poderVolar.descripcion = "Capacidad para volar y planear en el aire";
poderVolar.nivel = NivelPoder.Niveldos;

var superfuerza = new SuperPoder();
superfuerza.nombre = "super fuerza";
superfuerza.nivel = NivelPoder.NivelTres;

var superman = new SuperHeroe();

superman.id = 1;
superman.nombre = "Superman";
superman.identidadSecreta = "Clark kent";
superman.ciudad = "Metropolis";
superman.PuedeVolar = true;

var superman2 = new SuperHeroe();

superman2.id = 1;
superman2.nombre = "Superman";
superman2.identidadSecreta = "Clark kent";
superman2.ciudad = "Metropolis";
superman2.PuedeVolar = true;

Console.WriteLine(superman == superman2);
SuperheroeRecord superheroeRecord = new(1, "SUPERMAN", "Clark kent");
SuperheroeRecord superheroeRecord2 = new(1, "SUPERMAN", "Clark kent");

Console.WriteLine(superheroeRecord == superheroeRecord2);   
/*
List<SuperPoder> poderesSuperman = new List<SuperPoder>();
poderesSuperman.Add(poderVolar);
poderesSuperman.Add(superfuerza);
superman.superPoderes = poderesSuperman;
string resultSuperpoder = superman.UsarSuperPoderes();
Console.WriteLine(resultSuperpoder);
*/

enum NivelPoder { 
Niveluno,
Niveldos,
NivelTres
}

public record SuperheroeRecord(int id, string nombre, string identidadSecreta);