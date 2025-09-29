// See https://aka.ms/new-console-template for more information

using POO_P2;
using POO_P2.Models;
using System.Text;

var imprimirInfo = new ImprimirInfo();

var poderVolar = new SuperPoder();
poderVolar.nombre = "Volar";
poderVolar.descripcion = "Capacidad para volar y planear en el aire";
poderVolar.nivel = NivelPoder.Niveldos;

var superfuerza = new SuperPoder();
superfuerza.nombre = "super fuerza";
superfuerza.nivel = NivelPoder.NivelTres;

var regeneracion = new SuperPoder();
regeneracion.nombre = "Regeneración";
regeneracion.nivel = NivelPoder.NivelTres;

var superman = new SuperHeroe();

superman.id = 1;
superman.nombre = "   Superman   ";
superman.identidadSecreta = "Clark kent";
superman.ciudad = "Metropolis";
superman.PuedeVolar = true;

imprimirInfo.ImprimirSuperHeroe(superman);

List<SuperPoder> poderesSuperman = new List<SuperPoder>();
poderesSuperman.Add(poderVolar);
poderesSuperman.Add(superfuerza);
superman.superPoderes = poderesSuperman;
string resultSuperpoder = superman.UsarSuperPoderes();
Console.WriteLine(resultSuperpoder);

string resultSalvarMundo = superman.salvarelmundo();
Console.WriteLine($"{resultSalvarMundo}");
string resultSalvarTierra = superman.salvaerLaTierra();
Console.WriteLine($"{resultSalvarTierra}");

var wolverine = new AntiHeroe();
wolverine.id = 5;
wolverine.nombre = "Wolverine";
wolverine.identidadSecreta = "Logan";
wolverine.PuedeVolar = false;

imprimirInfo.ImprimirSuperHeroe(wolverine);

List<SuperPoder> poderesWolverine = new List<SuperPoder>();
poderesWolverine.Add(regeneracion);
poderesWolverine.Add(superfuerza);
wolverine.superPoderes = poderesWolverine;
string resultWolverinePoderes = wolverine.UsarSuperPoderes();
Console.WriteLine(resultWolverinePoderes);

string accionAntiheroe = wolverine.realizarAccionDeAntiHeroe("Ataca la policia");
Console.WriteLine(accionAntiheroe);



enum NivelPoder { 
Niveluno,
Niveldos,
NivelTres
}

public record SuperheroeRecord(int id, string nombre, string identidadSecreta);