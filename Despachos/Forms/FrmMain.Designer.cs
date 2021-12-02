
namespace Despachos.Forms
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.PnlIzquierdo = new System.Windows.Forms.Panel();
            this.BtnUsuarios = new System.Windows.Forms.Button();
            this.BtnDespachos = new System.Windows.Forms.Button();
            this.BtnSucursales = new System.Windows.Forms.Button();
            this.BtnVendedores = new System.Windows.Forms.Button();
            this.BtnProductos = new System.Windows.Forms.Button();
            this.BtnClientes = new System.Windows.Forms.Button();
            this.BtnFacturas = new System.Windows.Forms.Button();
            this.PnlContenedor = new System.Windows.Forms.Panel();
            this.PnlIzquierdo.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlIzquierdo
            // 
            this.PnlIzquierdo.BackColor = System.Drawing.Color.SteelBlue;
            this.PnlIzquierdo.Controls.Add(this.BtnUsuarios);
            this.PnlIzquierdo.Controls.Add(this.BtnDespachos);
            this.PnlIzquierdo.Controls.Add(this.BtnSucursales);
            this.PnlIzquierdo.Controls.Add(this.BtnVendedores);
            this.PnlIzquierdo.Controls.Add(this.BtnProductos);
            this.PnlIzquierdo.Controls.Add(this.BtnClientes);
            this.PnlIzquierdo.Controls.Add(this.BtnFacturas);
            this.PnlIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.PnlIzquierdo.Name = "PnlIzquierdo";
            this.PnlIzquierdo.Size = new System.Drawing.Size(200, 645);
            this.PnlIzquierdo.TabIndex = 0;
            // 
            // BtnUsuarios
            // 
            this.BtnUsuarios.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnUsuarios.FlatAppearance.BorderSize = 0;
            this.BtnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUsuarios.ForeColor = System.Drawing.Color.White;
            this.BtnUsuarios.Location = new System.Drawing.Point(0, 276);
            this.BtnUsuarios.Name = "BtnUsuarios";
            this.BtnUsuarios.Size = new System.Drawing.Size(200, 46);
            this.BtnUsuarios.TabIndex = 6;
            this.BtnUsuarios.Text = "Usuarios";
            this.BtnUsuarios.UseVisualStyleBackColor = false;
            this.BtnUsuarios.Click += new System.EventHandler(this.BtnUsuarios_Click);
            // 
            // BtnDespachos
            // 
            this.BtnDespachos.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnDespachos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDespachos.FlatAppearance.BorderSize = 0;
            this.BtnDespachos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDespachos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDespachos.ForeColor = System.Drawing.Color.White;
            this.BtnDespachos.Location = new System.Drawing.Point(0, 230);
            this.BtnDespachos.Name = "BtnDespachos";
            this.BtnDespachos.Size = new System.Drawing.Size(200, 46);
            this.BtnDespachos.TabIndex = 5;
            this.BtnDespachos.Text = "Despachos";
            this.BtnDespachos.UseVisualStyleBackColor = false;
            // 
            // BtnSucursales
            // 
            this.BtnSucursales.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnSucursales.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSucursales.FlatAppearance.BorderSize = 0;
            this.BtnSucursales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSucursales.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSucursales.ForeColor = System.Drawing.Color.White;
            this.BtnSucursales.Location = new System.Drawing.Point(0, 184);
            this.BtnSucursales.Name = "BtnSucursales";
            this.BtnSucursales.Size = new System.Drawing.Size(200, 46);
            this.BtnSucursales.TabIndex = 4;
            this.BtnSucursales.Text = "Sucursales";
            this.BtnSucursales.UseVisualStyleBackColor = false;
            // 
            // BtnVendedores
            // 
            this.BtnVendedores.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnVendedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnVendedores.FlatAppearance.BorderSize = 0;
            this.BtnVendedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVendedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVendedores.ForeColor = System.Drawing.Color.White;
            this.BtnVendedores.Location = new System.Drawing.Point(0, 138);
            this.BtnVendedores.Name = "BtnVendedores";
            this.BtnVendedores.Size = new System.Drawing.Size(200, 46);
            this.BtnVendedores.TabIndex = 3;
            this.BtnVendedores.Text = "Vendedores";
            this.BtnVendedores.UseVisualStyleBackColor = false;
            // 
            // BtnProductos
            // 
            this.BtnProductos.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProductos.FlatAppearance.BorderSize = 0;
            this.BtnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProductos.ForeColor = System.Drawing.Color.White;
            this.BtnProductos.Location = new System.Drawing.Point(0, 92);
            this.BtnProductos.Name = "BtnProductos";
            this.BtnProductos.Size = new System.Drawing.Size(200, 46);
            this.BtnProductos.TabIndex = 2;
            this.BtnProductos.Text = "Productos";
            this.BtnProductos.UseVisualStyleBackColor = false;
            this.BtnProductos.Click += new System.EventHandler(this.BtnProductos_Click);
            // 
            // BtnClientes
            // 
            this.BtnClientes.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnClientes.FlatAppearance.BorderSize = 0;
            this.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClientes.ForeColor = System.Drawing.Color.White;
            this.BtnClientes.Location = new System.Drawing.Point(0, 46);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(200, 46);
            this.BtnClientes.TabIndex = 1;
            this.BtnClientes.Text = "Clientes";
            this.BtnClientes.UseVisualStyleBackColor = false;
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // BtnFacturas
            // 
            this.BtnFacturas.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnFacturas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnFacturas.FlatAppearance.BorderSize = 0;
            this.BtnFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFacturas.ForeColor = System.Drawing.Color.White;
            this.BtnFacturas.Location = new System.Drawing.Point(0, 0);
            this.BtnFacturas.Name = "BtnFacturas";
            this.BtnFacturas.Size = new System.Drawing.Size(200, 46);
            this.BtnFacturas.TabIndex = 0;
            this.BtnFacturas.Text = "Facturas";
            this.BtnFacturas.UseVisualStyleBackColor = false;
            this.BtnFacturas.Click += new System.EventHandler(this.BtnFacturas_Click);
            // 
            // PnlContenedor
            // 
            this.PnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContenedor.Location = new System.Drawing.Point(200, 0);
            this.PnlContenedor.MinimumSize = new System.Drawing.Size(800, 600);
            this.PnlContenedor.Name = "PnlContenedor";
            this.PnlContenedor.Size = new System.Drawing.Size(976, 645);
            this.PnlContenedor.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 645);
            this.Controls.Add(this.PnlContenedor);
            this.Controls.Add(this.PnlIzquierdo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Despachos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.PnlIzquierdo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlIzquierdo;
        private System.Windows.Forms.Button BtnFacturas;
        private System.Windows.Forms.Button BtnSucursales;
        private System.Windows.Forms.Button BtnVendedores;
        private System.Windows.Forms.Button BtnProductos;
        private System.Windows.Forms.Button BtnClientes;
        private System.Windows.Forms.Button BtnUsuarios;
        private System.Windows.Forms.Button BtnDespachos;
        private System.Windows.Forms.Panel PnlContenedor;
    }
}