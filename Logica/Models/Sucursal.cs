using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    class Sucursal : ICrudBase
    {

        // Atributos de la clase
        public int IDSucursal { get; set; }
        public string Nombre { get; set; }
        public string Abreviatura { get; set; }
        public string Direccion { get; set; }

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
    }
}
