
namespace Despachos.Forms
{
    partial class FrmUsuarioGestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarioGestion));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CbRol = new System.Windows.Forms.ComboBox();
            this.CheckBoxActivo = new System.Windows.Forms.CheckBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.TxtContrasenia = new System.Windows.Forms.TextBox();
            this.BtnAtras = new System.Windows.Forms.Button();
            this.BtnGuargar = new System.Windows.Forms.Button();
            this.PBUsuario = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Correo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 231);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rol:";
            // 
            // CbRol
            // 
            this.CbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbRol.FormattingEnabled = true;
            this.CbRol.Location = new System.Drawing.Point(129, 228);
            this.CbRol.Margin = new System.Windows.Forms.Padding(5);
            this.CbRol.Name = "CbRol";
            this.CbRol.Size = new System.Drawing.Size(199, 28);
            this.CbRol.TabIndex = 4;
            this.CbRol.SelectedIndexChanged += new System.EventHandler(this.CbRol_SelectedIndexChanged);
            // 
            // CheckBoxActivo
            // 
            this.CheckBoxActivo.AutoSize = true;
            this.CheckBoxActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxActivo.Location = new System.Drawing.Point(18, 283);
            this.CheckBoxActivo.Margin = new System.Windows.Forms.Padding(5);
            this.CheckBoxActivo.Name = "CheckBoxActivo";
            this.CheckBoxActivo.Size = new System.Drawing.Size(77, 24);
            this.CheckBoxActivo.TabIndex = 5;
            this.CheckBoxActivo.Text = "Activo";
            this.CheckBoxActivo.UseVisualStyleBackColor = true;
            this.CheckBoxActivo.CheckedChanged += new System.EventHandler(this.CheckBoxActivo_CheckedChanged);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(129, 65);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(305, 26);
            this.TxtNombre.TabIndex = 6;
            this.TxtNombre.Leave += new System.EventHandler(this.TxtNombre_Leave);
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Location = new System.Drawing.Point(129, 111);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(307, 26);
            this.TxtCorreo.TabIndex = 7;
            this.TxtCorreo.Leave += new System.EventHandler(this.TxtCorreo_Leave);
            // 
            // TxtContrasenia
            // 
            this.TxtContrasenia.Location = new System.Drawing.Point(129, 161);
            this.TxtContrasenia.Name = "TxtContrasenia";
            this.TxtContrasenia.Size = new System.Drawing.Size(307, 26);
            this.TxtContrasenia.TabIndex = 8;
            this.TxtContrasenia.Leave += new System.EventHandler(this.TxtContrasenia_Leave);
            // 
            // BtnAtras
            // 
            this.BtnAtras.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnAtras.FlatAppearance.BorderSize = 0;
            this.BtnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAtras.Image = global::Despachos.Properties.Resources.flecha_hacia_atras;
            this.BtnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAtras.Location = new System.Drawing.Point(194, 13);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(121, 36);
            this.BtnAtras.TabIndex = 11;
            this.BtnAtras.Text = "Atrás";
            this.BtnAtras.UseVisualStyleBackColor = false;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // BtnGuargar
            // 
            this.BtnGuargar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnGuargar.FlatAppearance.BorderSize = 0;
            this.BtnGuargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuargar.Image = global::Despachos.Properties.Resources.disquete1;
            this.BtnGuargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuargar.Location = new System.Drawing.Point(18, 13);
            this.BtnGuargar.Name = "BtnGuargar";
            this.BtnGuargar.Size = new System.Drawing.Size(155, 36);
            this.BtnGuargar.TabIndex = 10;
            this.BtnGuargar.Text = "Guardar";
            this.BtnGuargar.UseVisualStyleBackColor = false;
            this.BtnGuargar.Click += new System.EventHandler(this.BtnGuargar_Click);
            // 
            // PBUsuario
            // 
            this.PBUsuario.BackgroundImage = global::Despachos.Properties.Resources.usuario;
            this.PBUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PBUsuario.Location = new System.Drawing.Point(466, 33);
            this.PBUsuario.Name = "PBUsuario";
            this.PBUsuario.Size = new System.Drawing.Size(153, 140);
            this.PBUsuario.TabIndex = 9;
            this.PBUsuario.TabStop = false;
            // 
            // FrmUsuarioGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 412);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.BtnGuargar);
            this.Controls.Add(this.PBUsuario);
            this.Controls.Add(this.TxtContrasenia);
            this.Controls.Add(this.TxtCorreo);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.CheckBoxActivo);
            this.Controls.Add(this.CbRol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmUsuarioGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Usuarios";
            this.Load += new System.EventHandler(this.FrmUsuarioGestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CbRol;
        private System.Windows.Forms.CheckBox CheckBoxActivo;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.TextBox TxtContrasenia;
        private System.Windows.Forms.PictureBox PBUsuario;
        private System.Windows.Forms.Button BtnGuargar;
        private System.Windows.Forms.Button BtnAtras;
    }
}