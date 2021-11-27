using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Producto : ICrudBase
    {
        // Atributos de la clase
        public int IDProducto { get; set; }
        public string Descripcion { get; set; }
        public float Costo { get; set; }
        public float Impuesto { get; set; }
        public float Precio { get; set; }
        public bool Activo { get; set; }
        public CategoriaProducto MiCategoria { get; set; }

        public Producto()
        {
            MiCategoria = new CategoriaProducto();
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

        public bool Eliminar()
        {
            bool R = false;

            return R;
        }

        public DataTable Listar(bool soloActivos = true)
        {
            DataTable R = new DataTable();

            return R;

        }
    }
}
