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
    public partial class FrmUsuarioGestion : Form
    {
        // Este objeto se usará para obtener y asignar los valores que se 
        // mostrarán en el formulario.
        // Contendrá todas las funcionalidades 
        public Logica.Models.Usuario MiUsuarioLocal { get; set; }
        private Controls.CtrlUsuarios padre { get; set; }
        private bool UsuarioNuevo = true;

        public FrmUsuarioGestion()
        {
            InitializeComponent();
            MiUsuarioLocal = new Logica.Models.Usuario();
        }
        public FrmUsuarioGestion(Controls.CtrlUsuarios parent,Logica.Models.Usuario usuario=null)
        {
            InitializeComponent();
            MiUsuarioLocal = new Logica.Models.Usuario();
            this.padre = parent;
            // Esto es en caso de que se haya escogido un usuario para editarlo
            if (usuario!= null)
            {
                UsuarioNuevo = false;
                MiUsuarioLocal = usuario;
                MessageBox.Show("IDRol: " + MiUsuarioLocal.MiRol.IDRol, "Después de Abrir el FORM", MessageBoxButtons.OK);
            }
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuargar_Click(object sender, EventArgs e)
        {


            if (ValidarDatos())
            {
                // Verifica que se quiera agregar un usuario nuevo o editar uno existente
                if (UsuarioNuevo)
                {
                    bool OKUsuario = MiUsuarioLocal.ConsultarPorEmail();

                    if (!OKUsuario)
                    {
                        // El usuario no existe entonces se va a agregar
                        if (MiUsuarioLocal.Agregar())
                        {
                            MessageBox.Show("El Usuario se agregó correctamente!", "Agregado", MessageBoxButtons.OK);
                            LimpiarFormulario();
                            padre.LlenarListaUsuarios();
                        }
                        else
                        {
                            MessageBox.Show("El Usuario no se ha agregado!", "Error", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El correo ya existe en la Base de Datos por lo que no se ha agregado", "Error", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Estás tratando de Editar", "Editando", MessageBoxButtons.OK);
                }
                
            }
            
        }

        private void LlenarFormulario()
        {
            TxtNombre.Text = MiUsuarioLocal.Nombre;
            TxtCorreo.Text = MiUsuarioLocal.Correo;
            CbRol.SelectedIndex = MiUsuarioLocal.MiRol.IDRol;
 
            CheckBoxActivo.Checked = MiUsuarioLocal.Estado;
        }

        private void LimpiarFormulario()
        {
            TxtNombre.Clear();
            TxtCorreo.Clear();
            TxtContrasenia.Clear();
            CbRol.SelectedIndex = -1;
        }

        private void FrmUsuarioGestion_Load(object sender, EventArgs e)
        {
            // Este código se ejecuta al mostrar el form en pantalla
            // Se llenará la información de los roles
            CheckBoxActivo.Checked = true;
            CargarComboRoles();
            if (!UsuarioNuevo)
            {
                LlenarFormulario();
            }
        }

        private void CargarComboRoles()
        {
            // Se llenará el combobox con los roles existentes en la base de datos.
            DataTable DatosRoles = new DataTable();
            DatosRoles = MiUsuarioLocal.MiRol.Listar();
            CbRol.ValueMember = "ID";
            CbRol.DisplayMember = "Nombre";
            // Se asigna el origen los datos que mostrará el ComboBox
            CbRol.DataSource = DatosRoles;
            CbRol.SelectedIndex = -1;
        }

        private void TxtNombre_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtNombre.Text.Trim()))
            {
                MiUsuarioLocal.Nombre = TxtNombre.Text.Trim();
            }
        }

        private void TxtCorreo_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtCorreo.Text.Trim()))
            {
                MiUsuarioLocal.Correo = TxtCorreo.Text.Trim();
            }
        }

        private void TxtContrasenia_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtContrasenia.Text.Trim()))
            {
                MiUsuarioLocal.Contrasenia = TxtContrasenia.Text.Trim();
            }
        }

        private void CbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbRol.SelectedIndex >= 0)
            {
                MiUsuarioLocal.MiRol.IDRol = Convert.ToInt32(CbRol.SelectedValue);
            }
            else
            {
                CbRol.SelectedIndex = 0;
            }
        }


        private bool ValidarDatos()
        {
            bool R = false;
            string mensajeError = "";

            if (string.IsNullOrEmpty(MiUsuarioLocal.Nombre))
            {
                mensajeError += "El campo Nombre es obligatorio.\n";
                TxtNombre.Focus();
            }
            if (string.IsNullOrEmpty(MiUsuarioLocal.Correo))
            {
                mensajeError += "El campo Email es obligatorio.\n";
                TxtCorreo.Focus();
            }
            // La contraseña no se debe validar si estamos en modo edición
            // y no hemos escrito algo en la contraseña
            if (string.IsNullOrEmpty(MiUsuarioLocal.Contrasenia))
            {
                mensajeError += "El campo Contraseña es obligatorio.\n";
                TxtContrasenia.Focus();
            }
            if (MiUsuarioLocal.MiRol.IDRol <= 0)
            {
                mensajeError += "Debe escoger un Rol.\n";
            }

            if (string.IsNullOrEmpty(mensajeError))
            {
                // Si se cumplen los parámetros de validación se pasa el valor de R a true
                R = true;
            }
            else
            {
                //retroalimentar al usuario para indicar qué campo hace falta digitar
                MessageBox.Show(mensajeError, "Datos Insuficientes", MessageBoxButtons.OK);

            }

            return R;
        }
    }
}
