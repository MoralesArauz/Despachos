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
            PnlContenedor.Controls.Clear();
        }
    }
}
