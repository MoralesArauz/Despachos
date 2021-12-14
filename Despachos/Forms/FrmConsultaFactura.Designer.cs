
namespace Despachos.Forms
{
    partial class FrmConsultaFactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblPedido = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCliente = new System.Windows.Forms.TextBox();
            this.TxtVendedor = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblFecha = new System.Windows.Forms.Label();
            this.DgvDetalleFactura = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFacturada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDespachada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CABREV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblHora = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalleFactura)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblPedido
            // 
            this.LblPedido.AutoSize = true;
            this.LblPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPedido.Location = new System.Drawing.Point(24, 31);
            this.LblPedido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPedido.Name = "LblPedido";
            this.LblPedido.Size = new System.Drawing.Size(58, 16);
            this.LblPedido.TabIndex = 0;
            this.LblPedido.Text = "Pedido: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vendedor: ";
            // 
            // TxtCliente
            // 
            this.TxtCliente.Enabled = false;
            this.TxtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCliente.Location = new System.Drawing.Point(112, 66);
            this.TxtCliente.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.Size = new System.Drawing.Size(400, 22);
            this.TxtCliente.TabIndex = 3;
            // 
            // TxtVendedor
            // 
            this.TxtVendedor.Enabled = false;
            this.TxtVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVendedor.Location = new System.Drawing.Point(112, 104);
            this.TxtVendedor.Margin = new System.Windows.Forms.Padding(4);
            this.TxtVendedor.Name = "TxtVendedor";
            this.TxtVendedor.Size = new System.Drawing.Size(400, 22);
            this.TxtVendedor.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LblHora);
            this.panel1.Controls.Add(this.LblFecha);
            this.panel1.Controls.Add(this.LblPedido);
            this.panel1.Controls.Add(this.TxtVendedor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TxtCliente);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 162);
            this.panel1.TabIndex = 5;
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Location = new System.Drawing.Point(771, 31);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(52, 16);
            this.LblFecha.TabIndex = 5;
            this.LblFecha.Text = "Fecha: ";
            // 
            // DgvDetalleFactura
            // 
            this.DgvDetalleFactura.AllowUserToAddRows = false;
            this.DgvDetalleFactura.AllowUserToDeleteRows = false;
            this.DgvDetalleFactura.AllowUserToResizeRows = false;
            this.DgvDetalleFactura.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDetalleFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CCodigo,
            this.CDescripcion,
            this.CFacturada,
            this.CDespachada,
            this.CPRECIO,
            this.CABREV});
            this.DgvDetalleFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvDetalleFactura.Location = new System.Drawing.Point(0, 162);
            this.DgvDetalleFactura.Name = "DgvDetalleFactura";
            this.DgvDetalleFactura.ReadOnly = true;
            this.DgvDetalleFactura.RowHeadersVisible = false;
            this.DgvDetalleFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDetalleFactura.Size = new System.Drawing.Size(1080, 439);
            this.DgvDetalleFactura.TabIndex = 6;
            this.DgvDetalleFactura.VirtualMode = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imprimirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1080, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // CCodigo
            // 
            this.CCodigo.DataPropertyName = "Codigo";
            this.CCodigo.HeaderText = "Código";
            this.CCodigo.Name = "CCodigo";
            this.CCodigo.ReadOnly = true;
            // 
            // CDescripcion
            // 
            this.CDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CDescripcion.DataPropertyName = "Descripcion";
            this.CDescripcion.HeaderText = "Descripción";
            this.CDescripcion.Name = "CDescripcion";
            this.CDescripcion.ReadOnly = true;
            // 
            // CFacturada
            // 
            this.CFacturada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CFacturada.DataPropertyName = "Facturada";
            this.CFacturada.HeaderText = "Cantidad Facturada";
            this.CFacturada.Name = "CFacturada";
            this.CFacturada.ReadOnly = true;
            this.CFacturada.Width = 180;
            // 
            // CDespachada
            // 
            this.CDespachada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CDespachada.DataPropertyName = "Despachada";
            this.CDespachada.HeaderText = "Cantidad Despachada";
            this.CDespachada.Name = "CDespachada";
            this.CDespachada.ReadOnly = true;
            this.CDespachada.Width = 180;
            // 
            // CPRECIO
            // 
            this.CPRECIO.DataPropertyName = "PRECIO";
            this.CPRECIO.HeaderText = "Precio";
            this.CPRECIO.Name = "CPRECIO";
            this.CPRECIO.ReadOnly = true;
            // 
            // CABREV
            // 
            this.CABREV.DataPropertyName = "ABREV";
            this.CABREV.HeaderText = "Bodega";
            this.CABREV.Name = "CABREV";
            this.CABREV.ReadOnly = true;
            // 
            // LblHora
            // 
            this.LblHora.AutoSize = true;
            this.LblHora.Location = new System.Drawing.Point(774, 74);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(44, 16);
            this.LblHora.TabIndex = 7;
            this.LblHora.Text = "Hora: ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TxtTotal);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 501);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 100);
            this.panel2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(817, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total: ₡ ";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Enabled = false;
            this.TxtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.Location = new System.Drawing.Point(898, 60);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(153, 22);
            this.TxtTotal.TabIndex = 1;
            // 
            // FrmConsultaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 601);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DgvDetalleFactura);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmConsultaFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.FrmConsultaFactura_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalleFactura)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCliente;
        private System.Windows.Forms.TextBox TxtVendedor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.DataGridView DgvDetalleFactura;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFacturada;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDespachada;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CABREV;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label label3;
    }
}