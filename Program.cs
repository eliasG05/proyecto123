using System;

namespace EU123CV_Jesus_Maza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();

            string opcion = "";

            while (!opcion.Equals("0"))
            {
                Console.WriteLine("[Que MOVIMIENTO DESEA REALIZAR]");
                Console.WriteLine("1) Ingresar datos del cliente");
                Console.WriteLine("0) Salir");
                Console.WriteLine("Seleccione una opcion :)");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        cliente.DatosClientes();
                        break;
                }
            }
        }
    }
}  