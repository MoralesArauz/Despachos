using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Factura : ICrudBase
    {
        public List<DetalleFactura> DetalleLineas { get; set; }
        public Cliente MiCliente { get; set; }
        public Vendedor MiVendedor { get; set; }
        public Producto MiProducto { get; set; }
        public string Observaciones { get; set; }
        public float CostoTotal { get; set; }


        public Factura()
        {
            DetalleLineas = new List<DetalleFactura>();
            MiCliente = new Cliente();
            MiVendedor = new Vendedor();
        }
        public bool Agregar()
        {
            bool R = false;
            Conexion MiCnn = new Conexion();
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@IDCliente",MiCliente.IDCliente));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@IDVendedor", MiVendedor.IDVendedor));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@CostoTotal", CostoTotal));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Observaciones", Observaciones));

            int resultado = MiCnn.DMLUpdateDeleteInsert("SPFacturaAgregar");

            if (resultado > 0)
            {
                R = true;
            }

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

        public DataTable Listar()
        {
            DataTable R = new DataTable();
            Conexion MiCnn = new Conexion();
            R = MiCnn.DMLSelect("SPFacturasListar");

            return R;
        }

        public string ConsecutivoFactura(int IDVendedor)
        {
            string R = "";
            if (IDVendedor > 0)
            {
                Conexion MiCnn = new Conexion();
                MiCnn.ListadoDeParametros.Add(new SqlParameter("@IDVendedor", IDVendedor));
                Object consecutivo = MiCnn.DMLConRetornoEscalar("SPFacturaConsecutivo");
                R = consecutivo.ToString();
            }

            return R;
        }
    }
}
