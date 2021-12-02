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
    public partial class CtrlProductos : UserControl
    {
        public Logica.Models.Producto MiProducto { get; set; }
        public DataTable ListaProductos { get; set; }
        public CtrlProductos()
        {
            InitializeComponent();
            MiProducto = new Logica.Models.Producto();
            ListaProductos = new DataTable();
        }

        private void CtrlProductos_Load(object sender, EventArgs e)
        {
            CBoxVerActivos.Checked = true;
            LlenarListaProductos();
        }

        private void LlenarListaProductos(bool activos = true)
        {
            ListaProductos = MiProducto.Listar(activos);
            DgvListaProductos.DataSource = ListaProductos;
            DgvListaProductos.ClearSelection();
        }

        private void CBoxVerActivos_Click(object sender, EventArgs e)
        {
            LlenarListaProductos(CBoxVerActivos.Checked);
        }
    }
}
