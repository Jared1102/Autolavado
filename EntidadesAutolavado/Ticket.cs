using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAutolavado
{
    public class Ticket
    {
        private string _Folio;
        private double _Pago;
        private double _Cobro;
        private double _Cambio;

        public string Folio { get => _Folio; set => _Folio = value; }
        public double Pago { get => _Pago; set => _Pago = value; }
        public double Cobro { get => _Cobro; set => _Cobro = value; }
        public double Cambio { get => _Cambio; set => _Cambio = value; }
    }
}
