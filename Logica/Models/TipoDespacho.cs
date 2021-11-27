using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class TipoDespacho : ICrudBase
    {
        // Atributos de la clase
        public int IDTipoDespacho { get; set; }
        public string Abreviatura { get; set; }
        public string Descripcion { get; set; }


        // Métodos de la clase
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

        public DataTable Listar(bool soloActivos=true)
        {
            DataTable R = new DataTable();

            return R;
        }
    }
}
