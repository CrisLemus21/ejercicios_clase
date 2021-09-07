using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tiendapepe.negocio;

namespace tiendapepe
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsLogica logica = new ClsLogica();
            Console.WriteLine(logica.venta());
            Console.ReadLine();
        }
    }
}
