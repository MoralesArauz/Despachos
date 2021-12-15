using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Despachos.Commons
{
    public static class ObjetosGlobales
    {


        private static char DecimalSeparator = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator.ToString());

        const string EmailRegex =
        @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
        + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
		[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
        + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
		[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
        + @"([a-zA-Z0-9]+[\w-]+\.)+[a-zA-Z]{1}[a-zA-Z0-9-]{1,23})$";


        // Expresiones regulares para validar la contraseña
        static Regex tieneNumeros = new Regex(@"[0-9]+");
        static Regex extraeNumeros = new Regex(@"\d+", RegexOptions.IgnoreCase | RegexOptions.Compiled);
        static Regex tieneMayusculas = new Regex(@"[A-Z]+");
        static Regex limiteCaracteres = new Regex(@".{8,15}");
        static Regex tieneMinusculas = new Regex(@"[a-z]+");
        static Regex tieneSimbolos = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");
        static Regex simbolos = new Regex(@"[!#$ %&'()*+,-.·/:;<=>?@[\]^_`{|}]");
        





        public static bool ValidarEmail(string email)
        {
            if (email != null)
            {
                return Regex.IsMatch(email, EmailRegex);
            }
            else
            { return false; }

        }


        public static bool CaracteresNumeros(System.Windows.Forms.KeyPressEventArgs c, bool SoloEnteros = true)
        {
            //En el caso que presione enter acepta el valor y devuelve True
            int Asc = (int)Keys.Enter;

            if (c.KeyChar == Asc)
            {
                return true;
            }
            if (SoloEnteros == false)
            {
                if (c.KeyChar.ToString() == (".") | c.KeyChar.ToString() == (","))
                {
                    c.KeyChar = DecimalSeparator;
                    return false;
                }
            }

            if (!(char.IsDigit(c.KeyChar)) & !(c.KeyChar == Convert.ToChar(Keys.Back)) & !(c.KeyChar == Convert.ToChar(Keys.Enter)))
            { return true; }
            else
            { return false; }

        }

        public static bool CaracteresTexto(System.Windows.Forms.KeyPressEventArgs c, bool Mayusculas = false, bool Minisculas = false)
        {
            bool ret = false;

            if (Mayusculas)
            { c.KeyChar = char.ToUpper(c.KeyChar); }

            if (Minisculas)
            { c.KeyChar = char.ToLower(c.KeyChar); }

            if (!(char.IsLetterOrDigit(c.KeyChar)) & !(char.IsPunctuation(c.KeyChar)) & !(c.KeyChar == Convert.ToChar(Keys.Back)) & !(c.KeyChar == Convert.ToChar(Keys.Space)) & !(c.KeyChar == Convert.ToChar(Keys.Enter)))
                ret = true;
            else
                ret = false;
            return
            ret;

        }


        //Verifica si la contraseña tiene números pares
        public static bool ValidarNumerosPares(string contrasenia)
        {
            bool R = false;

            if (!tieneNumeros.IsMatch(contrasenia))
            {
                return true;
            }

            MatchCollection collection = extraeNumeros.Matches(contrasenia);//en el texto que vamos a buscar
            foreach (Match m in collection)
            {
                //por cada nro obtenido con la expresion regular,comparamos si es par o no
                if (Int32.Parse(m.Value) % 2 == 0)
                    // Encontró un número par
                    return true;
            }

            return R;
        }

        /*
            Mínimo 8 caracteres. 
            Debe tener mayúsculas. 
            Debe tener minúsculas. 
            Debe tener caracteres especiales como : !"·$%&/()=
            Debe tener números impares. 
         */
        public static bool ValidarPassword(string contrasennia)
        {

            if (string.IsNullOrWhiteSpace(contrasennia))
            {
                throw new Exception("Contraseña vacía");
            }


            if (!tieneMinusculas.IsMatch(contrasennia))
            {
                MessageBox.Show("La contraseña debe tener al menos una letra minúsculas", "Error", MessageBoxButtons.OK);
                return false;
            }
            else if (!tieneMayusculas.IsMatch(contrasennia))
            {
                MessageBox.Show("La contraseña debe tener letras mayúsculas", "Error", MessageBoxButtons.OK);
                return false;
            }
            else if (!limiteCaracteres.IsMatch(contrasennia))
            {
                MessageBox.Show("La contraseña debe tener entre 8 y 12 caracteres", "Error", MessageBoxButtons.OK);
                return false;
            }
            else if (ValidarNumerosPares(contrasennia))
            {
                MessageBox.Show("La contraseña debe tener solo números impares", "Error", MessageBoxButtons.OK);
                return false;
            }

            else if (!simbolos.IsMatch(contrasennia))
            {
                MessageBox.Show("La contraseña debe tener símbolos", "Error", MessageBoxButtons.OK);
                return false;
            }
            else
            {
                return true;
            }
        }




        public static Form MiFormPrincipal = new Forms.FrmMain();

        public static Form FormUsuarioGestion = new Forms.FrmUsuarioGestion();

        public static Logica.Models.Usuario MiUsuarioDeSistema = new Logica.Models.Usuario();

        public static Forms.FrmFacturaGestion MiFormFactura = new Forms.FrmFacturaGestion();

        public static Forms.FrmConsultaFactura MiConsultaFactura = new Forms.FrmConsultaFactura();


        // Expresiones regulares para validaciones

        //Limita los números ingresados en campos como precio, cantidad, costo
        static Regex LimiteNumeros = new Regex(@"^\d{1-10}\.\d{4}$");

        //public static Forms.FrmClienteBuscar MiFormClienteBuscar = new Forms.FrmClienteBuscar();
    }
}
