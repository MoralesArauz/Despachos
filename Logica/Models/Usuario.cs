using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    class Usuario : ICrudBase
    {

        // Atributos de la clase Usuario

        public int IDUsuario { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Contrasenia { get; set; }
        public bool Estado { get; set; }

        public Rol MiRol { get; set; }


        public Usuario()
        {
            MiRol = new Rol();
        }
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
