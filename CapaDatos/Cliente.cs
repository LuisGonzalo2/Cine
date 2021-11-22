using System;

namespace CapaDatos
{
    public class Cliente
    {
        public string NOMBRE { get; set; }

        public Cliente()
        {
            

        }

        //En este metodo guardamos el nombbre del Cliente
        public string NombreCliente()
        {
            Cliente nombre = new Cliente();
            nombre.NOMBRE = Console.ReadLine();
            string mostrar = nombre.NOMBRE;
            return mostrar;
        }


    }
}
