namespace Interfaz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuCliente));
            this.btnRegistrarMascota = new System.Windows.Forms.Button();
            this.btnRealizarPedido = new System.Windows.Forms.Button();
            this.btnVerHistorialPedidos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegistrarMascota
            // 
            this.btnRegistrarMascota.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRegistrarMascota.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarMascota.Location = new System.Drawing.Point(135, 57);
            this.btnRegistrarMascota.Name = "btnRegistrarMascota";
            this.btnRegistrarMascota.Size = new System.Drawing.Size(248, 70);
            this.btnRegistrarMascota.TabIndex = 0;
            this.btnRegistrarMascota.Text = "Registrar mascota";
            this.btnRegistrarMascota.UseVisualStyleBackColor = true;
            this.btnRegistrarMascota.Click += new System.EventHandler(this.btnRegistrarMascota_Click);
            // 
            // btnRealizarPedido
            // 
            this.btnRealizarPedido.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRealizarPedido.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarPedido.Location = new System.Drawing.Point(135, 133);
            this.btnRealizarPedido.Name = "btnRealizarPedido";
            this.btnRealizarPedido.Size = new System.Drawing.Size(248, 84);
            this.btnRealizarPedido.TabIndex = 1;
            this.btnRealizarPedido.Text = "Realizar pedido";
            this.btnRealizarPedido.UseVisualStyleBackColor = true;
            this.btnRealizarPedido.Click += new System.EventHandler(this.btnRealizarPedido_Click);
            // 
            // btnVerHistorialPedidos
            // 
            this.btnVerHistorialPedidos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnVerHistorialPedidos.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerHistorialPedidos.Location = new System.Drawing.Point(135, 223);
            this.btnVerHistorialPedidos.Name = "btnVerHistorialPedidos";
            this.btnVerHistorialPedidos.Size = new System.Drawing.Size(248, 85);
            this.btnVerHistorialPedidos.TabIndex = 2;
            this.btnVerHistorialPedidos.Text = "Ver el histórico de sus pedidos";
            this.btnVerHistorialPedidos.UseVisualStyleBackColor = true;
            this.btnVerHistorialPedidos.Click += new System.EventHandler(this.btnVerHistoriaPedidos_Click);
            // 
            // MenuCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(526, 391);
            this.Controls.Add(this.btnVerHistorialPedidos);
            this.Controls.Add(this.btnRealizarPedido);
            this.Controls.Add(this.btnRegistrarMascota);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuCliente_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarMascota;
        private System.Windows.Forms.Button btnRealizarPedido;
        private System.Windows.Forms.Button btnVerHistorialPedidos;
    }
}