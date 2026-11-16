using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombustiPlus
{
    public class  Despacho
    {
       int Numero { get; set; }
       string Placa { get; set; }
       string combustible { get; set; }
       double Galones { get; set; }
       double pago { get; set; }
       double Total { get; set; }

       public override string ToString() => $"Despacho: {Numero}, Placa: {Placa}, Combustible: {combustible}, Galones: {Galones}, Pago: {pago}, Total: {Total}";

    }

}
