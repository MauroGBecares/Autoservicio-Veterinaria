namespace Interfaz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarMascota));
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
            this.lblSexoMascota = new System.Windows.Forms.Label();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.btnQuitarMascota = new System.Windows.Forms.Button();
            this.lblSeleccione = new System.Windows.Forms.Label();
            this.btnModificarMascota = new System.Windows.Forms.Button();
            this.btnAceptarModificacion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoMascotas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListadoMascotas
            // 
            this.dgvListadoMascotas.AllowUserToAddRows = false;
            this.dgvListadoMascotas.AllowUserToResizeColumns = false;
            this.dgvListadoMascotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListadoMascotas.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dgvListadoMascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoMascotas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListadoMascotas.Location = new System.Drawing.Point(12, 248);
            this.dgvListadoMascotas.MultiSelect = false;
            this.dgvListadoMascotas.Name = "dgvListadoMascotas";
            this.dgvListadoMascotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoMascotas.Size = new System.Drawing.Size(708, 258);
            this.dgvListadoMascotas.TabIndex = 0;
            // 
            // lblNombreMascota
            // 
            this.lblNombreMascota.AutoSize = true;
            this.lblNombreMascota.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMascota.Location = new System.Drawing.Point(118, 70);
            this.lblNombreMascota.Name = "lblNombreMascota";
            this.lblNombreMascota.Size = new System.Drawing.Size(153, 16);
            this.lblNombreMascota.TabIndex = 1;
            this.lblNombreMascota.Text = "Nombre de la Mascota:";
            // 
            // lblTipoMascota
            // 
            this.lblTipoMascota.AutoSize = true;
            this.lblTipoMascota.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoMascota.Location = new System.Drawing.Point(231, 96);
            this.lblTipoMascota.Name = "lblTipoMascota";
            this.lblTipoMascota.Size = new System.Drawing.Size(39, 16);
            this.lblTipoMascota.TabIndex = 2;
            this.lblTipoMascota.Text = "Tipo:";
            // 
            // lblPesoMascota
            // 
            this.lblPesoMascota.AutoSize = true;
            this.lblPesoMascota.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesoMascota.Location = new System.Drawing.Point(226, 151);
            this.lblPesoMascota.Name = "lblPesoMascota";
            this.lblPesoMascota.Size = new System.Drawing.Size(42, 16);
            this.lblPesoMascota.TabIndex = 3;
            this.lblPesoMascota.Text = "Peso:";
            // 
            // lblEdadMascota
            // 
            this.lblEdadMascota.AutoSize = true;
            this.lblEdadMascota.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdadMascota.Location = new System.Drawing.Point(225, 181);
            this.lblEdadMascota.Name = "lblEdadMascota";
            this.lblEdadMascota.Size = new System.Drawing.Size(43, 16);
            this.lblEdadMascota.TabIndex = 4;
            this.lblEdadMascota.Text = "Edad:";
            // 
            // lblEstaCastrado
            // 
            this.lblEstaCastrado.AutoSize = true;
            this.lblEstaCastrado.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstaCastrado.Location = new System.Drawing.Point(169, 210);
            this.lblEstaCastrado.Name = "lblEstaCastrado";
            this.lblEstaCastrado.Size = new System.Drawing.Size(99, 16);
            this.lblEstaCastrado.TabIndex = 5;
            this.lblEstaCastrado.Text = "Esta castrado?";
            // 
            // txtNombreMascota
            // 
            this.txtNombreMascota.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreMascota.Location = new System.Drawing.Point(274, 67);
            this.txtNombreMascota.Name = "txtNombreMascota";
            this.txtNombreMascota.Size = new System.Drawing.Size(133, 22);
            this.txtNombreMascota.TabIndex = 0;
            // 
            // txtPeso
            // 
            this.txtPeso.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.Location = new System.Drawing.Point(274, 148);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(61, 22);
            this.txtPeso.TabIndex = 3;
            this.txtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeso_KeyPress);
            // 
            // txtEdad
            // 
            this.txtEdad.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.Location = new System.Drawing.Point(274, 178);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(61, 22);
            this.txtEdad.TabIndex = 4;
            this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdad_KeyPress);
            // 
            // lblKg
            // 
            this.lblKg.AutoSize = true;
            this.lblKg.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKg.Location = new System.Drawing.Point(340, 151);
            this.lblKg.Name = "lblKg";
            this.lblKg.Size = new System.Drawing.Size(24, 16);
            this.lblKg.TabIndex = 9;
            this.lblKg.Text = "Kg";
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(273, 93);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(134, 24);
            this.cboTipo.TabIndex = 1;
            // 
            // cbxEstaCastrado
            // 
            this.cbxEstaCastrado.AutoSize = true;
            this.cbxEstaCastrado.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEstaCastrado.Location = new System.Drawing.Point(274, 212);
            this.cbxEstaCastrado.Name = "cbxEstaCastrado";
            this.cbxEstaCastrado.Size = new System.Drawing.Size(15, 14);
            this.cbxEstaCastrado.TabIndex = 5;
            this.cbxEstaCastrado.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(446, 190);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 38);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblSexoMascota
            // 
            this.lblSexoMascota.AutoSize = true;
            this.lblSexoMascota.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexoMascota.Location = new System.Drawing.Point(225, 124);
            this.lblSexoMascota.Name = "lblSexoMascota";
            this.lblSexoMascota.Size = new System.Drawing.Size(44, 16);
            this.lblSexoMascota.TabIndex = 14;
            this.lblSexoMascota.Text = "Sexo:";
            // 
            // cboSexo
            // 
            this.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexo.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Location = new System.Drawing.Point(273, 121);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(134, 24);
            this.cboSexo.TabIndex = 2;
            // 
            // btnQuitarMascota
            // 
            this.btnQuitarMascota.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarMascota.Location = new System.Drawing.Point(240, 512);
            this.btnQuitarMascota.Name = "btnQuitarMascota";
            this.btnQuitarMascota.Size = new System.Drawing.Size(108, 38);
            this.btnQuitarMascota.TabIndex = 7;
            this.btnQuitarMascota.Text = "Quitar Mascota";
            this.btnQuitarMascota.UseVisualStyleBackColor = true;
            this.btnQuitarMascota.Click += new System.EventHandler(this.btnQuitarMascota_Click);
            // 
            // lblSeleccione
            // 
            this.lblSeleccione.AutoSize = true;
            this.lblSeleccione.Font = new System.Drawing.Font("Arial", 9.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccione.Location = new System.Drawing.Point(12, 521);
            this.lblSeleccione.Name = "lblSeleccione";
            this.lblSeleccione.Size = new System.Drawing.Size(200, 16);
            this.lblSeleccione.TabIndex = 17;
            this.lblSeleccione.Text = "Seleccione una mascota para:";
            // 
            // btnModificarMascota
            // 
            this.btnModificarMascota.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarMascota.Location = new System.Drawing.Point(354, 512);
            this.btnModificarMascota.Name = "btnModificarMascota";
            this.btnModificarMascota.Size = new System.Drawing.Size(126, 38);
            this.btnModificarMascota.TabIndex = 8;
            this.btnModificarMascota.Text = "Modificar Atributos";
            this.btnModificarMascota.UseVisualStyleBackColor = true;
            this.btnModificarMascota.Click += new System.EventHandler(this.btnModificarMascota_Click);
            // 
            // btnAceptarModificacion
            // 
            this.btnAceptarModificacion.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarModificacion.Location = new System.Drawing.Point(446, 190);
            this.btnAceptarModificacion.Name = "btnAceptarModificacion";
            this.btnAceptarModificacion.Size = new System.Drawing.Size(75, 38);
            this.btnAceptarModificacion.TabIndex = 19;
            this.btnAceptarModificacion.Text = "Modificar";
            this.btnAceptarModificacion.UseVisualStyleBackColor = true;
            this.btnAceptarModificacion.Click += new System.EventHandler(this.btnAceptarModificacion_Click);
            // 
            // RegistrarMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(732, 555);
            this.Controls.Add(this.btnAceptarModificacion);
            this.Controls.Add(this.btnModificarMascota);
            this.Controls.Add(this.lblSeleccione);
            this.Controls.Add(this.btnQuitarMascota);
            this.Controls.Add(this.cboSexo);
            this.Controls.Add(this.lblSexoMascota);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrarMascota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Mascota";
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
        private System.Windows.Forms.Label lblSexoMascota;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.Button btnQuitarMascota;
        private System.Windows.Forms.Label lblSeleccione;
        private System.Windows.Forms.Button btnModificarMascota;
        private System.Windows.Forms.Button btnAceptarModificacion;
    }
}