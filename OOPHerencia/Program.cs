using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPHerencia.clases;
namespace OOPHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos el objeto Casa de la clase CCasa 
            CCasa casa = new CCasa();
            casa.tipoInmueble = "Casa de Campo";
            casa.ubicacion = "Tlapacoya";
            casa.areaTerreno = 250;
            casa.areaConstruida = 350;
            casa.cantidadDormitorios = 12;
            casa.cantidadPisos = 3;
            casa.cantidadBaños = 4;
            casa.precio = 455354;
            casa.Vender();
            casa.mostrarDatos();

            // Ahora creamos el objeto de la clase CDepartamento

            CDepartamento departamento = new CDepartamento();
            departamento.tipoInmueble = "Departamento de Lujo";
            departamento.ubicacion = "Av. Central";
            departamento.areaConstruida = 60;
            departamento.areaTerreno = 40;
            departamento.cantidadDormitorios = 3;
            departamento.cantidadBaños = 2;
            departamento.precio = 16000000;
            departamento.Vender();
            departamento.MostrarDatos();

            // Ahora creamos el objeto de la clase CTerreno;
            CTerreno terreno = new CTerreno();
            terreno.tipoInmueble = "Terreno";
            terreno.ubicacion = "Av. Periferico";
            terreno.areaTerreno = 300;
            terreno.precio = 1000330;
            terreno.Vender();
            terreno.MostrarDatos();


            Console.ReadLine();

            // la herencia facilita la creacion de objetos a partir de otros objetos clases existentes
            // permite que una clase hija obtenga los atributos, metodos de la clase padre
            // lo que facilita la reutilizacion de codigo y la extensibilidad 
        }
    }
}
