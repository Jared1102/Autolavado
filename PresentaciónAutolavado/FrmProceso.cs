using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManejadoresAutolavado;
using EntidadesAutolavado;

namespace PresentaciónAutolavado
{
    public partial class FrmProceso : Form
    {
        private List<Proceso> procesos = new List<Proceso>();
        private int contador = 0, tiempo=0;
        const int segundos = 1000;
        private string paquete="";
        public FrmProceso()
        {
            InitializeComponent();
            switch (FrmMenu.precio)
            {
                case 30:
                    procesos.Add(new Proceso
                    {
                        NombreProceso = "Mojado",
                        Tiempo = 3
                    });
                    procesos.Add(new Proceso
                    {
                        NombreProceso = "Enjabonado",
                        Tiempo = 3
                    });
                    procesos.Add(new Proceso
                    {
                        NombreProceso = "Enjuagado",
                        Tiempo = 5
                    });
                    procesos.Add(new Proceso
                    {
                        NombreProceso = "Secado",
                        Tiempo = 3
                    });
                    procesos.Add(new Proceso
                    {
                        NombreProceso = "Limpieza Int.",
                        Tiempo = 7
                    });
                    paquete = "Express";
                    break;
                    
                case 40:
                    procesos.Add(new Proceso
                    {
                        NombreProceso = "Mojado",
                        Tiempo = 3
                    });
                    procesos.Add(new Proceso
                    {
                        NombreProceso = "Enjabonado",
                        Tiempo = 3
                    });
                    procesos.Add(new Proceso
                    {
                        NombreProceso = "Encerado",
                        Tiempo = 6
                    });
                    procesos.Add(new Proceso
                    {
                        NombreProceso = "Secado",
                        Tiempo = 3
                    });
                    procesos.Add(new Proceso
                    {
                        NombreProceso = "Limpieza Int.",
                        Tiempo = 7
                    });
                    procesos.Add(new Proceso
                    {
                        NombreProceso = "Fragancia",
                        Tiempo = 2
                    });
                    paquete = "Cera";
                    break;
                case 50:
                    procesos.Add(new Proceso
                    {
                        NombreProceso = "Mojado",
                        Tiempo = 3
                    });
                    procesos.Add(new Proceso
                    {
                        NombreProceso = "Enjabonado",
                        Tiempo = 3
                    });
                    procesos.Add(new Proceso
                    {
                        NombreProceso = "Enjuagado",
                        Tiempo = 5
                    });
                    procesos.Add(new Proceso
                    {
                        NombreProceso = "Encerado",
                        Tiempo = 6
                    });
                    procesos.Add(new Proceso
                    {
                        NombreProceso = "Secado",
                        Tiempo = 3
                    });
                    procesos.Add(new Proceso
                    {
                        NombreProceso = "Limpieza Int.",
                        Tiempo = 7
                    });
                    procesos.Add(new Proceso
                    {
                        NombreProceso = "Fragancia",
                        Tiempo = 2
                    });
                    procesos.Add(new Proceso
                    {
                        NombreProceso = "Lubrivinil",
                        Tiempo = 4
                    });
                    paquete = "Total";
                    break;
            }
        }

        private void FrmProceso_Load(object sender, EventArgs e)
        {
            
        }

        private void tSegundero_Tick(object sender, EventArgs e)
        {
            lblTiempo.Text = string.Format("Tiempo: {0} seg", tiempo);
            tiempo--;
        }

        private void tProceso_Tick(object sender, EventArgs e)
        {
            if (contador<procesos.Count)
            {
                tSegundero.Stop();
                tProceso.Stop();
                lblProceso.Text = string.Format("Proceso: {0}", procesos[contador].NombreProceso);
                tiempo = procesos[contador].Tiempo;
                lblTiempo.Text = string.Format("Tiempo: {0} seg", tiempo);
                tiempo--;
                tProceso.Interval = procesos[contador].Tiempo * segundos;

                contador++;
                tProceso.Start();
                tSegundero.Start();
            }
            else
            {
                tProceso.Enabled = false;
                tSegundero.Enabled = false;
                MessageBox.Show("Tome su Ticket");
                MessageBox.Show(string.Format("Folio: {0}\nPaguete: {1}\nTotal:$ {2}\nPago:$ {3}\nCambio:$ {4}",
                    FrmCobrar.ticket.Folio, paquete, FrmCobrar.ticket.Cobro, FrmCobrar.ticket.Pago, FrmCobrar.ticket.Cambio));
                this.Close();
            }
        }
    }
}
