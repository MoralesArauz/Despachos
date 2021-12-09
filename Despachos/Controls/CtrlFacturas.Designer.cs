
namespace Despachos.Controls
{
    partial class CtrlFacturas
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CboxSucursales = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.despacharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DgvListaFacturas = new System.Windows.Forms.DataGridView();
            this.CPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nuevaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CboxSucursales);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1174, 67);
            this.panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(660, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(589, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sucursal";
            // 
            // CboxSucursales
            // 
            this.CboxSucursales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxSucursales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboxSucursales.FormattingEnabled = true;
            this.CboxSucursales.Location = new System.Drawing.Point(141, 23);
            this.CboxSucursales.Name = "CboxSucursales";
            this.CboxSucursales.Size = new System.Drawing.Size(121, 28);
            this.CboxSucursales.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.despacharToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1174, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // despacharToolStripMenuItem
            // 
            this.despacharToolStripMenuItem.Name = "despacharToolStripMenuItem";
            this.despacharToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.despacharToolStripMenuItem.Text = "Despachar";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DgvListaFacturas);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1174, 464);
            this.panel2.TabIndex = 2;
            // 
            // DgvListaFacturas
            // 
            this.DgvListaFacturas.AllowUserToAddRows = false;
            this.DgvListaFacturas.AllowUserToDeleteRows = false;
            this.DgvListaFacturas.AllowUserToResizeRows = false;
            this.DgvListaFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CPedido,
            this.CCliente,
            this.CVendedor,
            this.CTotal,
            this.CFecha,
            this.CSucursal});
            this.DgvListaFacturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvListaFacturas.Location = new System.Drawing.Point(0, 0);
            this.DgvListaFacturas.MultiSelect = false;
            this.DgvListaFacturas.Name = "DgvListaFacturas";
            this.DgvListaFacturas.ReadOnly = true;
            this.DgvListaFacturas.RowHeadersVisible = false;
            this.DgvListaFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaFacturas.Size = new System.Drawing.Size(1174, 464);
            this.DgvListaFacturas.TabIndex = 0;
            this.DgvListaFacturas.VirtualMode = true;
            // 
            // CPedido
            // 
            this.CPedido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CPedido.DataPropertyName = "Pedido";
            this.CPedido.HeaderText = "Pedido";
            this.CPedido.Name = "CPedido";
            this.CPedido.ReadOnly = true;
            this.CPedido.Width = 125;
            // 
            // CCliente
            // 
            this.CCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CCliente.DataPropertyName = "Cliente";
            this.CCliente.HeaderText = "Cliente";
            this.CCliente.Name = "CCliente";
            this.CCliente.ReadOnly = true;
            // 
            // CVendedor
            // 
            this.CVendedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CVendedor.DataPropertyName = "Vendedor";
            this.CVendedor.HeaderText = "Vendedor";
            this.CVendedor.Name = "CVendedor";
            this.CVendedor.ReadOnly = true;
            this.CVendedor.Width = 300;
            // 
            // CTotal
            // 
            this.CTotal.DataPropertyName = "Total";
            this.CTotal.HeaderText = "Total";
            this.CTotal.Name = "CTotal";
            this.CTotal.ReadOnly = true;
            // 
            // CFecha
            // 
            this.CFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CFecha.DataPropertyName = "Fecha";
            this.CFecha.HeaderText = "Fecha / Hora";
            this.CFecha.Name = "CFecha";
            this.CFecha.ReadOnly = true;
            this.CFecha.Width = 200;
            // 
            // CSucursal
            // 
            this.CSucursal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CSucursal.DataPropertyName = "Sucursal";
            this.CSucursal.HeaderText = "Sucursal";
            this.CSucursal.Name = "CSucursal";
            this.CSucursal.ReadOnly = true;
            this.CSucursal.Width = 250;
            // 
            // nuevaToolStripMenuItem
            // 
            this.nuevaToolStripMenuItem.Image = global::Despachos.Properties.Resources.nuevo;
            this.nuevaToolStripMenuItem.Name = "nuevaToolStripMenuItem";
            this.nuevaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.nuevaToolStripMenuItem.Text = "Nueva";
            this.nuevaToolStripMenuItem.Click += new System.EventHandler(this.nuevaToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Image = global::Despachos.Properties.Resources.imprimir;
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.consultarToolStripMenuItem.Text = "Imprimir";
            // 
            // CtrlFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "CtrlFacturas";
            this.Size = new System.Drawing.Size(1174, 555);
            this.Load += new System.EventHandler(this.CtrlFacturas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboxSucursales;
        private System.Windows.Forms.ToolStripMenuItem nuevaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despacharToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DgvListaFacturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSucursal;
    }
}
