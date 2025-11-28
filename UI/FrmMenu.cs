using CoffeeSur.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeSur.UI
{
    public partial class FrmMenu : Form
    {
        private Usuario usuarioLogueado;

        public FrmMenu(Usuario usuario)
        {
            InitializeComponent();
            usuarioLogueado = usuario;

            lblUsuario.Text = $"ADMIN: {usuario.Nombre} {usuario.Apellido}";
        }

        private void btnGestionUsuarios_Click(object sender, EventArgs e)
        {
            FrmGestionUsuarios frm = new FrmGestionUsuarios();
            frm.ShowDialog();
        }

        private void btnGestionProductos_Click(object sender, EventArgs e)
        {
            FrmGestionProductos frm = new FrmGestionProductos();
            frm.ShowDialog();
        }

        private void btnGestionVentas_Click(object sender, EventArgs e)
        {
            FrmGestionVentas frm = new FrmGestionVentas();
            frm.ShowDialog();
        }

        private void btnReportePorPedido_Click(object sender, EventArgs e)
        {

            FrmReportePorPeriodo frm = new FrmReportePorPeriodo();
            frm.ShowDialog();
        }

        private void btnReporteComparativo_Click(object sender, EventArgs e)
        {
            FrmReporteComparativo frm = new FrmReporteComparativo();
            frm.ShowDialog();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            FrmAuditorias frm = new FrmAuditorias();
            frm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Close();
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            FrmLogin login = new FrmLogin();
            login.Show();
        }
    }
}
