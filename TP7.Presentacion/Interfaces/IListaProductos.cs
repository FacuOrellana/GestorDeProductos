using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP7.Dominio;
using TP7.Presentadores;

namespace TP7.Presentacion.Interfaces
{
    public interface IListaProductos
    {

        void Mostrar(IVistaPrincipal vista);
        void Actualizar(List<Producto> productos);
        void SetPresentador(VistaListaProductosPresentador presentador);
    }
}
