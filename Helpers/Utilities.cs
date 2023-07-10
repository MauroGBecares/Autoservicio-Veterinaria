using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Helpers
{
    public class Utilities
    {
        public static bool validarCajasDeTextoVacias(string texto1, string texto2, string texto3, string texto4, string texto5)
        {
            if (string.IsNullOrEmpty(texto1) && string.IsNullOrEmpty(texto2) && string.IsNullOrEmpty(texto3) && string.IsNullOrEmpty(texto4) && string.IsNullOrEmpty(texto5))
            {
                return false;
            }
            return true;
        }
        public static Usuario buscarUsuario(string user)
        {
            foreach (var item in Database.Usuarios)
            {
                if (item.User == user)
                {
                    return item;
                }
            }
            return null;
        }
        public static bool validarPassword(Usuario user, string pass)
        {
            foreach (var item in Database.Usuarios)
            {
                if (item == user)
                {
                    if (item.Password == pass)
                        return true;
                }
            }
            return false;
        }
        public static string asignarCodigoPedido()
        {
            int buscarCodigo = 100;

            while (true)
            {
                bool encontrado = false;

                foreach (Usuario usuario in Database.Usuarios)
                {
                    if (usuario is Cliente cliente)
                    {
                        foreach (Pedido pedido in cliente.Pedidos)
                        {
                            if (pedido.CodigoPedido == buscarCodigo)
                            {
                                encontrado = true;
                                break;
                            }
                        }
                    }
                    if (encontrado)
                        break;
                }

                if (!encontrado)
                {
                    return buscarCodigo.ToString();
                }

                buscarCodigo++;
            }
        }
        public static List<Vendedor> cargarVendedores()
        {
            List<Vendedor> listaVendedores = new List<Vendedor>();
            foreach (var item in Database.Usuarios)
            {
                if (item is Vendedor vendedor)
                {
                    listaVendedores.Add(vendedor);
                }
            }
            return listaVendedores;
        }
        public static List<Cliente> cargarClientes()
        {
            List<Cliente> listaClientes = new List<Cliente>();
            foreach (var item in Database.Usuarios)
            {
                if (item is Cliente cliente)
                {
                    listaClientes.Add(cliente);
                }
            }
            return listaClientes;
        }
    
        public static List<Pedido> cargarPedidosSegunVendedor(string nombreVendedor)
        {
            List<Pedido> listaPedidos = new List<Pedido>();
            foreach (Usuario usuario in Database.Usuarios)
            {
                if (usuario is Cliente cliente)
                {
                    foreach (Pedido pedido in cliente.Pedidos)
                    {
                        if (pedido.Vendedor == nombreVendedor)
                            listaPedidos.Add(pedido);
                    }
                }
            }
            return listaPedidos;
        }
        public static void agregarVentaVendedor(string nombreVendedor)
        {
            foreach (Usuario usuario in Database.Usuarios)
            {
                if (usuario is Vendedor vendedor)
                {
                    if (vendedor.ApellidoNombre == nombreVendedor)
                        vendedor.CantidadVentas++;
                }
            }
        }
        public static void eliminarVentaVendedor(string nombreVendedor)
        {
            foreach (Usuario usuario in Database.Usuarios)
            {
                if (usuario is Vendedor vendedor)
                {
                    if (vendedor.ApellidoNombre == nombreVendedor)
                        vendedor.CantidadVentas--;
                }
            }
        }

    }
}
