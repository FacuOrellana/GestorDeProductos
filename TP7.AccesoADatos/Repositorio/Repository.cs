using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP7.Datos;
using TP7.Dominio;

namespace TP7.AccesoADatos.Repositorio
{
    public class Repository : IRepositorio
    {

        public ProductosContext _context;

        public Repository(ProductosContext context)
        {
            _context = context;
        }

        public void ActualizarProducto(Producto producto)
        {
            _context.SaveChanges();
        }

        public void AgregarProducto(Producto producto)
        {
            _context.Productos.Add(producto);
            _context.SaveChanges();
        }

        public Producto BuscarProducto(int codigo)
        {
            var item = _context.Productos
                       .Where(p => p.Codigo == codigo)
                       .FirstOrDefault();

            return item;
        }

        public void EliminarProducto(int codigo)
        {
            var item = _context.Productos
                       .Where(p => p.Codigo == codigo)
                       .FirstOrDefault();

            _context.Productos.Remove(item);
            _context.SaveChanges();
        }

        public bool ExisteProducto(int codigo)
        {

            var item = _context.Productos
                      .Where(p => p.Codigo == codigo)
                      .FirstOrDefault();

            if (_context.Productos.ToList().Contains(item))
            {
                return true;
            }

            return false;
        }

        public List<Producto> FiltrarLista(string descripcion)
        {
            return _context.Productos.ToList().FindAll(p => p.Descripcion.ToLower().Contains(descripcion.ToLower()));

        }

        public List<Producto> GetProductos()
        {
            return _context.Productos.ToList();
        }
    }
}
