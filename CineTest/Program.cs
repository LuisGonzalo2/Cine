using System;
using CapaLogica;
using CapaDatos;

namespace Cine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title= "CINE";
            string respuesta = "S";
            while (respuesta.Equals("S"))
            {
                Cliente nombre = new Cliente();
                Alimentos ver = new Alimentos();
                pedirValores pedir = new pedirValores();
                opciones elejir = new opciones();
                Peliculas mostrarPelis = new Peliculas();
                Mensajes bienvenida = new Mensajes();
                OperarAsientos operar = new OperarAsientos();
                //Pedir Nombre al usuario
                bienvenida.bienvenida();
                bienvenida.pedirNombre();
                string username = nombre.NombreCliente();
                //Pedir la Sala que escoja
                Console.Clear();
                string mensajeSalas = bienvenida.listSalas();
                int salanumero = pedir.pedirSala(mensajeSalas);
                string sala = elejir.elejirSala(salanumero);
                int sala2 = elejir.escogerAsientosSalas(salanumero);
                Console.Clear();
                //Pedir que escoja una pelicula
                bienvenida.listapelis();
                mostrarPelis.listaPeliculas();
                int pelicula = pedir.pedirPelicula();
                string peli = elejir.elejirpelicula(pelicula);
                Console.Clear();
                //Pedir que escoja un asiento
                string mensajeAsiento = bienvenida.numeroAsientos(sala2);
                int numeroAsientos = pedir.pedirNumeroAsientos(sala2, mensajeAsiento);
                int asiento = operar.operar(sala2);
                Console.Clear();
                //Pedir alimentos que escoja
                ver.listaAlimentos();
                string alimento = elejir.elejirAlimentos(pedir.pedirAlimentos());
                Console.Clear();
                //Suministro por cada Sala
                string sumi = elejir.suministrosSalas(salanumero);
                VerCliente mostrarconclusion = new VerCliente();
                mostrarconclusion.cliente(username, peli, sala, numeroAsientos, alimento, sumi, asiento);
                do
                {
                    
                    Console.WriteLine(bienvenida.mensajeRetorno());
                    respuesta = Console.ReadLine();

                } while (!respuesta.Equals("S") && !respuesta.Equals("N"));
            }
            Console.ReadKey();

        }
    }
}
