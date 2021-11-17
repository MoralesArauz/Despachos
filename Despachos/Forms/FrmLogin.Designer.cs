
namespace Despachos.Forms
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.LinkRecuperarPass = new System.Windows.Forms.LinkLabel();
            this.LblEmpresa = new System.Windows.Forms.Label();
            this.PicShowPass = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicShowPass)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.Location = new System.Drawing.Point(22, 40);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(332, 22);
            this.TxtUsuario.TabIndex = 0;
            this.TxtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(22, 110);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(332, 22);
            this.TxtPassword.TabIndex = 1;
            this.TxtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.LblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(144, 13);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(81, 24);
            this.LblUsuario.TabIndex = 2;
            this.LblUsuario.Text = "Usuario";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.BackColor = System.Drawing.Color.Transparent;
            this.LblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.Location = new System.Drawing.Point(131, 83);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(116, 24);
            this.LblPassword.TabIndex = 3;
            this.LblPassword.Text = "Contraseña";
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnIniciar.FlatAppearance.BorderSize = 0;
            this.BtnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciar.ForeColor = System.Drawing.Color.Ivory;
            this.BtnIniciar.Location = new System.Drawing.Point(22, 136);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(120, 33);
            this.BtnIniciar.TabIndex = 4;
            this.BtnIniciar.Text = "Iniciar Sesión";
            this.BtnIniciar.UseVisualStyleBackColor = false;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Red;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.Ivory;
            this.BtnCancelar.Location = new System.Drawing.Point(246, 136);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(108, 33);
            this.BtnCancelar.TabIndex = 5;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // LinkRecuperarPass
            // 
            this.LinkRecuperarPass.AutoSize = true;
            this.LinkRecuperarPass.BackColor = System.Drawing.Color.Transparent;
            this.LinkRecuperarPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkRecuperarPass.Location = new System.Drawing.Point(19, 186);
            this.LinkRecuperarPass.Name = "LinkRecuperarPass";
            this.LinkRecuperarPass.Size = new System.Drawing.Size(131, 15);
            this.LinkRecuperarPass.TabIndex = 6;
            this.LinkRecuperarPass.TabStop = true;
            this.LinkRecuperarPass.Text = "Recuperar Contraseña";
            // 
            // LblEmpresa
            // 
            this.LblEmpresa.AutoSize = true;
            this.LblEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.LblEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmpresa.ForeColor = System.Drawing.Color.Blue;
            this.LblEmpresa.Location = new System.Drawing.Point(175, 188);
            this.LblEmpresa.Name = "LblEmpresa";
            this.LblEmpresa.Size = new System.Drawing.Size(209, 13);
            this.LblEmpresa.TabIndex = 7;
            this.LblEmpresa.Text = "JOVICAMPER DE OCCIDENTE S.A.";
            // 
            // PicShowPass
            // 
            this.PicShowPass.BackgroundImage = global::Despachos.Properties.Resources.eye;
            this.PicShowPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicShowPass.Location = new System.Drawing.Point(320, 111);
            this.PicShowPass.Name = "PicShowPass";
            this.PicShowPass.Size = new System.Drawing.Size(34, 20);
            this.PicShowPass.TabIndex = 8;
            this.PicShowPass.TabStop = false;
            this.PicShowPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicShowPass_MouseDown);
            this.PicShowPass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PicShowPass_MouseUp);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Despachos.Properties.Resources.backgroundLogin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(391, 212);
            this.Controls.Add(this.PicShowPass);
            this.Controls.Add(this.LblEmpresa);
            this.Controls.Add(this.LinkRecuperarPass);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnIniciar);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUsuario);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.PicShowPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.LinkLabel LinkRecuperarPass;
        private System.Windows.Forms.Label LblEmpresa;
        private System.Windows.Forms.PictureBox PicShowPass;
    }
}