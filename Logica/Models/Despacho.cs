using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Despacho : ICrudBase
    {
        // Atributos de la clase
        public int IDDespacho { get; set; }
        public DateTime FechaHora { get; set; }
        public int IDFactura { get; set; }
        public int IDUsuario { get; set; }
        private List<DetalleDespacho> detalle;

        public bool Agregar()
        {
            bool R = false;

            return R;
        }

        public bool Consultar()
        {
            bool R = false;

            return R;
        }

        public bool Editar()
        {
            bool R = false;

            return R;
        }

        public bool Eliminar()
        {
            bool R = false;

            return R;
        }

        public DataTable Listar()
        {
            DataTable R = new DataTable();

            return R;
        }
    }
}
