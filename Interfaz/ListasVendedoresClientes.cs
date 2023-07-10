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

namespace Code_test_L2
{
    public partial class ListasVendedoresClientes : Form
    {
        private Usuario user = null;
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
            this.BackColor = Color.DarkOrange;
            btnVerMascotasDelCliente.Visible = false;
            this.Size = new Size(500, 500);
            dgvListaVendedoresClientes.Size = new Size(450,435);
            Text = "Mascotas";
        }

        private void ListaVendedores_Load(object sender, EventArgs e)
        {
            cargar();
        }
        public void cargar()
        {
            if (user is Vendedor)
            {
                dgvListaVendedoresClientes.DataSource = Utilities.cargarVendedores();
                dgvListaVendedoresClientes.Columns["Password"].Visible = false;
                dgvListaVendedoresClientes.Columns["User"].Visible = false;
            }
            else if (user is null)
            {
                dgvListaVendedoresClientes.DataSource = Utilities.cargarClientes();
                dgvListaVendedoresClientes.Columns["Password"].Visible = false;
                dgvListaVendedoresClientes.Columns["User"].Visible = false;
            }
            else if (user is Cliente cliente)
            {
                dgvListaVendedoresClientes.DataSource = cliente.Mascotas;
            }
        }

        private void btnVerMascotasDelCliente_Click(object sender, EventArgs e)
        {
            Cliente seleccionado = (Cliente)dgvListaVendedoresClientes.CurrentRow.DataBoundItem;
            ListasVendedoresClientes nuevaVentana = new ListasVendedoresClientes(seleccionado);
            nuevaVentana.ShowDialog();
        }
    }
}
