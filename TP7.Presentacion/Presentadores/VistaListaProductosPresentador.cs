using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP7.Datos;
using TP7.Dominio;
using TP7.Presentacion.Interfaces;
using TP7.Vistas;

namespace TP7.Presentadores
{
    public class VistaListaProductosPresentador
    {
        public IListaProductos _vistaListaProductos;
        public VistaProductoPresentador _vistaProductoPresentador;
        public IRepositorio _repositorio;



        public VistaListaProductosPresentador(IListaProductos vista, IRepositorio repositorio, VistaProductoPresentador productoPresentador)
        {
            _vistaListaProductos = vista;
            _repositorio = repositorio;
            _vistaProductoPresentador = productoPresentador;
            _vistaProductoPresentador.SetListaPresentador(this);
            _vistaProductoPresentador.SetRepositorio(repositorio);
            _vistaListaProductos.SetPresentador(this);
            
        }


        public void Iniciar(IVistaPrincipal vista)
        {

            _vistaListaProductos.Mostrar(vista);
            ActualizarLista();

        }

        public void AgregarProducto()
        {

            _vistaProductoPresentador.Mostrar();
            ActualizarLista();

        }

        public void ActualizarLista()
        {
            _vistaListaProductos.Actualizar(_repositorio.GetProductos());
        }

        public void EliminarProducto(Producto producto)
        {

            _repositorio.EliminarProducto(producto.Codigo);
            ActualizarLista();

        }

        public void EditarProducto(Producto producto)
        {
            _vistaProductoPresentador.MostrarProducto(producto);
        }
        public List<Producto> FiltrarLista(string descripcion)
        {
            return _repositorio.FiltrarLista(descripcion);
        }

    }
}
