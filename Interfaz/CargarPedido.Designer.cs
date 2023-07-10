namespace Code_test_L2
{
    partial class CargarPedido
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
            this.lblCodigoPedido = new System.Windows.Forms.Label();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblSeleccionMascota = new System.Windows.Forms.Label();
            this.txtCodigoPedido = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cboMascota = new System.Windows.Forms.ComboBox();
            this.cboVendedor = new System.Windows.Forms.ComboBox();
            this.btnPedir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtDetallePedido = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCodigoPedido
            // 
            this.lblCodigoPedido.AutoSize = true;
            this.lblCodigoPedido.Location = new System.Drawing.Point(137, 87);
            this.lblCodigoPedido.Name = "lblCodigoPedido";
            this.lblCodigoPedido.Size = new System.Drawing.Size(79, 13);
            this.lblCodigoPedido.TabIndex = 0;
            this.lblCodigoPedido.Text = "Código Pedido:";
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(160, 136);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(56, 13);
            this.lblVendedor.TabIndex = 2;
            this.lblVendedor.Text = "Vendedor:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(174, 111);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblSeleccionMascota
            // 
            this.lblSeleccionMascota.AutoSize = true;
            this.lblSeleccionMascota.Location = new System.Drawing.Point(97, 161);
            this.lblSeleccionMascota.Name = "lblSeleccionMascota";
            this.lblSeleccionMascota.Size = new System.Drawing.Size(117, 13);
            this.lblSeleccionMascota.TabIndex = 4;
            this.lblSeleccionMascota.Text = "Selecciona la mascota:";
            // 
            // txtCodigoPedido
            // 
            this.txtCodigoPedido.Enabled = false;
            this.txtCodigoPedido.Location = new System.Drawing.Point(220, 81);
            this.txtCodigoPedido.Name = "txtCodigoPedido";
            this.txtCodigoPedido.Size = new System.Drawing.Size(40, 20);
            this.txtCodigoPedido.TabIndex = 5;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Location = new System.Drawing.Point(220, 107);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 7;
            // 
            // cboMascota
            // 
            this.cboMascota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMascota.FormattingEnabled = true;
            this.cboMascota.Location = new System.Drawing.Point(220, 160);
            this.cboMascota.Name = "cboMascota";
            this.cboMascota.Size = new System.Drawing.Size(200, 21);
            this.cboMascota.TabIndex = 9;
            this.cboMascota.SelectedIndexChanged += new System.EventHandler(this.cboMascota_SelectedIndexChanged);
            // 
            // cboVendedor
            // 
            this.cboVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVendedor.FormattingEnabled = true;
            this.cboVendedor.Location = new System.Drawing.Point(220, 133);
            this.cboVendedor.Name = "cboVendedor";
            this.cboVendedor.Size = new System.Drawing.Size(200, 21);
            this.cboVendedor.TabIndex = 10;
            // 
            // btnPedir
            // 
            this.btnPedir.Location = new System.Drawing.Point(141, 381);
            this.btnPedir.Name = "btnPedir";
            this.btnPedir.Size = new System.Drawing.Size(75, 23);
            this.btnPedir.TabIndex = 11;
            this.btnPedir.Text = "Pedir";
            this.btnPedir.UseVisualStyleBackColor = true;
            this.btnPedir.Click += new System.EventHandler(this.btnPedir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(345, 381);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtDetallePedido
            // 
            this.txtDetallePedido.Location = new System.Drawing.Point(12, 222);
            this.txtDetallePedido.Multiline = true;
            this.txtDetallePedido.Name = "txtDetallePedido";
            this.txtDetallePedido.ReadOnly = true;
            this.txtDetallePedido.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetallePedido.Size = new System.Drawing.Size(591, 153);
            this.txtDetallePedido.TabIndex = 13;
            // 
            // CargarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(615, 433);
            this.Controls.Add(this.txtDetallePedido);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnPedir);
            this.Controls.Add(this.cboVendedor);
            this.Controls.Add(this.cboMascota);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtCodigoPedido);
            this.Controls.Add(this.lblSeleccionMascota);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.lblCodigoPedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CargarPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CargarPedido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigoPedido;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblSeleccionMascota;
        private System.Windows.Forms.TextBox txtCodigoPedido;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cboMascota;
        private System.Windows.Forms.ComboBox cboVendedor;
        private System.Windows.Forms.Button btnPedir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtDetallePedido;
    }
}