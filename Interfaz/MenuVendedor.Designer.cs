﻿namespace Interfaz
{
    partial class MenuVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuVendedor));
            this.btnPedidosRecibidos = new System.Windows.Forms.Button();
            this.btnListadoVendedores = new System.Windows.Forms.Button();
            this.btnMascotasClientes = new System.Windows.Forms.Button();
            this.btnCrearNuevoVendedor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPedidosRecibidos
            // 
            this.btnPedidosRecibidos.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidosRecibidos.Location = new System.Drawing.Point(147, 46);
            this.btnPedidosRecibidos.Name = "btnPedidosRecibidos";
            this.btnPedidosRecibidos.Size = new System.Drawing.Size(254, 57);
            this.btnPedidosRecibidos.TabIndex = 0;
            this.btnPedidosRecibidos.Text = "Pedidos Recibidos";
            this.btnPedidosRecibidos.UseVisualStyleBackColor = true;
            this.btnPedidosRecibidos.Click += new System.EventHandler(this.btnPedidosRecibidos_Click_1);
            // 
            // btnListadoVendedores
            // 
            this.btnListadoVendedores.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListadoVendedores.Location = new System.Drawing.Point(147, 109);
            this.btnListadoVendedores.Name = "btnListadoVendedores";
            this.btnListadoVendedores.Size = new System.Drawing.Size(254, 66);
            this.btnListadoVendedores.TabIndex = 1;
            this.btnListadoVendedores.Text = "Ver lista de Vendedores";
            this.btnListadoVendedores.UseVisualStyleBackColor = true;
            this.btnListadoVendedores.Click += new System.EventHandler(this.btnListadoVendedores_Click);
            // 
            // btnMascotasClientes
            // 
            this.btnMascotasClientes.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMascotasClientes.Location = new System.Drawing.Point(147, 181);
            this.btnMascotasClientes.Name = "btnMascotasClientes";
            this.btnMascotasClientes.Size = new System.Drawing.Size(254, 69);
            this.btnMascotasClientes.TabIndex = 2;
            this.btnMascotasClientes.Text = "Ver Mascotas y Dueños";
            this.btnMascotasClientes.UseVisualStyleBackColor = true;
            this.btnMascotasClientes.Click += new System.EventHandler(this.btnMascotasClientes_Click);
            // 
            // btnCrearNuevoVendedor
            // 
            this.btnCrearNuevoVendedor.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearNuevoVendedor.Location = new System.Drawing.Point(147, 256);
            this.btnCrearNuevoVendedor.Name = "btnCrearNuevoVendedor";
            this.btnCrearNuevoVendedor.Size = new System.Drawing.Size(254, 71);
            this.btnCrearNuevoVendedor.TabIndex = 3;
            this.btnCrearNuevoVendedor.Text = "Crear nuevo usuario como Vendedor";
            this.btnCrearNuevoVendedor.UseVisualStyleBackColor = true;
            this.btnCrearNuevoVendedor.Click += new System.EventHandler(this.btnCrearNuevoVendedor_Click);
            // 
            // MenuVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(557, 387);
            this.Controls.Add(this.btnCrearNuevoVendedor);
            this.Controls.Add(this.btnMascotasClientes);
            this.Controls.Add(this.btnListadoVendedores);
            this.Controls.Add(this.btnPedidosRecibidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuVendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuVendedor_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPedidosRecibidos;
        private System.Windows.Forms.Button btnListadoVendedores;
        private System.Windows.Forms.Button btnMascotasClientes;
        private System.Windows.Forms.Button btnCrearNuevoVendedor;
    }
}