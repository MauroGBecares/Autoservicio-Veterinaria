namespace Code_test_L2
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
            this.dgvListaVendedoresClientes = new System.Windows.Forms.DataGridView();
            this.btnVerMascotasDelCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVendedoresClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaVendedoresClientes
            // 
            this.dgvListaVendedoresClientes.AllowUserToResizeColumns = false;
            this.dgvListaVendedoresClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaVendedoresClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaVendedoresClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListaVendedoresClientes.Location = new System.Drawing.Point(12, 12);
            this.dgvListaVendedoresClientes.MultiSelect = false;
            this.dgvListaVendedoresClientes.Name = "dgvListaVendedoresClientes";
            this.dgvListaVendedoresClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaVendedoresClientes.Size = new System.Drawing.Size(781, 501);
            this.dgvListaVendedoresClientes.TabIndex = 0;
            // 
            // btnVerMascotasDelCliente
            // 
            this.btnVerMascotasDelCliente.Location = new System.Drawing.Point(26, 519);
            this.btnVerMascotasDelCliente.Name = "btnVerMascotasDelCliente";
            this.btnVerMascotasDelCliente.Size = new System.Drawing.Size(218, 46);
            this.btnVerMascotasDelCliente.TabIndex = 1;
            this.btnVerMascotasDelCliente.Text = "Ver Mascotas del Cliente";
            this.btnVerMascotasDelCliente.UseVisualStyleBackColor = true;
            this.btnVerMascotasDelCliente.Click += new System.EventHandler(this.btnVerMascotasDelCliente_Click);
            // 
            // ListasVendedoresClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(805, 573);
            this.Controls.Add(this.btnVerMascotasDelCliente);
            this.Controls.Add(this.dgvListaVendedoresClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ListasVendedoresClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ListaVendedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVendedoresClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaVendedoresClientes;
        private System.Windows.Forms.Button btnVerMascotasDelCliente;
    }
}