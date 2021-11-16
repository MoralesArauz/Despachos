using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    class CategoriaProducto : ICrudBase
    {
        // Atributos de la clase
        public int IDCategoria { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        // Métodos heredados
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
