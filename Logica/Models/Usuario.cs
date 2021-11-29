using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Usuario : ICrudBase
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
            Conexion MiCnn = new Conexion();
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Nombre",Nombre));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Correo",Correo));
            // La contraseña debe de encriptarse
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Contrasenia",Contrasenia));
            // Debemos enviar el valor del IDRol por medio de la composición
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@IDRol",MiRol.IDRol));
            int resultado = MiCnn.DMLUpdateDeleteInsert("SPUsuarioAgregar");

            if (resultado > 0)
            {
                R = true;
            }

            return R;
        }


        public Usuario Consultar()
        {
            Usuario R = new Usuario();
            Conexion MiCnn = new Conexion();

            //Asigna el valor del ID para hacer la búsqueda en la BD 
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@ID",this.IDUsuario));

            DataTable retorno = MiCnn.DMLSelect("SPUsuarioConsultar");
            if (retorno != null && retorno.Rows.Count > 0)
            {
                DataRow Fila = retorno.Rows[0];

                R.IDUsuario = this.IDUsuario;
                R.Nombre = Convert.ToString(Fila["Nombre"]);
                R.Correo = Convert.ToString(Fila["Correo"]);
                R.Contrasenia = Convert.ToString(Fila["Contrasenia"]);
                R.Estado = Convert.ToBoolean(Fila["Activo"]);
                // Aquí hay un conflicto para poder editar la contraseña
                //R.Contrasennia = string.Empty;
                //R.Contrasennia = Convert.ToString(Fila["Contrasennia"]);
                R.MiRol.IDRol = Convert.ToInt32(Fila["IDRol"]);
            } 
            return R;
        }

        public bool ConsultarPorEmail()
        {
            bool R = false;
            Conexion MiCnn = new Conexion();

            //Asigna el valor del ID para hacer la búsqueda en la BD 
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@EMAIL", this.Correo));

            DataTable retorno = MiCnn.DMLSelect("SPUsuarioConsultarPorEmail");
            if (retorno != null && retorno.Rows.Count > 0)
            {
                R = true;
            }
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
            Conexion MiCnn = new Conexion();
            R = MiCnn.DMLSelect("SPUsuariosListar");
            return R;
        }

        bool ICrudBase.Consultar()
        {
            throw new NotImplementedException();
        }
    }
}
