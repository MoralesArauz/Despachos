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

        public static Logica.Models.Usuario MiUsuarioDeSistema = new Logica.Models.Usuario();

        public static Forms.FrmFacturaGestion MiFormFactura = new Forms.FrmFacturaGestion();

        //public static Forms.FrmClienteBuscar MiFormClienteBuscar = new Forms.FrmClienteBuscar();
    }
}
