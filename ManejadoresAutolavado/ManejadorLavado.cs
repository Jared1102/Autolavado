using EntidadesAutolavado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejadoresAutolavado
{
    public class ManejadorLavado
    {
        const int segundos = 1000;
        public int Mojado()
        {
            return 3*segundos;
        }

        public int Enjabonado()
        {
            return 5 * segundos;
        }
        public int Enjuagado()
        {
            return 5 * segundos;
        }
        public int Secado()
        {
            return 3 * segundos;
        }

        public int LimpiezaInt()
        {
            return 7 * segundos;
        }

        public int Encerado()
        {
            return 6 * segundos;
        }
    }
}
