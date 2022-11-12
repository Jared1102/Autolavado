using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAutolavado
{
    public class Proceso
    {
        private string _NombreProceso;
        private int _Tiempo;

        public int Tiempo { get => _Tiempo; set => _Tiempo = value; }
        public string NombreProceso { get => _NombreProceso; set => _NombreProceso = value; }
    }
}
