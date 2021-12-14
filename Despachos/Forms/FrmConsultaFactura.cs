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
    public partial class FrmConsultaFactura : Form
    {

        public Logica.Models.Factura MiFacturaLocal { get; set; }
        public Controls.CtrlFacturas padre { get; set; }
        DataTable DetalleFactura = new DataTable();
        public Logica.Models.DetalleFactura MiDetalle { get; set; }

        public FrmConsultaFactura(Controls.CtrlFacturas parent, Logica.Models.Factura factura)
        {
            InitializeComponent();
            padre = parent;
            MiFacturaLocal = factura;
            MiDetalle = new Logica.Models.DetalleFactura();
            DetalleFactura = new DataTable();
        }

        public FrmConsultaFactura()
        {
            MiDetalle = new Logica.Models.DetalleFactura();
            DetalleFactura = new DataTable();
        }

        private void FrmConsultaFactura_Load(object sender, EventArgs e)
        {
            LblPedido.Text += MiFacturaLocal.Pedido;
            TxtCliente.Text = MiFacturaLocal.MiCliente.Nombre;
            TxtVendedor.Text = MiFacturaLocal.MiVendedor.Nombre;
            TxtTotal.Text = MiFacturaLocal.CostoTotal.ToString();
            LblFecha.Text += MiFacturaLocal.FechaHora.Date.ToString();
            LblHora.Text += MiFacturaLocal.FechaHora.Hour.ToString() + ":" + MiFacturaLocal.FechaHora.Minute.ToString() + ":" + MiFacturaLocal.FechaHora.Second.ToString();
            LlenarDetalleFactura();
        }

        private void LlenarDetalleFactura()
        {
            DetalleFactura = MiDetalle.ListarPorPedido(MiFacturaLocal.Pedido);
            DgvDetalleFactura.DataSource = DetalleFactura;
            DgvDetalleFactura.ClearSelection();
        }
    }
}
