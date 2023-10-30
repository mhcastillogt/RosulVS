using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wsTipoCambio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            wsBanguat.TipoCambio ws = new wsBanguat.TipoCambio();
            var TasaCambio = ws.TipoCambioDia();

            Console.WriteLine("Ingrese el Monto en Dolares: ");
            float Monto = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);
            Console.WriteLine("Tasa de Cambio: " + TasaCambio.CambioDolar.First().referencia);
            Console.WriteLine("Total en Quetzales: " + (TasaCambio.CambioDolar.First().referencia *Monto)) ;
            Console.ReadLine();
            

        }
    }
}
