using System;
using CapaDatos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion
{
    public class Mostrar
    {
        public Mostrar()
        {
            
        }
        
        public void mensaje()
        {
            Cliente pediNombre = new Cliente();
            string nombre = pediNombre.NombreCliente();
            Console.WriteLine("Bienvenido " + nombre);
            Console.WriteLine("que deseas");
            Peliculas mostar = new Peliculas();
            mostar.listaPeliculas();
            
        }
    }
}
