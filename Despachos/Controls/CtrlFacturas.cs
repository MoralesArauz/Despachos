using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Despachos.Controls
{
    public partial class CtrlFacturas : UserControl
    {
        public Logica.Models.Factura MiFactura { get; set; }
        public DataTable ListaFacturas { get; set; }
        public CtrlFacturas()
        {
            InitializeComponent();
            MiFactura = new Logica.Models.Factura();
            ListaFacturas = new DataTable();
        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Si el formulario ya se ha abierto y se intenta abrir de nuevo, entonces se trae al frente
            // De lo contrario se muestra.
            if (Commons.ObjetosGlobales.MiFormFactura.Visible)
            {
                Commons.ObjetosGlobales.MiFormFactura.BringToFront();
            }
            else
            {
                // Reinicia el formulario por si se ha cerrado anteriormente.
                Commons.ObjetosGlobales.MiFormFactura = new Forms.FrmFacturaGestion();

                Commons.ObjetosGlobales.MiFormFactura.ShowDialog();
            }
            LlenarListaFacturas();
        }

        private void CtrlFacturas_Load(object sender, EventArgs e)
        {
            LlenarListaFacturas();
        }

        public void LlenarListaFacturas()
        {
            ListaFacturas = MiFactura.Listar();
            DgvListaFacturas.DataSource = ListaFacturas;
            DgvListaFacturas.ClearSelection();
        }
    }
}
