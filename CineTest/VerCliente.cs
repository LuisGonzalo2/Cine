using System;
using CapaDatos;
using CapaLogica;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine
{
    class VerCliente
    {

        public VerCliente() { }

        //Un metodo que recibe variables para representar un resumen
        public void cliente(string username, string peli, string sala, int numeroasiento, string alimento, string sumi, int totalasientos)
        {
            Console.WriteLine("Tu nombre es: "+username);
            Console.WriteLine(peli);
            Console.WriteLine("Tu numero de sala es: "+sala+" Los asiento restantes son: "+totalasientos);
            Console.WriteLine("Escogistes el asiento #"+numeroasiento);
            Console.WriteLine("Tu Alimento es: "+alimento);
            Console.WriteLine("La pelicula que escogistes viene con: "+sumi);
        }
    }
}
