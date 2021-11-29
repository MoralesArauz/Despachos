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
    public partial class CtrlUsuarios : UserControl
    {
        private Logica.Models.Usuario MiUsuarioLocal { get; set; }

        private DataTable ListaUsuarios { get; set; }

        public CtrlUsuarios()
        {
            InitializeComponent();

            // Se inicializan los componentes del UserControl
            MiUsuarioLocal = new Logica.Models.Usuario();
            ListaUsuarios = new DataTable();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Si el formulario ya se ha abierto y se intenta abrir de nuevo, entonces se trae al frente
            // De lo contrario se muestra.
            if (Commons.ObjetosGlobales.FormUsuarioGestion.Visible)
            {
                Commons.ObjetosGlobales.FormUsuarioGestion.BringToFront();
            }
            else
            {
                // Reinicia el formulario por si se ha cerrado anteriormente.
                Commons.ObjetosGlobales.FormUsuarioGestion = new Forms.FrmUsuarioGestion(this);

                Commons.ObjetosGlobales.FormUsuarioGestion.Show();
                
            }            
        }

        private void CtrlUsuarios_Load(object sender, EventArgs e)
        {
            LlenarListaUsuarios();    
        }

        public void LlenarListaUsuarios()
        {
            ListaUsuarios = MiUsuarioLocal.Listar();
            DgvListaUsuarios.DataSource = ListaUsuarios;
            DgvListaUsuarios.ClearSelection();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarUsuario();
        }
        // Modifica los valores del Usuario, incluso lo borra(inactiva)
        private void EditarUsuario()
        {
            //string usuario = string.Format("ID: {0}\nNombre: {1}\nCorreo: {2}\nRol: {3}\nEstado:{4}", MiUsuarioLocal.IDUsuario, MiUsuarioLocal.Nombre, MiUsuarioLocal.Correo, MiUsuarioLocal.MiRol.IDRol,MiUsuarioLocal.Estado);
            //MessageBox.Show(usuario, "Prueba", MessageBoxButtons.OK);
            // Si el formulario ya se ha abierto y se intenta abrir de nuevo, entonces se trae al frente
            // De lo contrario se muestra.
            if (Commons.ObjetosGlobales.FormUsuarioGestion.Visible)
            {
                Commons.ObjetosGlobales.FormUsuarioGestion.BringToFront();
            }
            else
            {
                // Reinicia el formulario por si se ha cerrado anteriormente.
                
                Commons.ObjetosGlobales.FormUsuarioGestion = new Forms.FrmUsuarioGestion(this, MiUsuarioLocal);

                Commons.ObjetosGlobales.FormUsuarioGestion.Show();

            }
        }

        private void DgvListaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (DgvListaUsuarios.SelectedRows.Count == 1)
            {
                //LimpiarFormulario(false);

                DataGridViewRow MiFila = DgvListaUsuarios.SelectedRows[0];
                // Asignar el valor del ID a MiUsuarioLocal para hacer la búsqueda en la base de datos y traer el valor de sus campos en la tabla
                MiUsuarioLocal.IDUsuario = Convert.ToInt32(MiFila.Cells["CID"].Value);
               
                // Aquí se cargan los atributos de MiUsuarioLocal
                MiUsuarioLocal = MiUsuarioLocal.Consultar();
            }
        }
    }
}
