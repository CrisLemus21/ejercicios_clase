using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tiendapepe.entidades;
namespace tiendapepe.negocio
{
    class ClsLogica
    {
        public string venta()
        {
            Console.WriteLine("para ingresar el dia de la semana escribir los dias con minusculas,\nejemplo: lunes, martes, miercoles, etc\n");
            ClsDatos datos = new ClsDatos();
            int datoA = 2;
            while (datoA == 2)
            {
                Console.WriteLine("cual es el monto a pagar?........\n");
                datos.Pago = int.Parse(Console.ReadLine());
                Console.WriteLine("en que dia se realiza la compra.....\n");
                datos.Dia = Console.ReadLine();
                if (datos.Dia == "martes" || datos.Dia == "jueves")
                {
                    datos.Resultado = datos.Pago-(datos.Pago*0.15);
                    Console.WriteLine("se le ha aplicado un descuento de un 15% por se "+datos.Dia+" \nsu tota a pagar es de " + datos.Resultado+" dolares");
                    Console.WriteLine("deseas cerrar el progrma?\npreciona 1) para si  \n2) para no");
                    datoA = int.Parse(Console.ReadLine());
                }
                if (datos.Dia == "lunes" || datos.Dia == "miercoles" || datos.Dia == "viernes" || datos.Dia == "sabado" || datos.Dia == "domingo")
                {
                    datos.Resultado = datos.Pago;
                    Console.WriteLine("el total a pagar es de " + datos.Pago+" dolares");
                    Console.WriteLine("deseas cerrar el progrma?\npreciona 1) para si \n2) para no");
                    datoA = int.Parse(Console.ReadLine());
                }
                if (datos.Dia != "lunes" && datos.Dia != "martes" && datos.Dia != "miercoles" && datos.Dia != "jueves" && datos.Dia != "viernes" && datos.Dia != "sabado" && datos.Dia != "domingo"&&datos.Dia!="")
                {
                    Console.WriteLine("usted ingreso un valor el cual no es correcto\n----------------------------------------------------\nsolo puedes ingresar los dias de la semana\n---------------------------------------");
                    Console.WriteLine("deseas cerrar el progrma?\npreciona 1) para si \n2) para no");
                    datoA = int.Parse(Console.ReadLine());
                }


            }

            return "";
        }
    }
}
