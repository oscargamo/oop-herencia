using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHerencia.clases
{
    // Hereda los atributos y comportamientos de la clase padre CImueble
    class CDepartamento : CInmueble
    {
        // Estados - Atributos propios de la clase departamento
        public double areaConstruida;
        public int cantidadDormitorios;
        public int Edad { get; private set; }


        // Comportamiento = Metodos
        public void MostrarDatos()
        {
            Console.WriteLine("Detalles de Inmueble");
            Console.WriteLine("\tTipo De Inmueble: " + tipoInmueble);
            Console.WriteLine("\tDireccion: " + ubicacion);
            Console.WriteLine("\tArea Construidad: " + areaConstruida);
            Console.WriteLine("\tArea de Terreno: " + areaTerreno);
            Console.WriteLine("\tCantidad de Dormitorio: " + cantidadDormitorios);
            Console.WriteLine("\tCantidad de Baños: " + cantidadBaños);
            Console.WriteLine("\tPrecio: " + precio);
        }
    }
}
