namespace Interfaz
{
    partial class ListasVendedoresClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListasVendedoresClientes));
            this.dgvListaVendedoresClientes = new System.Windows.Forms.DataGridView();
            this.btnVerMascotasDelCliente = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVendedoresClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaVendedoresClientes
            // 
            this.dgvListaVendedoresClientes.AllowUserToResizeColumns = false;
            this.dgvListaVendedoresClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaVendedoresClientes.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvListaVendedoresClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaVendedoresClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListaVendedoresClientes.Location = new System.Drawing.Point(12, 44);
            this.dgvListaVendedoresClientes.MultiSelect = false;
            this.dgvListaVendedoresClientes.Name = "dgvListaVendedoresClientes";
            this.dgvListaVendedoresClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaVendedoresClientes.Size = new System.Drawing.Size(781, 469);
            this.dgvListaVendedoresClientes.TabIndex = 1;
            // 
            // btnVerMascotasDelCliente
            // 
            this.btnVerMascotasDelCliente.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerMascotasDelCliente.Location = new System.Drawing.Point(26, 519);
            this.btnVerMascotasDelCliente.Name = "btnVerMascotasDelCliente";
            this.btnVerMascotasDelCliente.Size = new System.Drawing.Size(218, 46);
            this.btnVerMascotasDelCliente.TabIndex = 2;
            this.btnVerMascotasDelCliente.Text = "Ver Mascotas del Cliente";
            this.btnVerMascotasDelCliente.UseVisualStyleBackColor = true;
            this.btnVerMascotasDelCliente.Click += new System.EventHandler(this.btnVerMascotasDelCliente_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(23, 19);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(52, 16);
            this.lblBuscar.TabIndex = 2;
            this.lblBuscar.Text = "Buscar:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(81, 16);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(112, 22);
            this.txtFiltro.TabIndex = 0;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // ListasVendedoresClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(805, 573);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btnVerMascotasDelCliente);
            this.Controls.Add(this.dgvListaVendedoresClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListasVendedoresClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ListaVendedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVendedoresClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaVendedoresClientes;
        private System.Windows.Forms.Button btnVerMascotasDelCliente;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtFiltro;
    }
}