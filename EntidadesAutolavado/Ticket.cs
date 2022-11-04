using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAutolavado
{
    public class Ticket
    {
        private int _Folio;
        private int _Pago;
        private int _Cobro;
        private int _Cambio;

        public int Folio { get => _Folio; set => _Folio = value; }
        public int Pago { get => _Pago; set => _Pago = value; }
        public int Cobro { get => _Cobro; set => _Cobro = value; }
        public int Cambio { get => _Cambio; set => _Cambio = value; }
    }
}
