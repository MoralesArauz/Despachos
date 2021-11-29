using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Rol : ICrudBase
    {
        // Atributos de la clase Rol
        public int IDRol { get; set; }
        public string Nombre { get; set; }

        public string Descripcion { get; set; }


        // Métodos de la clase Roll

        // Agrega un nuevo Rol a la base de datos
        public bool Agregar()
        {
            bool R = false;

            return R;
        }

        // Elimina(inactiva) un Rol de la base de datos.
        public bool Eliminar()
        {
            bool R = false;

            return R;
        }

        // Edita un Rol en la base de datos.
        public bool Editar()
        {
            bool R = false;

            return R;
        }

        // Consulta por un Rol en específico
        public bool Consultar()
        {
            bool R = false;

            return R;
        }

        // Retorna un DataTable con la lista de todos los roles, se puede decidir
        // si muestra solo los roles activos o todos los roles

        public DataTable Listar(bool soloActivos = true)
        {
            DataTable R = new DataTable();
            // SDUsuarioRolListar
            Conexion MiCnn = new Conexion();
            R = MiCnn.DMLSelect("SPUsuarioRolListar");

            return R;
        }
    }
}
