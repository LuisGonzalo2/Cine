using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Alimentos
    {
        public string NombreAlimentos { get; set; }
        public void listaAlimentos()
        {
            Alimentos Canguil = new Alimentos();
            Canguil.NombreAlimentos = "1. Canguil";

            Alimentos HotDog = new Alimentos();
            HotDog.NombreAlimentos = "2. HotDog";

            Alimentos CocaCola = new Alimentos();
            CocaCola.NombreAlimentos = "3. CocaCola";

            List<Alimentos> ListaNombreAlimentos = new List<Alimentos>();
            ListaNombreAlimentos.Add(Canguil);
            ListaNombreAlimentos.Add(HotDog);
            ListaNombreAlimentos.Add(CocaCola);
            foreach (Alimentos item in ListaNombreAlimentos)
            {
                Console.WriteLine(item.NombreAlimentos);
            }

        }
    }
}
