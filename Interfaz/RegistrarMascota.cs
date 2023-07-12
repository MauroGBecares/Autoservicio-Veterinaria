using Dominio;
using Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class RegistrarMascota : Form
    {
        private Cliente user;
        private List<Mascota> listadoMascotas;
        private Mascota mascotaSelecionada = null; // Me sirve como atributo de referencia para utilizarlo en dos eventos.
        public RegistrarMascota(Cliente cliente)
        {
            this.user = cliente;
            InitializeComponent();
            btnAceptarModificacion.Visible = false;
        }

        private void RegistrarMascota_Load(object sender, EventArgs e)
        {
            limpiarDatos();
            cargar();
        }
        // Al cargar la ventana, me actualiza el listado de mascotas que corresponde al cliente registrado.
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

            Mascota nuevaMascota = new Mascota(); // Creo una nueva mascota
            nuevaMascota.Nombre = txtNombreMascota.Text;
            nuevaMascota.Tipo = cboTipo.Text;
            nuevaMascota.Sexo = cboSexo.Text;
            nuevaMascota.Peso = float.Parse(txtPeso.Text);
            nuevaMascota.Edad = int.Parse(txtEdad.Text);
            nuevaMascota.EstaCastrado = cbxEstaCastrado.Checked;
            user.Mascotas.Add(nuevaMascota); // La agrego a la lista de mascotas del Cliente logueado.

            MessageBox.Show("Mascota cargada con éxito");
            limpiarDatos();
            cargar(); // Actualizo la lista.
        }
        // En lo siguiente realizo una validación para corroborar si hay espacios en blanco
        public bool validarCargaMascota() 
        {
            if (!(Utilities.validarCajasDeTextoVacias(txtNombreMascota.Text, cboTipo.Text, cboSexo.Text, txtPeso.Text, txtEdad.Text)))
            {
                MessageBox.Show("Hay espacio en blanco o no ingresados.");
                return false;
            }
            return true;
        }
        // Limpio los datos al cargar o modificar los atributos de una mascota.
        public void limpiarDatos()
        {
            txtNombreMascota.Text = string.Empty;
            txtEdad.Text = string.Empty;
            txtPeso.Text = string.Empty;
            cbxEstaCastrado.Checked = false;
            cboTipo.Items.Clear();
            cboTipo.Items.Add("Perro");
            cboTipo.Items.Add("Gato");
            cboSexo.Items.Clear();
            cboSexo.Items.Add("Macho");
            cboSexo.Items.Add("Hembra");
        }
        /*
         * El siguiente evento hace que el usuario solo pueda ingresar números y adicionalmente cuando yo utilice el 
         * teclado numérico me tome la "," en vez de un ".". 
         * Esto lo hice asi porque, el tipo de dato float toma la coma en vez del punto como válido y además
         * lo veo como algo más como para el usuario ya que solo tiene que usar el teclado númerico.
         */
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
        // Similar anterior solo que esta vez al tener que recibido un tipo de dato int, solo se necesita que ingrese números
        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        // Lo siguiente permite elimilar una mascota de la lista del Cliente.
        private void btnQuitarMascota_Click(object sender, EventArgs e)
        {
            if (dgvListadoMascotas.CurrentRow != null) // Valida si hay algo seleccionado
            {
                Mascota seleccionado = (Mascota)dgvListadoMascotas.CurrentRow.DataBoundItem;
                DialogResult resultado = MessageBox.Show("Esta seguro que quiere quitar la mascota?", "Quitar mascota", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    user.Mascotas.Remove(seleccionado);
                    cargar();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una mascota.");
            }
        }
        /*
         * Utilizo el atributo mascotaSelecionada para mostrarlos en los controles y los mismos me permiten modificarlo
         * según lo que desea el usuario
         */
        private void btnModificarMascota_Click(object sender, EventArgs e)
        {
            if (dgvListadoMascotas.CurrentRow != null)
            {
                // Desabilito o escondo los siguientes controles para evitar errores inesperados a la hora de modificar.
                btnAceptarModificacion.Visible = true;
                btnAgregar.Visible = false;
                btnQuitarMascota.Enabled = false;
                dgvListadoMascotas.Enabled = false;
                btnModificarMascota.Enabled = false;

                mascotaSelecionada = (Mascota)dgvListadoMascotas.CurrentRow.DataBoundItem;
                txtNombreMascota.Text = mascotaSelecionada.Nombre;
                cboTipo.Text = mascotaSelecionada.Tipo;
                cboSexo.Text = mascotaSelecionada.Sexo;
                txtPeso.Text = mascotaSelecionada.Peso.ToString();
                txtEdad.Text = mascotaSelecionada.Edad.ToString();
                cbxEstaCastrado.Checked = mascotaSelecionada.EstaCastrado;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una mascota.");
            }
        }
        // Lo siguiente aplico los cambios, reactivo los controles, limpio los controles de datos y actualizo la lista.
        private void btnAceptarModificacion_Click(object sender, EventArgs e)
        {
            mascotaSelecionada.Nombre = txtNombreMascota.Text;
            mascotaSelecionada.Tipo = cboTipo.Text;
            mascotaSelecionada.Sexo = cboSexo.Text;
            mascotaSelecionada.Peso = float.Parse(txtPeso.Text);
            mascotaSelecionada.Edad = int.Parse(txtEdad.Text);
            mascotaSelecionada.EstaCastrado = cbxEstaCastrado.Checked;

            btnAceptarModificacion.Visible = false;
            btnAgregar.Visible = true;
            btnQuitarMascota.Enabled = true;
            dgvListadoMascotas.Enabled = true;
            btnModificarMascota.Enabled = true;

            mascotaSelecionada = null;
            limpiarDatos();
            cargar();
        }
    }
}
