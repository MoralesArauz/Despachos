using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Despachos.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            //System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-ES");
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            // TODO: Volver a iniciar sesión?
            Application.Exit();
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            UserControl ControlUsuarios = new Controls.CtrlUsuarios();
            PnlContenedor.Controls.Clear();
            ControlUsuarios.Dock = DockStyle.Fill;
            PnlContenedor.Controls.Add(ControlUsuarios);
        }

        private void BtnFacturas_Click(object sender, EventArgs e)
        {
            UserControl ControlFacturas = new Controls.CtrlFacturas();
            PnlContenedor.Controls.Clear();
            ControlFacturas.Dock = DockStyle.Fill;
            PnlContenedor.Controls.Add(ControlFacturas);
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            
            UserControl ControlProductos = new Controls.CtrlProductos();
            PnlContenedor.Controls.Clear();
            ControlProductos.Dock = DockStyle.Fill;
            PnlContenedor.Controls.Add(ControlProductos);
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            UserControl ControlClientes = new Controls.CtrlClientes();
            PnlContenedor.Controls.Clear();
            ControlClientes.Dock = DockStyle.Fill;
            PnlContenedor.Controls.Add(ControlClientes);
        }
    }
}
