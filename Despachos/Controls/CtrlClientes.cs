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
    
    public partial class CtrlClientes : UserControl
    {
        public Logica.Models.Cliente MiCliente { get; set; }
        private DataTable ListaClientes { get; set; }

        private bool CargaInicial = true;
        public CtrlClientes()
        {
            InitializeComponent();
            MiCliente = new Logica.Models.Cliente();
            ListaClientes = new DataTable();
        }

        private void CtrlClientes_Load(object sender, EventArgs e)
        {
            CboxVerActivos.Checked = true;
            LlenarListaClientes();
            CargarComboBoxCiudades();
        }

        // Llena el DataGridView con la lista de clientes de la base de datos
        private void LlenarListaClientes(bool VerActivos = true, string ciudad="")
        {
            ListaClientes = MiCliente.Listar(VerActivos,ciudad);
            DgvListaClientes.DataSource = ListaClientes;
            DgvListaClientes.ClearSelection();
        }

        private void CboxVerActivos_Click(object sender, EventArgs e)
        {
            LlenarListaClientes(CboxVerActivos.Checked,CiudadEscogida());
        }

        private void CargarComboBoxCiudades()
        {
            // Se llenará el combobox con los roles existentes en la base de datos.
            DataTable DatosCiudades = new DataTable();
            DatosCiudades = MiCliente.ListarCiudades();
            // Inserta un valor más para poder quitar el filtro de ciudades
            DataRow dr = DatosCiudades.NewRow();
            dr["Direccion"] = "Todas";
            DatosCiudades.Rows.InsertAt(dr, 0);

            CbCiudades.DisplayMember = "Direccion";
            // Se asigna el origen los datos que mostrará el ComboBox
            CbCiudades.DataSource = DatosCiudades;
            CbCiudades.SelectedIndex = 0;
            CargaInicial = false;
        }

        private void CbCiudades_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!CargaInicial)
            {
                
                //MessageBox.Show(string.Format("La ciudad ha cambiado: {0}", ciudad), "Cambio de Ciudad", MessageBoxButtons.OK);
                LlenarListaClientes(CboxVerActivos.Checked,CiudadEscogida());
            }
        }

        private string CiudadEscogida()
        {
            // De esta manera obtenemos el texto del item seleccionado para aplicarlo
            // como filtro en el procedimiento almacenado
            DataRowView fila = CbCiudades.SelectedItem as DataRowView;
            string ciudad = "";

            if (fila != null)
            {
                ciudad = fila.Row["Direccion"] as string;
            }
            return ciudad;
        }
    }
}
