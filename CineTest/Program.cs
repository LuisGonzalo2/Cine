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
            //inicializamos la variables respuesta para que sirva de ciclo para ingresar a otro cliente
            string respuesta = "S";
            while (respuesta.Equals("S"))
            {
                //Se crean los objetos con diferentes funciones
                //El objeto nombre para ver el nombre del usuario
                Cliente nombre = new Cliente();
                //El Objeto ver, sirve para describir todo los alimentos, que estan almacenados en una lista previa.
                Alimentos ver = new Alimentos();
                //El obejto pedir sirve para pedir valores x
                pedirValores pedir = new pedirValores();
                //El objeto elejir para elijir diferentes opciones
                opciones elejir = new opciones();
                //El objeto MostrarPelis para mostrar en consola la lista de peliculas
                Peliculas mostrarPelis = new Peliculas();
                //El objeto bienvenida para mostrar los mensajes de esa clase
                Mensajes bienvenida = new Mensajes();
                //El obejto operar para dar un operacion sencilla.
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
                //Este ciclo sirve para preguntar si desea poner otro cliente
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
