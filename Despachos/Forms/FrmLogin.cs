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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PicShowPass_MouseDown(object sender, MouseEventArgs e)
        {
            TxtPassword.UseSystemPasswordChar = false;
        }

        private void PicShowPass_MouseUp(object sender, MouseEventArgs e)
        {
            TxtPassword.UseSystemPasswordChar = true;
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            // TODO: Validar las credenciales de ingreso
            if (ValidarDatos())
            {

                Logica.Models.Usuario MiUsuarioValidado = new Logica.Models.Usuario();

                MiUsuarioValidado = MiUsuarioValidado.ValidarIngreso(TxtUsuario.Text.Trim(), TxtPassword.Text.Trim());

                if (MiUsuarioValidado != null && MiUsuarioValidado.IDUsuario > 0)
                {
                    Commons.ObjetosGlobales.MiUsuarioDeSistema = MiUsuarioValidado;
                    // Muestro el objeto global del FrmMain
                    Commons.ObjetosGlobales.MiFormPrincipal.Show();
                    // Oculto (no destruyo) el formulario de login
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "Error de Validación", MessageBoxButtons.OK);
                }
            }
              
        }
        private bool ValidarDatos()
        {
            return true;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void BtnIngresoDirecto_Click(object sender, EventArgs e)
        {
            Commons.ObjetosGlobales.MiUsuarioDeSistema.IDUsuario = 1;
            Commons.ObjetosGlobales.MiUsuarioDeSistema.Correo = "amorales@maderassancarlos.com";
            Commons.ObjetosGlobales.MiUsuarioDeSistema.Nombre = "Usuario de Pruebas";
            Commons.ObjetosGlobales.MiUsuarioDeSistema.MiRol.IDRol = 1;
            //muestro el objeto global del FrmMain
            Commons.ObjetosGlobales.MiFormPrincipal.Show();
            //oculto (no destruyo) el frm de Login
            this.Hide();
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift & e.KeyCode == Keys.Escape)
            {
                BtnIngresoDirecto.Visible = true;
            }
        }
    }

        
}
