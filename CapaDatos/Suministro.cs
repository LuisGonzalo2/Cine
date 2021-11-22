using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Suministro:Salas
    {
        //en estos metodos creamos o devolvemos de tipo string los nombres de suministro que da el cine de regalo por cada sala.
        public string SumiSala1()
        {
            return "Gafas 3D";
        }
        public string SumiSala2()
        {
            return "Mani";
        }
        public string SumiSala3()
        {
            return "Extra Cangil";
        }
    }
}
