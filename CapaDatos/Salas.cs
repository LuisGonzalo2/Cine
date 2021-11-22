using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Salas
    {
        public string Gafas3D { get; set; }
        public string Mani { get; set; }
        public int Asientos { get; set; }
        public Salas() { }
        public int Sala1()
        {
            Salas disponiblesAsientos = new Salas();
            int numero = disponiblesAsientos.Asientos = 6;
            return numero;
        }
        //##########################################################################
        public int Sala2()
        {
            Salas disponiblesAsientos = new Salas();
            int numero = disponiblesAsientos.Asientos = 10;
            return numero;
        }

        //#####################################################################
        public int Sala3()
        {
            Salas disponiblesAsientos = new Salas();
            int numero = disponiblesAsientos.Asientos = 2;
            return numero;
        }
    }
}
