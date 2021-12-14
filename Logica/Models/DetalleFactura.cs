using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class DetalleFactura : IEquatable<DetalleFactura>
    {
        // Atributos de la clase
        public Producto MiProducto { get; set; }
        public double CantidadFacturada { get; set; }
        public double CantidadDespachada { get; set; }
        public double Costo { get; set; }
        public double Precio { get; set; }
        public int IDSucursal { get; set; }
        public int IDFactura { get; set; }

        // Constructor con parámetros
        public DetalleFactura(Producto producto, double facturado, double despachado, double costo,double precio, int sucursal, int factura)
        {
            this.MiProducto = producto;
            this.CantidadDespachada = despachado;
            this.CantidadFacturada = facturado;
            this.Costo = costo;
            this.Precio = precio;
            this.IDSucursal = sucursal;
            this.IDFactura = factura;
        }

        public DetalleFactura()
        {
            MiProducto = new Producto();
        }

        // Métodos
        public bool Agregar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            // Se agregan los parámetros necesarios para el insert
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@IDFactura",IDFactura));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@IDProducto", MiProducto.IDProducto));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@CantidadFacturada", CantidadFacturada));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@CantidadDespachada", CantidadDespachada));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Costo", MiProducto.Costo));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@IDSucursal", IDSucursal));

            // Se ejecuta el SP
            int resultado = MiCnn.DMLUpdateDeleteInsert("SPDetalleFacturaAgregar");
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

        public DataTable ListarPorPedido(string pedido)
        {
            DataTable R = new DataTable();
            Conexion MiCnn = new Conexion();
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Pedido",pedido));
            R = MiCnn.DMLSelect("SPDetalleFacturaListar");
            return R;
        }

        public bool Equals(DetalleFactura other)
        {
            if (other == null)
            {
                return false;
            }
            else if (other.MiProducto.IDProducto == MiProducto.IDProducto)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return MiProducto.IDProducto + " " +MiProducto.Descripcion + " " +CantidadFacturada;
        }
    }
}
