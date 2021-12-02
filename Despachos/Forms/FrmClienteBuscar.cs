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
    public partial class FrmClienteBuscar : Form
    {
        public Logica.Models.Cliente MiCliente { get; set; }
        public DataTable DtLista { get; private set; }

        public FrmClienteBuscar()
        {
            InitializeComponent();
            MiCliente = new Logica.Models.Cliente();
            DtLista = new DataTable();
        }

        private void FrmClienteBuscar_Load(object sender, EventArgs e)
        {
            LlenarListaClientes();
        }


        private void LlenarListaClientes(string Filtro = "")
        {
            DtLista = new DataTable();
            DtLista = MiCliente.Listar();
            DgvListaClientes.DataSource = DtLista;
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            if (DgvListaClientes.Rows.Count > 0 && DgvListaClientes.SelectedRows.Count == 1)
            {
                int IDCliente = Convert.ToInt32(DgvListaClientes.SelectedRows[0].Cells["CID"].Value);
                string NombreCliente = Convert.ToString(DgvListaClientes.SelectedRows[0].Cells["CNombre"].Value);
                string ApellidoCliente = Convert.ToString(DgvListaClientes.SelectedRows[0].Cells["CApellido"].Value);
                // Una vez que he capturado la información necesaria de las columnas del DataGridView
                // puedo pasar estos al objeto local MiFactura
                Commons.ObjetosGlobales.MiFormFactura.MiFactura.MiCliente.IDCliente = IDCliente;
                Commons.ObjetosGlobales.MiFormFactura.MiFactura.MiCliente.Nombre = NombreCliente;
                Commons.ObjetosGlobales.MiFormFactura.MiFactura.MiCliente.Apellido = ApellidoCliente;

                // Esto cierra el form y retorna una respuesta al formulario que lo invocó
                this.DialogResult = DialogResult.OK;

            }
        }
    }
}
