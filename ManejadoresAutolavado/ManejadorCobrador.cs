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
        public void Cobrar(Ticket ticket)
        {
            tickets.Add(ticket);
        }
    }
}
