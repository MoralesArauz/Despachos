using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Producto : ICrudBase
    {
        // Atributos de la clase
        public string IDProducto { get; set; }
        public string Descripcion { get; set; }
        public Decimal Costo { get; set; }
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

        public Producto ConsultarPorCodigo(string CodigoProducto)
        {
            Producto R = new Producto();
            if (!string.IsNullOrEmpty(CodigoProducto))
            {
                Conexion MiCnn = new Conexion();
                MiCnn.ListadoDeParametros.Add(new SqlParameter("@CodigoProducto",CodigoProducto));
                DataTable resultado = MiCnn.DMLSelect("SPProductoBuscarPorCodigo");
                if (resultado != null && resultado.Rows.Count > 0)
                {
                    DataRow Fila = resultado.Rows[0];
                    R.IDProducto = Convert.ToString(Fila["IDProducto"]);
                    R.Descripcion = Convert.ToString(Fila["Descripcion"]);
                    R.MiCategoria.IDCategoria = Convert.ToInt32(Fila["IDCategoria"]);
                    R.Costo = Convert.ToDecimal(Fila["Costo"]);
                    
                }
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
        // Devuelve la lista de los productos de la base de datos
        public DataTable Listar(bool VerActivos = true, string filtro="")
        {
            DataTable R = new DataTable();
            Conexion MiCnn = new Conexion();
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@VerActivos", VerActivos));
            R = MiCnn.DMLSelect("SPProductosListar");

            return R;

        }
    }
}
