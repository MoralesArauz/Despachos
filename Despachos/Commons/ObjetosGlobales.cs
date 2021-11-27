using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Despachos.Commons
{
    public static class ObjetosGlobales
    {
        public static Form MiFormPrincipal = new Forms.FrmMain();

        public static Form FormUsuarioGestion = new Forms.FrmUsuarioGestion();

        public static Logica.Models.Usuario MiUsuarioSistema = new Logica.Models.Usuario();
    }
}
