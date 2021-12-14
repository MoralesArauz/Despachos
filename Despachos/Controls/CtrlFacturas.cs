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

                Commons.ObjetosGlobales.MiFormFactura.Show();
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

        private void refrescarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LlenarListaFacturas();
        }

        private void DgvListaFacturas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListaFacturas.SelectedRows.Count == 1)
            {
                //LimpiarFormulario(false);

                DataGridViewRow MiFila = DgvListaFacturas.SelectedRows[0];
                // Asignar el valor del ID a MiUsuarioLocal para hacer la búsqueda en la base de datos y traer el valor de sus campos en la tabla
                MiFactura = new Logica.Models.Factura();
                MiFactura.Pedido = MiFila.Cells["CPedido"].Value.ToString();
                MiFactura.MiCliente.Nombre = MiFila.Cells["CCliente"].Value.ToString();
                MiFactura.MiVendedor.Nombre = MiFila.Cells["CVendedor"].Value.ToString();
                MiFactura.CostoTotal = (float)Convert.ToDouble( MiFila.Cells["CTotal"].Value.ToString());
                MiFactura.FechaHora = Convert.ToDateTime(MiFila.Cells["CFecha"].Value.ToString());
                // Aquí se cargan los atributos de MiUsuarioLocal
                //MiFactura = MiFactura.ConsultarPorPedido();
            }
        }

        private void DgvListaFacturas_DoubleClick(object sender, EventArgs e)
        {
            if (Commons.ObjetosGlobales.MiConsultaFactura.Visible)
            {
                Commons.ObjetosGlobales.MiConsultaFactura.BringToFront();
            }
            else
            {
                // Reinicia el formulario por si se ha cerrado anteriormente.

                Commons.ObjetosGlobales.MiConsultaFactura = new Forms.FrmConsultaFactura(this, MiFactura);

                Commons.ObjetosGlobales.MiConsultaFactura.Show();

            }
        }
    }
}
