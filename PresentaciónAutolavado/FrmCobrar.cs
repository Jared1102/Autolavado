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
    public partial class FrmCobrar : Form
    {
        private ManejadorCobrador _manejadorCobrador;
        private double pago=0;
        public static Ticket ticket = null;
        private int[] contador = { 0, 0, 0, 0, 0, 0 };
        Random random = new Random();
        public FrmCobrar()
        {
            InitializeComponent();
            _manejadorCobrador = new ManejadorCobrador();
            txtFolio.Text = random.Next(1000, 9999).ToString();
            txtCobrando.Text = "$ "+FrmMenu.precio.ToString();
        }

        #region Funciones
        private void ActualizarPago()
        {
            lblPagando.Text = string.Format("Pagando: ${0}", pago);
        }
        #endregion

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (FrmMenu.precio > pago)
            {
                MessageBox.Show("El pago es insuficiente");
            }
            else
            {
                ticket = new Ticket
                {
                    Folio=txtFolio.Text,
                    Cobro=FrmMenu.precio,
                    Pago = pago,
                    Cambio = pago-FrmMenu.precio
                };
                MessageBox.Show("Gracias y vuelva pronto, no olvide su cambio");
                this.Hide();
                FrmCambio frmCambio = new FrmCambio();
                frmCambio.ShowDialog();
                this.Close();
            }
        }

        private void FrmCobrar_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            pago += 50;
            contador[0]++;
            lbl50.Text = string.Format("{0} x", contador[0]);
            ActualizarPago();
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            pago += 20;
            contador[1]++;
            lbl20.Text = string.Format("{0} x", contador[1]);
            ActualizarPago();
        }

        private void btnr10_Click(object sender, EventArgs e)
        {
            pago += 10;
            contador[2]++;
            lbl10.Text = string.Format("{0} x", contador[2]);
            ActualizarPago();
        }

        private void btnr5_Click(object sender, EventArgs e)
        {
            pago += 5;
            contador[3]++;
            lbl5.Text = string.Format("{0} x", contador[3]);
            ActualizarPago();
        }

        private void btnr2_Click(object sender, EventArgs e)
        {
            pago += 2;
            contador[4]++;
            lbl2.Text = string.Format("{0} x", contador[4]);
            ActualizarPago();
        }

        private void btnr1_Click(object sender, EventArgs e)
        {
            pago += 1;
            contador[5]++;
            lbl1.Text = string.Format("{0} x", contador[5]);
            ActualizarPago();
        }

        private void FrmCobrar_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
