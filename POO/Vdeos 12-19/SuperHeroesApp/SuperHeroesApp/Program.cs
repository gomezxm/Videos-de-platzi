using System;
using System.Text;
using SuperHeroesApp.Models;

var poderVolar = new SuperPoder();
poderVolar.nombre = "volar";
poderVolar.descripcion = "Capacidad para volar y planear en el aire";
poderVolar.nivel = NivelPoder.NivelDos;

var superFurza = new SuperPoder();
superFurza.nombre = "Super Fuerza";
superFurza.nivel = NivelPoder.NivelTres;

var superman = new SuperHeroe();

superman.Id = 1;
superman.nombre= "superman";
superman.IdentidadSecreta = "Clark Kent";
superman.ciudad = "Metropolis";
superman.PuedoVolar = true;

var superman2 = new SuperHeroe();

superman2.Id = 1;
superman2.nombre = "superman";
superman2.IdentidadSecreta = "Clark Kent";
superman2.ciudad = "Metropolis";
superman2.PuedoVolar = true;

var regeneracion = new SuperPoder();
superFurza.nombre = "Regeneracion";
superFurza.nivel = NivelPoder.NivelTres;


List<SuperPoder> poderesSuperman = new List<SuperPoder>();
poderesSuperman.Add(poderVolar);
poderesSuperman.Add(superFurza);
superman.SuperPoderes = poderesSuperman;
string resultSuperPoderes = superman.UsarSuperPoderes();
Console.WriteLine(resultSuperPoderes);
string resultSalvarMundo = superman.SalvarElMundo();
Console.WriteLine(resultSalvarMundo);

string resultSalvarTierra = superman.salvarTierra();
Console.WriteLine(resultSalvarTierra);


var wolverine = new AntiHeroe();
wolverine.Id = 5;
wolverine.nombre = "Wolverine";
wolverine.IdentidadSecreta = "Logan";
wolverine.PuedoVolar = false;

List<SuperPoder> poderesWolverine = new List<SuperPoder>();
poderesWolverine.Add(regeneracion);
poderesWolverine.Add(superFurza);
wolverine.SuperPoderes = poderesWolverine;
string resultWolPoderes = wolverine.UsarSuperPoderes();
Console.WriteLine(resultWolPoderes);

string accionAntiHeore = wolverine.RealizarAccionAntiHeroe("Atacar a la policia");

enum NivelPoder
{
    NivelUno,
    NivelDos,
    NivelTres
}
