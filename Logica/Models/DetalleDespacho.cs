using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class DetalleDespacho 
    {
        // Atributos de la clase
        public Producto MiProducto { get; set; }
        public float CantidadDespachada { get; set; }
        public int IDDespacho { get; set; }
        public DetalleDespacho(Producto producto, float cantidad)
        {
            this.MiProducto = producto;
            this.CantidadDespachada = cantidad;
        }
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
