using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAutolavado
{
    public class Paquete
    {
        private int id;
        private string NombrePaquete;
        private List<Proceso> procesos;

        public int Id { get => id; set => id = value; }
        public string NombrePaquete1 { get => NombrePaquete; set => NombrePaquete = value; }
        public List<Proceso> Procesos { get => procesos; set => procesos = value; }
    }
}
