using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombustiPlus
{
    public class  Despacho
    {
       public int Numero { get; set; }
       public string Placa { get; set; }
       public string Combustible { get; set; }
       public double Galones { get; set; }
       public string Pago { get; set; }
       public double Total { get; set; }

       public override string ToString() => $"{Numero:00}  {Placa,-7} {Combustible,-7} {Galones:F1} gal {Pago,-8} RD$ {Total,9:N2}";

    }

}
