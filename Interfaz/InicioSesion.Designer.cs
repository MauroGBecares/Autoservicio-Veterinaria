namespace Interfaz
{
    partial class InicioSesion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesion));
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.llblCrearCuenta = new System.Windows.Forms.LinkLabel();
            this.pbxImagenPerro = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenPerro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblUser.Location = new System.Drawing.Point(274, 245);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(65, 16);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Usuario:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblPassword.Location = new System.Drawing.Point(250, 327);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(92, 16);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Contraseña:";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Arial", 9.5F);
            this.txtUser.Location = new System.Drawing.Point(350, 243);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(147, 22);
            this.txtUser.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Arial", 9.5F);
            this.txtPassword.Location = new System.Drawing.Point(350, 321);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(147, 22);
            this.txtPassword.TabIndex = 1;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Arial", 9.5F);
            this.btnIngresar.Location = new System.Drawing.Point(350, 378);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(100, 28);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // llblCrearCuenta
            // 
            this.llblCrearCuenta.AutoSize = true;
            this.llblCrearCuenta.Font = new System.Drawing.Font("Arial", 9.5F);
            this.llblCrearCuenta.Location = new System.Drawing.Point(323, 457);
            this.llblCrearCuenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llblCrearCuenta.Name = "llblCrearCuenta";
            this.llblCrearCuenta.Size = new System.Drawing.Size(154, 16);
            this.llblCrearCuenta.TabIndex = 3;
            this.llblCrearCuenta.TabStop = true;
            this.llblCrearCuenta.Text = "CREAR NUEVA CUENTA";
            this.llblCrearCuenta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblCrearCuenta_LinkClicked);
            // 
            // pbxImagenPerro
            // 
            this.pbxImagenPerro.Image = ((System.Drawing.Image)(resources.GetObject("pbxImagenPerro.Image")));
            this.pbxImagenPerro.Location = new System.Drawing.Point(584, 27);
            this.pbxImagenPerro.Name = "pbxImagenPerro";
            this.pbxImagenPerro.Size = new System.Drawing.Size(213, 181);
            this.pbxImagenPerro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagenPerro.TabIndex = 5;
            this.pbxImagenPerro.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(68, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.ImageLocation = "";
            this.pictureBox2.Location = new System.Drawing.Point(253, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(332, 181);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(841, 576);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbxImagenPerro);
            this.Controls.Add(this.llblCrearCuenta);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUser);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido !";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InicioSesion_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenPerro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.LinkLabel llblCrearCuenta;
        private System.Windows.Forms.PictureBox pbxImagenPerro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

