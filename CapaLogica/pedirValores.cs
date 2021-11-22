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
        //Este metodo pedirSala sirve para que el cliente elija dentro de las opciones una sola sala
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
        //Este metodo sirve para pedir dentro de la lista una pelicula
        public int pedirPelicula()
        {
            String num = Console.ReadLine();
            int peli = int.Parse(num);
            return peli;
        }
        //Este metodo sirve para comprobar y pedir el numero de asientos en una sala
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
        //Este metodo sirve para pedir en una lista los alimentos que escoge el usuario
        public int pedirAlimentos()
        {
            String num = Console.ReadLine();
            int Alimentos = int.Parse(num);
            return Alimentos;
        }

    }
}
