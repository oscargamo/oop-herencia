using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHerencia.clases
{
    // Hereda los atributos y comportamientos de la clase padre mediante CHija : Clpadre 
    class CTerreno : CInmueble
    {
        // Estados - Atributos
        // Comportamiento - Metodos
        public void MostrarDatos()
        {
            Console.WriteLine("Detalles de Inmueble");
            Console.WriteLine("\tTipo de Inmueble: " + tipoInmueble);
            Console.WriteLine("\tDireccion: " + ubicacion);
            Console.WriteLine("\tArea de terreno: " + areaTerreno);
            Console.WriteLine("\tPrecio: " + precio);
        }
    }
}
