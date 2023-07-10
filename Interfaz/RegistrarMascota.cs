using Dominio;
using Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Code_test_L2
{
    public partial class RegistrarMascota : Form
    {
        private Cliente user;
        private List<Mascota> listadoMascotas;
        public RegistrarMascota(Cliente cliente)
        {
            this.user = cliente;
            InitializeComponent();
        }

        private void RegistrarMascota_Load(object sender, EventArgs e)
        {
            cboTipo.Items.Add("Perro");
            cboTipo.Items.Add("Gato");
            cboSexo.Items.Add("Macho");
            cboSexo.Items.Add("Hembra");
            cargar();
        }
        public void cargar()
        {
            listadoMascotas = user.Mascotas;
            dgvListadoMascotas.DataSource = null;
            dgvListadoMascotas.DataSource = listadoMascotas; 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!(validarCargaMascota()))
                return;

            Mascota nuevaMascota = new Mascota();
            nuevaMascota.Nombre = txtNombreMascota.Text;
            nuevaMascota.Tipo = cboTipo.Text;
            nuevaMascota.Sexo = cboSexo.Text;
            nuevaMascota.Peso = float.Parse(txtPeso.Text);
            nuevaMascota.Edad = int.Parse(txtEdad.Text);
            nuevaMascota.EstaCastrado = cbxEstaCastrado.Checked;
            user.Mascotas.Add(nuevaMascota);
            
            MessageBox.Show("Mascota cargada con éxito");
            limpiarDatos();
            cargar();
        }
        public bool validarCargaMascota()
        {
            if(!(Utilities.validarCajasDeTextoVacias(txtNombreMascota.Text, cboTipo.Text, cboSexo.Text, txtPeso.Text, txtEdad.Text)))
            {
                MessageBox.Show("Hay espacio en blanco o no ingresados.");
                return false;
            }
            return true;
        }
        public void limpiarDatos()
        {
            txtNombreMascota.Text = string.Empty;
            txtEdad.Text = string.Empty;
            txtPeso.Text = string.Empty;
            cboTipo.SelectedIndex = -1;
            cboSexo.SelectedIndex = -1;
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
