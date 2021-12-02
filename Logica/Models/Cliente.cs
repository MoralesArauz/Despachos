using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Cliente
    {
        // Atributos de la clase Cliente
        public int IDCliente { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public bool Activo { get; set; }

        // Comportamientos de la clase
        public bool Agregar()
        {
            bool R = false;

            return R;
        }

        public bool ConsultarPorCedula()
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

        public DataTable Listar(bool VerActivos = true,string ciudad = "")
        {
            DataTable R = new DataTable();
            Conexion MiCnn = new Conexion();
            // Se agregan los parámetros necesarios del procedimiento almacenado.
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@VerActivos", VerActivos));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Ciudad", ciudad));
 
            R = MiCnn.DMLSelect("SPClientesListar");
            return R;
        }

        public DataTable ListarCiudades()
        {
            DataTable R = new DataTable();
            Conexion MiCnn = new Conexion();
            R = MiCnn.DMLSelect("SPClientesListarCiudades");
            return R;
        }
    }
}
