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

Console.WriteLine(superman == superman2);

SuperHeroRecord superHeroRecord = new(1, "Superman", "Clark Kent");

SuperHeroRecord superHeroRecord2 = new(1, "Superman", "Clark Kent");

Console.WriteLine(superHeroRecord == superHeroRecord2);
//List<SuperPoder> poderesSuperman = new List<SuperPoder>();
//poderesSuperman.Add(poderVolar);
//poderesSuperman.Add(superFurza);
//superman.SuperPoderes = poderesSuperman;
//string resultSuperPoderes = superman.UsarSuperPoderes();
//Console.WriteLine(resultSuperPoderes);



//class SuperHeroe
//{
//    public int Id;
//    public string nombre;
//    public string IdentidadSecreta;
//    public string ciudad;
//    public List<SuperPoder> SuperPoderes;
//    public bool PuedoVolar;

//    public SuperHeroe()
//    {
//        SuperPoderes = new List<SuperPoder>();
//        PuedoVolar = false;

//    }

//    public string UsarSuperPoderes()
//    {
//        StringBuilder sb = new StringBuilder();
//        foreach (var item in SuperPoderes)
//        {
//            Console.WriteLine($"{nombre} esta usando el super poder: {item.nombre}");
//        }

//        return sb.ToString();
//    }

//}

//class SuperPoder
//{
//    public string nombre;
//    public string descripcion;
//    public NivelPoder nivel;
    
//    public SuperPoder()
//    {
//        nivel = NivelPoder.NivelUno;
//    }
// }

enum NivelPoder
{
    NivelUno,
    NivelDos,
    NivelTres
}

public record SuperHeroRecord(int id, string nombre, string identidadSecreta);
