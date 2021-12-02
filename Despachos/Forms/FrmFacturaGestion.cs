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
        public FrmFacturaGestion()
        {
            InitializeComponent();
            MiFactura = new Logica.Models.Factura();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmFacturaGestion_Load(object sender, EventArgs e)
        {
            
        }


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
                LblCliente.Text = MiFactura.MiCliente.Nombre + " "+ MiFactura.MiCliente.Apellido;
            }
        }

        private void TxtVendedor_DoubleClick(object sender, EventArgs e)
        {
            FrmVendedorBuscar MiFormDeBusqueda = new FrmVendedorBuscar();
            DialogResult respuesta = MiFormDeBusqueda.ShowDialog();

            if (respuesta == DialogResult.OK)
            {
                TxtVendedor.Text = MiFactura.MiVendedor.IDVendedor.ToString();
                LblVendedor.Text = MiFactura.MiVendedor.Nombre + " " + MiFactura.MiVendedor.Apellido; 
            }

        }
    }
}
