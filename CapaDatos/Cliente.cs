using System;

namespace CapaDatos
{
    public class Cliente
    {
        public string NOMBRE { get; set; }

        public Cliente()
        {
            

        }

        public string NombreCliente()
        {
            Cliente nombre = new Cliente();
            nombre.NOMBRE = Console.ReadLine();
            string mostrar = nombre.NOMBRE;
            return mostrar;
        }


    }
}
