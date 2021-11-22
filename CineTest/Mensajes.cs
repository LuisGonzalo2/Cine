using System;
using CapaDatos;
using CapaLogica;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine
{
    class Mensajes
    {
        public Mensajes() { }
        public void bienvenida()
        {
            Console.WriteLine("BIENVENIDO AL CINE LOS LUISILLOS");
        }
        public void pedirNombre()
        {
            Console.WriteLine("Ingrese el Su nombre Por favor");
        }
        public void listapelis()
        {
            Console.WriteLine("Elija la pelicula que mas le guste");
        }
        public string listSalas()
        {
            return "Escoga que sala desea: \n 1. Sala #1 \n 2. Sala #2 \n 3. Sala #3";
        }
        public string numeroAsientos(int numeroAsientosSala)
        {

            
            return "Que numero de asiento va escoger? Asientos disponibles son: "+ numeroAsientosSala;
        }
        public string mensajeRetorno()
        {
            Console.WriteLine("Necesitas ingresar a otro usuario?");
            Console.WriteLine("Si ---> S o No ---> N");
            return "";
        }
    }
}
