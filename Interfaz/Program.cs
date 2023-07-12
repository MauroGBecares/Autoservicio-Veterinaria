﻿using BaseDatos;
using System;
using System.Windows.Forms;

namespace Interfaz
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Database.HardcodearBaseDeDatos();
            Application.Run(new InicioSesion());
        }
    }
}
