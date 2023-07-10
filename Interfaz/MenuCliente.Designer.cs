namespace Code_test_L2
{
    partial class MenuCliente
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
            this.btnRegistrarMascota = new System.Windows.Forms.Button();
            this.btnRealizarPedido = new System.Windows.Forms.Button();
            this.btnVerHistorialPedidos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegistrarMascota
            // 
            this.btnRegistrarMascota.Location = new System.Drawing.Point(203, 99);
            this.btnRegistrarMascota.Name = "btnRegistrarMascota";
            this.btnRegistrarMascota.Size = new System.Drawing.Size(224, 59);
            this.btnRegistrarMascota.TabIndex = 0;
            this.btnRegistrarMascota.Text = "Registrar mascota";
            this.btnRegistrarMascota.UseVisualStyleBackColor = true;
            this.btnRegistrarMascota.Click += new System.EventHandler(this.btnRegistrarMascota_Click);
            // 
            // btnRealizarPedido
            // 
            this.btnRealizarPedido.Location = new System.Drawing.Point(203, 164);
            this.btnRealizarPedido.Name = "btnRealizarPedido";
            this.btnRealizarPedido.Size = new System.Drawing.Size(224, 62);
            this.btnRealizarPedido.TabIndex = 1;
            this.btnRealizarPedido.Text = "Realizar pedido";
            this.btnRealizarPedido.UseVisualStyleBackColor = true;
            this.btnRealizarPedido.Click += new System.EventHandler(this.btnRealizarPedido_Click);
            // 
            // btnVerHistorialPedidos
            // 
            this.btnVerHistorialPedidos.Location = new System.Drawing.Point(203, 232);
            this.btnVerHistorialPedidos.Name = "btnVerHistorialPedidos";
            this.btnVerHistorialPedidos.Size = new System.Drawing.Size(224, 68);
            this.btnVerHistorialPedidos.TabIndex = 2;
            this.btnVerHistorialPedidos.Text = "Ver el histórico de sus pedidos";
            this.btnVerHistorialPedidos.UseVisualStyleBackColor = true;
            this.btnVerHistorialPedidos.Click += new System.EventHandler(this.btnVerHistoriaPedidos_Click);
            // 
            // MenuCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(631, 456);
            this.Controls.Add(this.btnVerHistorialPedidos);
            this.Controls.Add(this.btnRealizarPedido);
            this.Controls.Add(this.btnRegistrarMascota);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MenuCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuCliente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuCliente_FormClosed);
            this.Load += new System.EventHandler(this.MenuCliente_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarMascota;
        private System.Windows.Forms.Button btnRealizarPedido;
        private System.Windows.Forms.Button btnVerHistorialPedidos;
    }
}