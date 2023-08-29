using Dominio;
using Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class ListasVendedoresClientes : Form
    {
        private Usuario user = null; 
        List<Vendedor> listaVendedores;
        List<Cliente> listaClientes;
        /*
         * Esta ventana contiene 3 constructores en el cual si el mismo no recibe nada, me muestra los clientes(dueños), 
         * si recibe un vendedor me muestra los vendedores o si es cliente me muestra las mascotas del mismo.
         */
        public ListasVendedoresClientes()
        {
            InitializeComponent();
            Text = "Listado de dueños";
        }
        public ListasVendedoresClientes(Vendedor userVendedor)
        {
            this.user = userVendedor;
            InitializeComponent();
            btnVerMascotasDelCliente.Visible = false;
            this.Size = new Size(821, 563);
            Text = "Listado de Vendedores";
        }
        public ListasVendedoresClientes(Cliente cliente)
        {
            this.user = cliente;
            InitializeComponent();
            this.BackColor = Color.Peru;
            btnVerMascotasDelCliente.Visible = false;
            this.Size = new Size(500, 500);
            dgvListaVendedoresClientes.Size = new Size(450, 400);
            Text = "Mascotas";
            lblBuscar.Visible = false;
            txtFiltro.Visible = false;
        }

        private void ListaVendedores_Load(object sender, EventArgs e)
        {
            cargar();
        }
        // Se actulizan o cargan los listados segun lo que haya recibido el constructor
        public void cargar()
        {
            if (user is Vendedor)
            {
                dgvListaVendedoresClientes.AutoGenerateColumns = false;

                DataGridViewTextBoxColumn nombreApellidoColumn = new DataGridViewTextBoxColumn();
                nombreApellidoColumn.HeaderText = "Apellido y Nombre";
                nombreApellidoColumn.DataPropertyName = "ApellidoNombre";

                DataGridViewTextBoxColumn direccionColumn = new DataGridViewTextBoxColumn();
                direccionColumn.HeaderText = "Dirección";
                direccionColumn.DataPropertyName = "Direccion";

                DataGridViewTextBoxColumn telefonoColumn = new DataGridViewTextBoxColumn();
                telefonoColumn.HeaderText = "Teléfono";
                telefonoColumn.DataPropertyName = "Telefono";

                DataGridViewTextBoxColumn cantidadVentasColumn = new DataGridViewTextBoxColumn();
                cantidadVentasColumn.HeaderText = "Cantidad de Ventas";
                cantidadVentasColumn.DataPropertyName = "CantidadVentas";

                dgvListaVendedoresClientes.Columns.AddRange(new DataGridViewColumn[] {
                nombreApellidoColumn, direccionColumn, telefonoColumn, cantidadVentasColumn
                });
                listaVendedores = Utilities.cargarVendedores();
                dgvListaVendedoresClientes.DataSource = listaVendedores;
            }
            else if (user is null)
            {
                dgvListaVendedoresClientes.AutoGenerateColumns = true;
                listaClientes = Utilities.cargarClientes();
                dgvListaVendedoresClientes.DataSource = listaClientes;
                ocultarColumnas();
            }
            else if (user is Cliente cliente)
            {
                dgvListaVendedoresClientes.AutoGenerateColumns = true;
                dgvListaVendedoresClientes.DataSource = cliente.Mascotas;
            }
        }

        private void btnVerMascotasDelCliente_Click(object sender, EventArgs e)
        {
            if (dgvListaVendedoresClientes.CurrentRow != null) //Valida si hay algo seleccionado
            {
                Cliente seleccionado = (Cliente)dgvListaVendedoresClientes.CurrentRow.DataBoundItem;
                ListasVendedoresClientes nuevaVentana = new ListasVendedoresClientes(seleccionado);
                nuevaVentana.ShowDialog(); // Esta ventana me muestra las mascotas del cliente al apretar el botón
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente.");
            }
        }
        /*
         * Esto se trata de un filtro rápido, que al escribir en el mismo lo que contenga el Apellido y Nombre, me actualiza la lista
         * segun lo que se desea buscar
         */
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtFiltro.Text; 

            if (user is Vendedor) 
            {
                List<Vendedor> listaFiltradaVendedores;

                if (filtro.Length > 2) // Me empieza a filtrar la lista cuando se ingresan mas de dos caracteres.
                    listaFiltradaVendedores = listaVendedores.FindAll(x => x.ApellidoNombre.ToUpper().Contains(filtro.ToUpper()));
                else
                    listaFiltradaVendedores = listaVendedores;

                dgvListaVendedoresClientes.DataSource = null;
                dgvListaVendedoresClientes.DataSource = listaFiltradaVendedores;
                ocultarColumnas();
            }
            else if (user is null)
            {
                List<Cliente> listaFiltradaClientes;

                if (filtro.Length > 2)
                    listaFiltradaClientes = listaClientes.FindAll(x => x.ApellidoNombre.ToUpper().Contains(filtro.ToUpper()));
                else
                    listaFiltradaClientes = listaClientes;

                dgvListaVendedoresClientes.DataSource = null;
                dgvListaVendedoresClientes.DataSource = listaFiltradaClientes;
                ocultarColumnas();
            }
        }
        // Lo siguiente oculta las culumnas del DataGridView que no se desean mostrar.
        public void ocultarColumnas()
        {
            dgvListaVendedoresClientes.Columns["Password"].Visible = false;
            dgvListaVendedoresClientes.Columns["User"].Visible = false;
        }
    }
}
