using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHerencia.clases
{
    class CInmueble
    {
        // Estado - atributos 
        public string tipoInmueble;
        public string ubicacion;
        public double areaTerreno;
        public int cantidadBaños;
        public double precio;

        // Comportamiento - Metodos
        public void Vender()
        {
            Console.WriteLine(tipoInmueble + " vendida por el precio de " + precio + " mas detalles");
            Console.WriteLine("Ubicacion: " + ubicacion);
        }

        public void Alquilar()
        {
            Console.WriteLine(tipoInmueble + " Vendidad por el precio de " + precio + " mas detalles");
            Console.WriteLine("Ubicacion: " + ubicacion);
        }
    }

}
