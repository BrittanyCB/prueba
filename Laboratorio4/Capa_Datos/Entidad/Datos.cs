using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Capa_Datos.Entidad
{
    public class Datos
    {
        public int IdFactura { get; set; }
        public int numLinea { get; set; }
        public string codProduct { get; set; }
        public string detProduct { get; set; }
        public int cantProduct { get; set; }
        public double costUnitario { get; set; }
        public double totalLinea { get; set; }

    }
}
