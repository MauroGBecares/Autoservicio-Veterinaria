namespace Code_test_L2
{
    partial class RegistrarMascota
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
            this.dgvListadoMascotas = new System.Windows.Forms.DataGridView();
            this.lblNombreMascota = new System.Windows.Forms.Label();
            this.lblTipoMascota = new System.Windows.Forms.Label();
            this.lblPesoMascota = new System.Windows.Forms.Label();
            this.lblEdadMascota = new System.Windows.Forms.Label();
            this.lblEstaCastrado = new System.Windows.Forms.Label();
            this.txtNombreMascota = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.lblKg = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.cbxEstaCastrado = new System.Windows.Forms.CheckBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblSexoMascota = new System.Windows.Forms.Label();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoMascotas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListadoMascotas
            // 
            this.dgvListadoMascotas.AllowUserToResizeColumns = false;
            this.dgvListadoMascotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListadoMascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoMascotas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListadoMascotas.Location = new System.Drawing.Point(12, 329);
            this.dgvListadoMascotas.MultiSelect = false;
            this.dgvListadoMascotas.Name = "dgvListadoMascotas";
            this.dgvListadoMascotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoMascotas.Size = new System.Drawing.Size(708, 214);
            this.dgvListadoMascotas.TabIndex = 0;
            // 
            // lblNombreMascota
            // 
            this.lblNombreMascota.AutoSize = true;
            this.lblNombreMascota.Location = new System.Drawing.Point(219, 86);
            this.lblNombreMascota.Name = "lblNombreMascota";
            this.lblNombreMascota.Size = new System.Drawing.Size(117, 13);
            this.lblNombreMascota.TabIndex = 1;
            this.lblNombreMascota.Text = "Nombre de la Mascota:";
            // 
            // lblTipoMascota
            // 
            this.lblTipoMascota.AutoSize = true;
            this.lblTipoMascota.Location = new System.Drawing.Point(305, 112);
            this.lblTipoMascota.Name = "lblTipoMascota";
            this.lblTipoMascota.Size = new System.Drawing.Size(31, 13);
            this.lblTipoMascota.TabIndex = 2;
            this.lblTipoMascota.Text = "Tipo:";
            // 
            // lblPesoMascota
            // 
            this.lblPesoMascota.AutoSize = true;
            this.lblPesoMascota.Location = new System.Drawing.Point(302, 167);
            this.lblPesoMascota.Name = "lblPesoMascota";
            this.lblPesoMascota.Size = new System.Drawing.Size(34, 13);
            this.lblPesoMascota.TabIndex = 3;
            this.lblPesoMascota.Text = "Peso:";
            // 
            // lblEdadMascota
            // 
            this.lblEdadMascota.AutoSize = true;
            this.lblEdadMascota.Location = new System.Drawing.Point(301, 197);
            this.lblEdadMascota.Name = "lblEdadMascota";
            this.lblEdadMascota.Size = new System.Drawing.Size(35, 13);
            this.lblEdadMascota.TabIndex = 4;
            this.lblEdadMascota.Text = "Edad:";
            // 
            // lblEstaCastrado
            // 
            this.lblEstaCastrado.AutoSize = true;
            this.lblEstaCastrado.Location = new System.Drawing.Point(258, 228);
            this.lblEstaCastrado.Name = "lblEstaCastrado";
            this.lblEstaCastrado.Size = new System.Drawing.Size(78, 13);
            this.lblEstaCastrado.TabIndex = 5;
            this.lblEstaCastrado.Text = "Esta castrado?";
            // 
            // txtNombreMascota
            // 
            this.txtNombreMascota.Location = new System.Drawing.Point(342, 83);
            this.txtNombreMascota.Name = "txtNombreMascota";
            this.txtNombreMascota.Size = new System.Drawing.Size(133, 20);
            this.txtNombreMascota.TabIndex = 6;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(342, 164);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(61, 20);
            this.txtPeso.TabIndex = 7;
            this.txtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeso_KeyPress);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(342, 194);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(61, 20);
            this.txtEdad.TabIndex = 8;
            this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdad_KeyPress);
            // 
            // lblKg
            // 
            this.lblKg.AutoSize = true;
            this.lblKg.Location = new System.Drawing.Point(409, 167);
            this.lblKg.Name = "lblKg";
            this.lblKg.Size = new System.Drawing.Size(20, 13);
            this.lblKg.TabIndex = 9;
            this.lblKg.Text = "Kg";
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(342, 109);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(133, 21);
            this.cboTipo.TabIndex = 10;
            // 
            // cbxEstaCastrado
            // 
            this.cbxEstaCastrado.AutoSize = true;
            this.cbxEstaCastrado.Location = new System.Drawing.Point(342, 227);
            this.cbxEstaCastrado.Name = "cbxEstaCastrado";
            this.cbxEstaCastrado.Size = new System.Drawing.Size(15, 14);
            this.cbxEstaCastrado.TabIndex = 11;
            this.cbxEstaCastrado.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(204, 276);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(400, 276);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblSexoMascota
            // 
            this.lblSexoMascota.AutoSize = true;
            this.lblSexoMascota.Location = new System.Drawing.Point(301, 140);
            this.lblSexoMascota.Name = "lblSexoMascota";
            this.lblSexoMascota.Size = new System.Drawing.Size(34, 13);
            this.lblSexoMascota.TabIndex = 14;
            this.lblSexoMascota.Text = "Sexo:";
            // 
            // cboSexo
            // 
            this.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Location = new System.Drawing.Point(341, 137);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(134, 21);
            this.cboSexo.TabIndex = 15;
            // 
            // RegistrarMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(732, 555);
            this.Controls.Add(this.cboSexo);
            this.Controls.Add(this.lblSexoMascota);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbxEstaCastrado);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.lblKg);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtNombreMascota);
            this.Controls.Add(this.lblEstaCastrado);
            this.Controls.Add(this.lblEdadMascota);
            this.Controls.Add(this.lblPesoMascota);
            this.Controls.Add(this.lblTipoMascota);
            this.Controls.Add(this.lblNombreMascota);
            this.Controls.Add(this.dgvListadoMascotas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RegistrarMascota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrarMascota";
            this.Load += new System.EventHandler(this.RegistrarMascota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoMascotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListadoMascotas;
        private System.Windows.Forms.Label lblNombreMascota;
        private System.Windows.Forms.Label lblTipoMascota;
        private System.Windows.Forms.Label lblPesoMascota;
        private System.Windows.Forms.Label lblEdadMascota;
        private System.Windows.Forms.Label lblEstaCastrado;
        private System.Windows.Forms.TextBox txtNombreMascota;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label lblKg;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.CheckBox cbxEstaCastrado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblSexoMascota;
        private System.Windows.Forms.ComboBox cboSexo;
    }
}