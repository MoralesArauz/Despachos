using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Despachos.Forms
{
    public partial class FrmFacturaGestion : Form
    {

        public Logica.Models.Factura MiFactura { get; set; }
        public Logica.Models.DetalleFactura MiDetalleFactura { get; set; }

        // para llevar la cuenta de las líneas agregadas a la factura
        public int cont_fila { get; set; }
        public FrmFacturaGestion()
        {
            InitializeComponent();
            MiFactura = new Logica.Models.Factura();
            MiDetalleFactura = new Logica.Models.DetalleFactura();
            cont_fila = 0;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmFacturaGestion_Load(object sender, EventArgs e)
        {
            
        }
        //Valida que el el TextBox del precio se ingresen solo números y un punto decimal
        //private bool ValidarDecimal()
        //{
        //    int count = 0, len = TxtCantidad.Text.Length;
        //    //Si el punto está en el inicio o final del texto ...
        //    if (TxtCantidad.Text[0] == '.' || TxtCantidad.Text[len - 1] == '.')
        //        return false;
        //    for (int i = 0; i != len; ++i)
        //    {
        //        //Si es un punto, contamos ...
        //        if (TxtCantidad.Text[i] == '.')
        //            ++count;
        //        //Si no es un caracter númerico ...
        //        else if (!(TxtCantidad.Text[i] >= '0' && TxtCantidad.Text[i] <= '9'))
        //            return false;

        //        if (count > 1) //Si hay más de un punto decimal.
        //            return false;
        //    }
        //    return true;
        //}


        //private bool LimitarNumeros()
        //{
        //    int len = TxtCantidad.Text.Length;
        //    int count = 0;
        //    bool point = false;
        //    for (int i = 0; i != len; ++i)
        //    {
        //        ++count;
        //        if (TxtCantidad.Text[i] == '.')
        //        {
        //            count = 0;
        //            point = true;
        //        }
        //        //Si hay más de 9 enteros o más de dos decimales.
        //        else if ((point && count > 2) || (!point && count > 9))
        //            return false;
        //    }
        //    return true;
        //}

        private bool ValidarDatos()
        {
            bool R = false;
            if (MiFactura.MiCliente.IDCliente > 0 &&
                MiFactura.MiVendedor.IDVendedor > 0 &&
                !string.IsNullOrEmpty(TxtTotal.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtObservaciones.Text.Trim()))
            {
                R = true;
            }
            else
            {
                if (MiFactura.MiCliente.IDCliente <= 0)
                {
                    MessageBox.Show("Debe escoger un cliente para la factura","Datos insuficientes",MessageBoxButtons.OK);
                    TxtCliente.Focus();
                    return false;
                }
                if (MiFactura.MiVendedor.IDVendedor <= 0)
                {
                    MessageBox.Show("Debe escoger un vendedor para la factura", "Datos insuficientes", MessageBoxButtons.OK);
                    TxtVendedor.Focus();
                    return false;
                }
                // Es temporal
                if (string.IsNullOrEmpty(TxtTotal.Text.Trim()))
                {
                    MessageBox.Show("Falta el total de la factura", "Datos insuficientes", MessageBoxButtons.OK);
                    TxtTotal.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(TxtObservaciones.Text.Trim()))
                {
                    MessageBox.Show("Debe especificar el detalle en Observaciones", "Datos insuficientes", MessageBoxButtons.OK);
                    TxtObservaciones.Focus();
                    return false;
                }
            }

            return R;
        }

        private bool ValidarLinea()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(MiDetalleFactura.MiProducto.IDProducto) &&
                !string.IsNullOrEmpty(TxtCantidad.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtPrecio.Text.Trim())) 
            {
                R = true;
            }
            else
            {
                if (string.IsNullOrEmpty(MiDetalleFactura.MiProducto.IDProducto))
                {
                    MessageBox.Show("Debe escoger un producto válido","Error", MessageBoxButtons.OK);
                    TxtCodigoProducto.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(TxtCantidad.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar la cantidad", "Error", MessageBoxButtons.OK);
                    TxtCantidad.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(TxtPrecio.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar el precio del producto", "Error", MessageBoxButtons.OK);
                    TxtPrecio.Focus();
                    return false;
                }
            }

            return R;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                // Se asignan los valores a los atributos de la factura para poder agregarla a la base de datos
                MiFactura.CostoTotal = float.Parse(TxtTotal.Text.Trim());
                MiFactura.Observaciones = TxtObservaciones.Text.Trim();


                if (MiFactura.Agregar())
                {
                    MessageBox.Show("Factura agregada","Éxito", MessageBoxButtons.OK);
                    LimpiarFormulario();
                    
                }
                else
                {
                    MessageBox.Show("La factura no se agregó", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void LimpiarFormulario()
        {
            LblVendedor.Text = "";
            LblCliente.Text = "";
            TxtCliente.Clear();
            TxtTotal.Clear();
            TxtObservaciones.Clear();
        }

        private void TxtCliente_DoubleClick(object sender, EventArgs e)
        {
            FrmClienteBuscar MiFormDeBusqueda = new FrmClienteBuscar();

            DialogResult respuesta = MiFormDeBusqueda.ShowDialog();

            if (respuesta == DialogResult.OK)
            {
                TxtCliente.Text = MiFactura.MiCliente.IDCliente.ToString();
                LblCliente.Text += MiFactura.MiCliente.Nombre + " "+ MiFactura.MiCliente.Apellido;
                TxtCliente.Enabled = false;
            }
        }

        private void TxtVendedor_DoubleClick(object sender, EventArgs e)
        {
            FrmVendedorBuscar MiFormDeBusqueda = new FrmVendedorBuscar();
            DialogResult respuesta = MiFormDeBusqueda.ShowDialog();

            if (respuesta == DialogResult.OK)
            {
                TxtVendedor.Text = MiFactura.MiVendedor.IDVendedor.ToString();
                LblVendedor.Text += MiFactura.MiVendedor.Nombre + " " + MiFactura.MiVendedor.Apellido;
                TxtVendedor.Enabled = false;
                
                // Nos escribe el número de pedido que continua en la tabla dependiendo del vendedor que escojamos
                string consecutivo = MiFactura.ConsecutivoFactura(MiFactura.MiVendedor.IDVendedor);
                LblPedido.Text += consecutivo;
                //MessageBox.Show("El consecutivo de la factura es: " + consecutivo, "Éxito", MessageBoxButtons.OK);
                
            }

        }

        private void BtnAgregarLinea_Click(object sender, EventArgs e)
        {
            // TODO: Pendiente de desarrollar
            if (ValidarLinea())
            {
                int num_fila = 0;
                bool existeLinea = false;

                if (cont_fila ==0)
                {
                    AgregarLineaFactura();
                }
                else
                {
                    foreach (DataGridViewRow fila in DgvDetalleFactura.Rows)
                    {
                        // Comprueba si ya se ha agregado ese código a la factura
                        if (fila.Cells[0].Value.ToString()==TxtCodigoProducto.Text)
                        {
                            existeLinea = true;
                            // recupera la línea en la que está el código repetido
                            num_fila = fila.Index;
                        }
                    }

                    if (existeLinea)
                    {
                        // Actualiza la cantidad del producto que se está repitiendo
                        DgvDetalleFactura.Rows[num_fila].Cells[2].Value = (Convert.ToDouble(TxtCantidad.Text.Trim())+Convert.ToDouble(DgvDetalleFactura.Rows[num_fila].Cells[2].Value)).ToString();
                        double total = Convert.ToDouble(DgvDetalleFactura.Rows[num_fila].Cells[2].Value) * Convert.ToDouble(DgvDetalleFactura.Rows[num_fila].Cells[3].Value);
                        DgvDetalleFactura.Rows[num_fila].Cells[4].Value = total;
                    }
                    else
                    {
                        AgregarLineaFactura();
                    }
                }
                //MessageBox.Show("Linea agregada!","Agregando", MessageBoxButtons.OK);
                TxtCodigoProducto.Clear();
                TxtDescripcion.Clear();
                TxtCantidad.Clear();
                TxtPrecio.Clear();
            }
        }

        private void AgregarLineaFactura()
        {
            DgvDetalleFactura.Rows.Add(TxtCodigoProducto.Text.Trim(),TxtDescripcion.Text.Trim(),TxtCantidad.Text.Trim(),TxtPrecio.Text.Trim());
            // Multiplica Cantidad por Precio
            double total = Convert.ToDouble(DgvDetalleFactura.Rows[cont_fila].Cells[2].Value)* Convert.ToDouble(DgvDetalleFactura.Rows[cont_fila].Cells[3].Value);
            DgvDetalleFactura.Rows[cont_fila].Cells[4].Value = total;
            cont_fila++;
        }
        // Si existe el código de producto digitado en el TxtCodigo producto, entonces se carga en los
        // TextBox correspondientes y se hace focus en el TxtPrecio,
        // de lo contrario se abre el form de búsqueda de productos
        private void TxtCodigoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab)
            {
                // Esta línea evita que windows haga el sonido de advertencia al oprimir enter en un 
                // textbox que no admite multilíneas
                e.Handled = true;

                Logica.Models.Producto producto = new Logica.Models.Producto();
                producto = producto.ConsultarPorCodigo(TxtCodigoProducto.Text.Trim());
                if (producto.IDProducto != null)
                {
                    TxtCodigoProducto.Text = producto.IDProducto;
                    TxtDescripcion.Text = producto.Descripcion;
                    MiDetalleFactura.MiProducto = producto;
                    TxtCantidad.Focus();
                }
            }
        }

        private void TxtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarDecimales(sender, e);
        }

        private void TxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarDecimales(sender,e);
        }

        // Esto es para que solo admita números decimales o enteros, para la cantidad y el precio
        // Aun no se controla la cantidad de números antes y después del punto
        private void validarDecimales(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
