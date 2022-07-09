using System;
using System.Collections.Generic;
using System.Text;

namespace EU123CV_Jesus_Maza
{
    public  class Cliente
    {
        public string Nombre { get; set; }

        public string Correo { get; set; }
        
        public string Apellidos  { get; set; }

        public long Telefono { get; set; }
        
        public long TotalCompra { get; set; }





        public string DatosClientes()
        {
            string regresar = "" ;

            Console.WriteLine("Ingresar datos del cliente");
            Console.WriteLine("Ingresa tu nombre: ");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingresa tu apellido: ");
            Apellidos = Console.ReadLine();
            Console.WriteLine("Ingresa tu correo: ");
            Correo = Console.ReadLine();
            Console.WriteLine("Ingresa tu telefono: ");
            Telefono = long.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el total de tu compra: ");
            TotalCompra = long.Parse(Console.ReadLine());

            if (TotalCompra >= 3000)
            {
                double resultado;
                double Final;

                Console.WriteLine("*****************************************************************");
                Console.WriteLine(Nombre);
                Console.WriteLine(Apellidos);
                Console.WriteLine(Correo);
                Console.WriteLine(Telefono);
                resultado = (TotalCompra / 3) * .20;
                Final = TotalCompra - resultado;
                Console.WriteLine("Felicidades tienes un descuento del 20% con meses sin intereses.");
                Console.WriteLine(Final);
                Console.WriteLine("*****************************************************************");
            }

            else if (TotalCompra >= 2000)
            {
                double resultado;
                double total;

                Console.WriteLine("*****************************************************************");
                Console.WriteLine(Nombre);
                Console.WriteLine(Apellidos);
                Console.WriteLine(Correo);
                Console.WriteLine(Telefono);
                resultado = TotalCompra * .20;
                total = TotalCompra - resultado;
                Console.WriteLine("Felicidades tienes un descuento del 20%. ");
                Console.WriteLine(total);
                Console.WriteLine("*****************************************************************");
            }
            else if (TotalCompra >= 1000)
            {
                double resultado;

                Console.WriteLine("************************************************************");
                Console.WriteLine(Nombre);
                Console.WriteLine(Apellidos);
                Console.WriteLine(Correo);
                Console.WriteLine(Telefono);
                resultado = TotalCompra / 3;
                Console.WriteLine("Felicidades tienes un descuento en meses sin intereses. " + resultado);
                Console.WriteLine(resultado);
                Console.WriteLine("************************************************************");
            }
            else
            {
                Console.WriteLine("Lo siento no tienes los descuentos");
            }
            return regresar;
        }
    }

}
