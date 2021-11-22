using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Peliculas
    {

        public string NombreDePelicula { get; set; }
        public int PrecioPelicula { get; set; }
        public Peliculas() { }
        //En este metodo imprimimos una lista de obejtos llamda lsita de peliculas
        public void listaPeliculas()
        {

            Peliculas primerPelicula = new Peliculas();
            primerPelicula.NombreDePelicula = "1. John Wick 3";
            primerPelicula.PrecioPelicula = 2;

            Peliculas segundaPelicula = new Peliculas();
            segundaPelicula.NombreDePelicula = "2. Aladdin";
            segundaPelicula.PrecioPelicula = 3;

            Peliculas terceraPelicula = new Peliculas();
            terceraPelicula.NombreDePelicula = "3. Avengers";
            terceraPelicula.PrecioPelicula = 5;

            Peliculas cuartaPelicula = new Peliculas();
            cuartaPelicula.NombreDePelicula = "4. Pikachu";
            cuartaPelicula.PrecioPelicula = 3;


            List<Peliculas> ListaNombresPeliculas = new List<Peliculas>();
            ListaNombresPeliculas.Add(primerPelicula);
            ListaNombresPeliculas.Add(segundaPelicula);
            ListaNombresPeliculas.Add(terceraPelicula);
            ListaNombresPeliculas.Add(cuartaPelicula);

            foreach (Peliculas item in ListaNombresPeliculas)
            {
                Console.WriteLine(item.NombreDePelicula);
            }
        }

    }
}
