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
    public partial class FrmProductosBuscar : Form
    {
        public Logica.Models.Producto MiProducto { get; set; }
        public DataTable DTListaProductos { get; set; }
        public FrmProductosBuscar()
        {
            InitializeComponent();
            MiProducto = new Logica.Models.Producto();
            DTListaProductos = new DataTable();
        }

        private void FrmProductosBuscar_Load(object sender, EventArgs e)
        {
            LlenarListaProductos();
        }

        private void LlenarListaProductos(string filtro="")
        {
            DTListaProductos = new DataTable();
            DTListaProductos = MiProducto.Listar(true,filtro);
            DgvProductos.DataSource = DTListaProductos;
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            if (DgvProductos.Rows.Count > 0 && DgvProductos.SelectedRows.Count == 1)
            {
                string IDProducto = Convert.ToString(DgvProductos.SelectedRows[0].Cells["CIDProducto"].Value);
                string Descripcion = Convert.ToString(DgvProductos.SelectedRows[0].Cells["CDescripcion"].Value);
                double Costo = Convert.ToDouble(DgvProductos.SelectedRows[0].Cells["CCosto"].Value);
                double Impuesto = Convert.ToDouble(DgvProductos.SelectedRows[0].Cells["CImpuesto"].Value);
                // Una vez que he capturado la información necesaria de las columnas del DataGridView
                // puedo pasar estos al objeto local MiFactura
                Commons.ObjetosGlobales.MiFormFactura.MiFactura.MiProducto = new Logica.Models.Producto
                {
                    IDProducto = IDProducto,
                    Descripcion = Descripcion,
                    Costo = Costo,
                    Impuesto = Impuesto
                };

                // Esto cierra el form y retorna una respuesta al formulario que lo invocó
                this.DialogResult = DialogResult.OK;

            }
        }
    }
}
