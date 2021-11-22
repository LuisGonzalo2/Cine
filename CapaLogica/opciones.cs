using System;
using CapaDatos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class opciones
    {

        public string elejirSala(int num)
        {
            if (num == 1)
            {
                return "Sala #1 3D";
            }
            if(num == 2)
            {
                return "Sala #2 2D";
            }
            return "";
        }

        public string elejirpelicula(int num)
        {
            if(num == 1)
            {
                return "La pelicula escogida fue John Wick 3";
            }
            if(num == 2)
            {
                return "La pelicula escogida fue Aladdin";
            }
            if(num == 3)
            {
                return "La pelicula escogida fue Avengers";
            }
            if(num == 4)
            {
                return "La pelicula escogida fue Pikachu";
            }
            return "";
        }
        public string elejirAlimentos(int num)
        {
            if(num == 1)
            {
                return "Canguil";
            }
            if(num == 2)
            {
                return "HotDog";
            }
            if(num == 3)
            {
                return "CocaCola";
            }
            return "";
        }
        public string suministrosSalas(int num)
        {
            Suministro suministro = new Suministro();
            if(num == 1)
            {
                String mostrar = suministro.SumiSala1();
                return mostrar;
            }
            if(num == 2)
            {
                string mostrar = suministro.SumiSala2();
                return mostrar;
            }
            if(num == 3)
            {
                string mostrar = suministro.SumiSala3();
                return mostrar;
            }
            return "";
        }

        public int escogerAsientosSalas(int num)
        {
            if (num == 1)
            {
                Salas numero = new Salas();
                int valor = numero.Sala1();
                return valor;
            }
            if (num == 2)
            {
                Salas numero = new Salas();
                int valor = numero.Sala2();
                return valor;
            }
            if (num == 3)
            {
                Salas numero = new Salas();
                int valor = numero.Sala3();
                return valor;
            }
            return 0;
        }


    }
}
