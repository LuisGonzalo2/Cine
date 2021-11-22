using System;
using CapaDatos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class OperarAsientos
    {
        public OperarAsientos() { }

        //restar el numero total de asientos 
        public int operar(int sala)
        {
            int resta = sala - 1;
            
            return resta;
        }

    }
}
