using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class DetalleFactura
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

        public bool Editar()
        {
            bool R = false;

            return R;
        }

        public DataTable Listar()
        {
            DataTable R = new DataTable();

            return R;
        }
    }
}
