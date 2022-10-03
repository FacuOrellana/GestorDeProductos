using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP7.Dominio;
using TP7.Presentadores;

namespace TP7.Presentacion.Interfaces
{
    public interface IVistaProducto
    {

        void Salir();
        void Mostrar(bool editar, Producto producto);
        Producto Buscar();
        void Limpiar();
        void GuardarOModificar();
        void SetPresentador(VistaProductoPresentador presentador);
        event Action Actualizar;

    }
}
