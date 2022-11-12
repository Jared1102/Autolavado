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
    public partial class FrmMenu : Form
    {
        public static double precio = 0;
        public static Paquete paquete=null;
        private ManejadorLavado _manejadorLavado;
        public FrmMenu()
        {
            InitializeComponent();
            _manejadorLavado = new ManejadorLavado();
        }

        private void btnExpress_Click(object sender, EventArgs e)
        {
            precio = 30;
            FrmCobrar frmCobrar = new FrmCobrar();
            this.Hide();
            frmCobrar.ShowDialog();
            this.Show();
        }

        private void btnCera_Click(object sender, EventArgs e)
        {
            precio = 40;
            FrmCobrar frmCobrar = new FrmCobrar();
            this.Hide();
            frmCobrar.ShowDialog();
            this.Show();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            precio = 50;
            FrmCobrar frmCobrar = new FrmCobrar();
            this.Hide();
            frmCobrar.ShowDialog();
            this.Show();
        }
    }
}
