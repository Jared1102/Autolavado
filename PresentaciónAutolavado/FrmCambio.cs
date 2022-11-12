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

namespace PresentaciónAutolavado
{
    public partial class FrmCambio : Form
    {
        private int[] contador = { 0, 0, 0, 0, 0, 0 };
        private int cambio = 0;
        private ManejadorCobrador _manejadorCobrador;
        public FrmCambio()
        {
            InitializeComponent();
            _manejadorCobrador = new ManejadorCobrador();
        }

        private void FrmCambio_Load(object sender, EventArgs e)
        {
            contador=_manejadorCobrador.GenerarCambio(FrmCobrar.ticket);
            lbl50.Text = string.Format("{0} x", contador[0]);
            lbl20.Text = string.Format("{0} x", contador[1]);
            lbl10.Text = string.Format("{0} x", contador[2]);
            lbl5.Text = string.Format("{0} x", contador[3]);
            lbl2.Text = string.Format("{0} x", contador[4]);
            lbl1.Text = string.Format("{0} x", contador[5]);

            ///
            cambio += 50 * contador[0];
            cambio += 20 * contador[1];
            cambio += 10 * contador[2];
            cambio += 5 * contador[3];
            cambio += 2 * contador[4];
            cambio += 1* contador[5];

            lblPagando.Text = string.Format("Cambio: ${0}",cambio.ToString());
            FrmCobrar.ticket.Cambio = cambio;
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            FrmProceso frmProceso = new FrmProceso();
            frmProceso.ShowDialog();
            this.Close();
        }
    }
}
