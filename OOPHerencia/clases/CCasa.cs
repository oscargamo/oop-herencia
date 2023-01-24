using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHerencia.clases
{
    // Acontinuacion se heredan todos los atributos de la clase padre en este caso de CImueble mediante los 
    // : que indica que se heredan de CImueble
    class CCasa : CInmueble
    {
        // Estado - Atributos
        public double areaConstruida;
        public int cantidadDormitorios;
        public int cantidadPisos;

        // Comportamiento - Metodos
        public void mostrarDatos()
        {
            Console.WriteLine("Detalles de Inmueble");
            Console.WriteLine("\tTipo de Inmueble: " + tipoInmueble);
            Console.WriteLine("\tDireccion: " + ubicacion);
            Console.WriteLine("\tArea construida: " + areaConstruida);
            Console.WriteLine("\tArea de terreno: " + areaTerreno);
            Console.WriteLine("\tCantidad de dormitorios: " + cantidadDormitorios);
            Console.WriteLine("\tCantidad de pisos: " + cantidadPisos);
            Console.WriteLine("\tCantidad de baños: " + cantidadBaños);
            Console.WriteLine("\tPrecio: " + precio);
        }
    }
}
