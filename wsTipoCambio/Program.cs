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


            Console.WriteLine("Ingrese Fecha Tasa de Cambio: ");
            string Fecha = Console.ReadLine();
            var TasaCambio = ws.TipoCambioFechaInicial(Fecha);
            Console.WriteLine("Ingrese el Monto en Dolares: ");
            float Monto = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);
            Console.WriteLine("Tasa de Cambio: " + TasaCambio.Vars.First().venta);
            Console.WriteLine("Total en Quetzales: " + (TasaCambio.Vars.First().venta * Monto)) ;
            Console.WriteLine("Presione Enter para Salir");
            Console.ReadLine();            
        }
    }
}
