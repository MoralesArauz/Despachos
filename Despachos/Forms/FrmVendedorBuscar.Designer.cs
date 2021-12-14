
namespace Despachos.Forms
{
    partial class FrmVendedorBuscar
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtVendedor = new System.Windows.Forms.TextBox();
            this.BtnSeleccionar = new System.Windows.Forms.Button();
            this.DgvListaVendedores = new System.Windows.Forms.DataGridView();
            this.CID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIDSuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaVendedores)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar";
            // 
            // TxtVendedor
            // 
            this.TxtVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVendedor.Location = new System.Drawing.Point(215, 38);
            this.TxtVendedor.Name = "TxtVendedor";
            this.TxtVendedor.Size = new System.Drawing.Size(408, 26);
            this.TxtVendedor.TabIndex = 1;
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnSeleccionar.FlatAppearance.BorderSize = 0;
            this.BtnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.BtnSeleccionar.Location = new System.Drawing.Point(793, 421);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.Size = new System.Drawing.Size(116, 30);
            this.BtnSeleccionar.TabIndex = 2;
            this.BtnSeleccionar.Text = "Seleccionar";
            this.BtnSeleccionar.UseVisualStyleBackColor = false;
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // DgvListaVendedores
            // 
            this.DgvListaVendedores.AllowUserToAddRows = false;
            this.DgvListaVendedores.AllowUserToDeleteRows = false;
            this.DgvListaVendedores.AllowUserToResizeRows = false;
            this.DgvListaVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaVendedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CID,
            this.CCedula,
            this.CNombre,
            this.CApellido,
            this.CIDSuc,
            this.CSucursal});
            this.DgvListaVendedores.Location = new System.Drawing.Point(29, 96);
            this.DgvListaVendedores.MultiSelect = false;
            this.DgvListaVendedores.Name = "DgvListaVendedores";
            this.DgvListaVendedores.ReadOnly = true;
            this.DgvListaVendedores.RowHeadersVisible = false;
            this.DgvListaVendedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaVendedores.Size = new System.Drawing.Size(880, 304);
            this.DgvListaVendedores.TabIndex = 3;
            this.DgvListaVendedores.VirtualMode = true;
            // 
            // CID
            // 
            this.CID.DataPropertyName = "ID";
            this.CID.HeaderText = "ID";
            this.CID.Name = "CID";
            this.CID.ReadOnly = true;
            // 
            // CCedula
            // 
            this.CCedula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CCedula.DataPropertyName = "Cedula";
            this.CCedula.HeaderText = "Cédula";
            this.CCedula.Name = "CCedula";
            this.CCedula.ReadOnly = true;
            this.CCedula.Width = 150;
            // 
            // CNombre
            // 
            this.CNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CNombre.DataPropertyName = "Nombre";
            this.CNombre.HeaderText = "Nombre";
            this.CNombre.Name = "CNombre";
            this.CNombre.ReadOnly = true;
            this.CNombre.Width = 200;
            // 
            // CApellido
            // 
            this.CApellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CApellido.DataPropertyName = "Apellido";
            this.CApellido.HeaderText = "Apellido";
            this.CApellido.Name = "CApellido";
            this.CApellido.ReadOnly = true;
            this.CApellido.Width = 200;
            // 
            // CIDSuc
            // 
            this.CIDSuc.DataPropertyName = "IDSuc";
            this.CIDSuc.HeaderText = "ID Suc";
            this.CIDSuc.Name = "CIDSuc";
            this.CIDSuc.ReadOnly = true;
            // 
            // CSucursal
            // 
            this.CSucursal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CSucursal.DataPropertyName = "Sucursal";
            this.CSucursal.HeaderText = "Sucursal";
            this.CSucursal.Name = "CSucursal";
            this.CSucursal.ReadOnly = true;
            this.CSucursal.Width = 125;
            // 
            // FrmVendedorBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 486);
            this.Controls.Add(this.DgvListaVendedores);
            this.Controls.Add(this.BtnSeleccionar);
            this.Controls.Add(this.TxtVendedor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmVendedorBuscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selección de Vendedor";
            this.Load += new System.EventHandler(this.FrmVendedorBuscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaVendedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtVendedor;
        private System.Windows.Forms.Button BtnSeleccionar;
        private System.Windows.Forms.DataGridView DgvListaVendedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn CID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDSuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSucursal;
    }
}