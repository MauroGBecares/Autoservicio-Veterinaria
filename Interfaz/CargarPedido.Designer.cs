namespace Interfaz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CargarPedido));
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
            this.lblCodigoPedido.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCodigoPedido.Location = new System.Drawing.Point(199, 102);
            this.lblCodigoPedido.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCodigoPedido.Name = "lblCodigoPedido";
            this.lblCodigoPedido.Size = new System.Drawing.Size(105, 16);
            this.lblCodigoPedido.TabIndex = 0;
            this.lblCodigoPedido.Text = "Código Pedido:";
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblVendedor.Location = new System.Drawing.Point(232, 166);
            this.lblVendedor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(72, 16);
            this.lblVendedor.TabIndex = 2;
            this.lblVendedor.Text = "Vendedor:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblFecha.Location = new System.Drawing.Point(254, 136);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(50, 16);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblSeleccionMascota
            // 
            this.lblSeleccionMascota.AutoSize = true;
            this.lblSeleccionMascota.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSeleccionMascota.Location = new System.Drawing.Point(149, 200);
            this.lblSeleccionMascota.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSeleccionMascota.Name = "lblSeleccionMascota";
            this.lblSeleccionMascota.Size = new System.Drawing.Size(155, 16);
            this.lblSeleccionMascota.TabIndex = 4;
            this.lblSeleccionMascota.Text = "Selecciona la mascota:";
            // 
            // txtCodigoPedido
            // 
            this.txtCodigoPedido.Enabled = false;
            this.txtCodigoPedido.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoPedido.Location = new System.Drawing.Point(309, 99);
            this.txtCodigoPedido.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtCodigoPedido.Name = "txtCodigoPedido";
            this.txtCodigoPedido.Size = new System.Drawing.Size(52, 22);
            this.txtCodigoPedido.TabIndex = 5;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(309, 131);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(314, 22);
            this.dtpFecha.TabIndex = 7;
            // 
            // cboMascota
            // 
            this.cboMascota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMascota.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMascota.FormattingEnabled = true;
            this.cboMascota.Location = new System.Drawing.Point(309, 197);
            this.cboMascota.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cboMascota.Name = "cboMascota";
            this.cboMascota.Size = new System.Drawing.Size(314, 24);
            this.cboMascota.TabIndex = 1;
            this.cboMascota.SelectedIndexChanged += new System.EventHandler(this.cboMascota_SelectedIndexChanged);
            // 
            // cboVendedor
            // 
            this.cboVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVendedor.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVendedor.FormattingEnabled = true;
            this.cboVendedor.Location = new System.Drawing.Point(309, 163);
            this.cboVendedor.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cboVendedor.Name = "cboVendedor";
            this.cboVendedor.Size = new System.Drawing.Size(314, 24);
            this.cboVendedor.TabIndex = 0;
            // 
            // btnPedir
            // 
            this.btnPedir.Font = new System.Drawing.Font("Arial", 9.5F);
            this.btnPedir.Location = new System.Drawing.Point(187, 469);
            this.btnPedir.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnPedir.Name = "btnPedir";
            this.btnPedir.Size = new System.Drawing.Size(112, 49);
            this.btnPedir.TabIndex = 3;
            this.btnPedir.Text = "Pedir";
            this.btnPedir.UseVisualStyleBackColor = true;
            this.btnPedir.Click += new System.EventHandler(this.btnPedir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 9.5F);
            this.btnCancelar.Location = new System.Drawing.Point(459, 469);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(126, 49);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtDetallePedido
            // 
            this.txtDetallePedido.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold);
            this.txtDetallePedido.Location = new System.Drawing.Point(16, 273);
            this.txtDetallePedido.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtDetallePedido.Multiline = true;
            this.txtDetallePedido.Name = "txtDetallePedido";
            this.txtDetallePedido.ReadOnly = true;
            this.txtDetallePedido.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetallePedido.Size = new System.Drawing.Size(787, 187);
            this.txtDetallePedido.TabIndex = 2;
            // 
            // CargarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(821, 533);
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
            this.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "CargarPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargar Pedido";
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