using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using TP7.Presentacion;
using TP7.Vistas;
using TP7.Presentacion.Interfaces;
using TP7.Datos;
using TP7.AccesoADatos.Repositorio;

namespace TP7
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var contenedor = new UnityContainer();
            contenedor.RegisterType<IListaProductos, VistaListaProductos>();
            contenedor.RegisterType<IRepositorio, Repository>();
            contenedor.RegisterType<IVistaProducto, VistaProducto>();       
            var vista = contenedor.Resolve<VistaPrincipal>();
            Application.Run(vista);
        }
    }
}
