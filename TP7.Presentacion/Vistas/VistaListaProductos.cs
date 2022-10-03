using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP7.Presentadores;
using TP7.Datos;
using TP7.Dominio;
using TP7.Presentacion.Interfaces;

namespace TP7.Vistas
{
    public partial class VistaListaProductos : Form, IListaProductos
    {
        private VistaListaProductosPresentador _presentador;
        

        public VistaListaProductos()
        {
            InitializeComponent(); 
            

        }
        private void VistaListaProductos_Load(object sender, EventArgs e)
        {
           
        }
        private void BotonAgregar(object sender, EventArgs e)
        {

            _presentador.AgregarProducto();
            _presentador.ActualizarLista();

        }

        private void EditarClick(object sender, EventArgs e)
        {

            _presentador.EditarProducto(productoBindingSource.Current as Producto);
        }

        private void EliminarClick(object sender, EventArgs e)
        {
            
            _presentador.EliminarProducto(productoBindingSource.Current as Producto);
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            var lista = _presentador.FiltrarLista(txtFiltro.Text);
            ActualizarLista(lista);
        }

        private void ActualizarLista(List<Producto> lista)
        {
            if (lista == null)
            {
                MessageBox.Show("No existen productos para la la descripcion ingresada", "PAV 2020", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            productoBindingSource.DataSource = lista;
        }

       
        public void Mostrar(IVistaPrincipal vista)
        {
            MdiParent = (VistaPrincipal)vista;
            WindowState = FormWindowState.Maximized;
            Show();
        }

        public void Actualizar(List<Producto> productos)
        {
            productoBindingSource.ResetBindings(false);
            productoBindingSource.DataSource = productos;            

        }

        public void SetPresentador(VistaListaProductosPresentador presentador)
        {
            _presentador = presentador;
        }
    }
}
