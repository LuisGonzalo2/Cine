using System;
using CapaDatos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class pedirValores
    {
        public int pedirSala(string mensaje)
        {
            int sala = 0;
            do
            {
                Console.WriteLine(mensaje);
                String num = Console.ReadLine();
                sala = int.Parse(num);
            } while (sala <1 || sala >3);
            return sala;
        }
        public int pedirPelicula()
        {
            String num = Console.ReadLine();
            int peli = int.Parse(num);
            return peli;
        }
        public int pedirNumeroAsientos(int sala, string mensaje)
        {
            int valor = 0;
            do
            {
                Console.WriteLine(mensaje);
                String num = Console.ReadLine();
                valor = int.Parse(num);
            } while (valor > sala);

           return valor;

        }
        public int pedirAlimentos()
        {
            String num = Console.ReadLine();
            int Alimentos = int.Parse(num);
            return Alimentos;
        }

    }
}
