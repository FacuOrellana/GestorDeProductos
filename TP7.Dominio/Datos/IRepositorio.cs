using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP7.Dominio;

namespace TP7.Datos
{
    public interface IRepositorio
    {
         Producto BuscarProducto(int codigo);
         void AgregarProducto(Producto producto);
        bool ExisteProducto(int codigo);
        void ActualizarProducto(Producto producto);
        void EliminarProducto(int codigo);
        List<Producto> FiltrarLista(string descripcion);
        List<Producto> GetProductos();

    }
}
