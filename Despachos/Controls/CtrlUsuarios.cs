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
                Commons.ObjetosGlobales.FormUsuarioGestion = new Forms.FrmUsuarioGestion();

                Commons.ObjetosGlobales.FormUsuarioGestion.Show();
            }

            
        }

        private void CtrlUsuarios_Load(object sender, EventArgs e)
        {
            LlenarListaUsuarios();
        }

        private void LlenarListaUsuarios()
        {
            ListaUsuarios = MiUsuarioLocal.Listar();
            DgvListaUsuarios.DataSource = ListaUsuarios;
            DgvListaUsuarios.ClearSelection();
        }
    }
}
