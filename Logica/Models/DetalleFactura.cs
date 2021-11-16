using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    class DetalleFactura
    {
        // Atributos de la clase
        public Producto MiProducto { get; set; }
        public float CantidadFacturada { get; set; }
        public float CantidadDespachada { get; set; }
        public float Costo { get; set; }
        public int IDSucursal { get; set; }
        public int IDFactura { get; set; }


        // Métodos
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

        public DataTable Listar()
        {
            DataTable R = new DataTable();

            return R;
        }
    }
}
