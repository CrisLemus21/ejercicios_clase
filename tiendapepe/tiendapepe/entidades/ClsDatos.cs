using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiendapepe.entidades
{
    class ClsDatos
    {
        string dia;
        int pago;
        double resultado;

        public string Dia { get => dia; set => dia = value; }
        public int Pago { get => pago; set => pago = value; }
        public double Resultado { get => resultado; set => resultado = value; }
    }
}
