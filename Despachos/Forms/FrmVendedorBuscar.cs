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
    public partial class FrmVendedorBuscar : Form
    {
        public DataTable DtLista { get; set; }
        public Logica.Models.Vendedor MiVendedor { get; set; }
        public FrmVendedorBuscar()
        {
            InitializeComponent();
            DtLista = new DataTable();
            MiVendedor = new Logica.Models.Vendedor();
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            if (DgvListaVendedores.Rows.Count > 0 && DgvListaVendedores.SelectedRows.Count == 1)
            {
                int IDVendedor = Convert.ToInt32(DgvListaVendedores.SelectedRows[0].Cells["CID"].Value);
                int IDSucursal = Convert.ToInt32(DgvListaVendedores.SelectedRows[0].Cells["CIDSuc"].Value);
                string NombreVendedor = Convert.ToString(DgvListaVendedores.SelectedRows[0].Cells["CNombre"].Value);
                string ApellidoVendedor = Convert.ToString(DgvListaVendedores.SelectedRows[0].Cells["CApellido"].Value);
                // Una vez que he capturado la información necesaria de las columnas del DataGridView
                // puedo pasar estos al objeto local MiFactura
                Commons.ObjetosGlobales.MiFormFactura.MiFactura.MiVendedor.IDVendedor = IDVendedor;
                Commons.ObjetosGlobales.MiFormFactura.MiFactura.MiVendedor.Nombre = NombreVendedor;
                Commons.ObjetosGlobales.MiFormFactura.MiFactura.MiVendedor.Apellido = ApellidoVendedor;
                Commons.ObjetosGlobales.MiFormFactura.MiFactura.MiVendedor.MiSucursal.IDSucursal = IDSucursal;

                // Esto cierra el form y retorna una respuesta al formulario que lo invocó
                this.DialogResult = DialogResult.OK;

            }

        }

        private void LlenarListaVendedores()
        {
            DtLista = new DataTable();
            DtLista = MiVendedor.Listar();
            DgvListaVendedores.DataSource = DtLista;
        }

        private void FrmVendedorBuscar_Load(object sender, EventArgs e)
        {
            LlenarListaVendedores();
        }
    }
}
