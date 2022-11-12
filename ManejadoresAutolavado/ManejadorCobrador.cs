using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAutolavado; 

namespace ManejadoresAutolavado
{
    public class ManejadorCobrador
    {
        private Random random = new Random();
        private List<Ticket> tickets = new List<Ticket>();
        public int[] GenerarCambio(Ticket ticket)
        {
            int[] contador = { 0, 0, 0, 0, 0, 0 };
            do
            {
                if (ticket.Cambio/50 >=1)
                {
                    contador[0]++;
                    ticket.Cambio -= 50;
                }else if(ticket.Cambio/20 >= 1)
                {
                    contador[1]++;
                    ticket.Cambio -= 20;
                }
                else if (ticket.Cambio/10>=1)
                {
                    contador[2]++;
                    ticket.Cambio -= 10;
                }else if (ticket.Cambio / 5 >= 1)
                {
                    contador[3]++;
                    ticket.Cambio -= 5;
                }
                else if (ticket.Cambio / 2 >= 1)
                {
                    contador[4]++;
                    ticket.Cambio -= 2;
                }
                else if (ticket.Cambio / 1 >= 1)
                {
                    contador[5]++;
                    ticket.Cambio -= 1;
                }
            } while (ticket.Cambio!=0);
            return contador;
        }
    }
}
