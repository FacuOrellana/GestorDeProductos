using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP7.Dominio;

namespace TP7.Datos
{
    public class RepositorioProductos : IRepositorio
    {


        public List<Producto> miListaProductos { get; set; }

        public RepositorioProductos()
        {
            miListaProductos = new List<Producto>() {
            new Producto(1, "Galletas", 80.0,0.21,0.25,10,Estado.ACTIVO),
            new Producto(2, "Pepsi", 150.0, 0.21, 0.25, 20, Estado.ACTIVO),
            new Producto(3, "Sprite", 100.0, 0.21, 0.25, 30, Estado.ACTIVO),
            new Producto(4, "Donas", 45.0, 0.21, 0.25, 40, Estado.ACTIVO),
            new Producto(5, "Pan", 8.0, 0.21, 0.25, 50, Estado.ACTIVO),
            new Producto(6, "Vino tinto", 50.0, 0.21, 0.25, 60, Estado.ACTIVO),
            new Producto(7, "Fernet", 500.0, 0.21, 0.25, 50, Estado.ACTIVO),
            new Producto(8, "Corona", 60.0, 0.21, 0.25, 30, Estado.ACTIVO),
            new Producto(9, "Heineken", 180.0, 0.21, 0.25, 12, Estado.ACTIVO),
            new Producto(10, "Papas fritas", 130.0, 0.21, 0.25, 13, Estado.ACTIVO),
            new Producto(11, "Sanguche", 230.0, 0.21, 0.25, 23, Estado.ACTIVO)

            };


        }

        public Producto BuscarProducto(int codigo)
        {

            foreach (var producto in miListaProductos)
            {
                if (codigo == producto.Codigo)
                {


                    return producto;
                }
            }
            return null;

        }

        public void AgregarProducto(Producto producto)
        {
            bool condicion = false;
            foreach (var p in miListaProductos)
            {
                if (p.Codigo.Equals(producto.Codigo))
                {
                    condicion = true;
                }

            }

            if (condicion == false)
            {
                miListaProductos.Add(producto);
                MessageBox.Show("Se agrego el producto exitosamente");
                return;
            }

            
        }

        public bool ExisteProducto(int codigo)
        {
            foreach (var p in miListaProductos)
            {
                if (codigo == p.Codigo)
                {
                    return true;
                }
                if (p.Existencia < 0)
                {
                    MessageBox.Show("No existe stock de este producto");
                    return true;
                }
            }

            return false;

        }

        public void ActualizarProducto(Producto producto)
        {
            bool condicion = false;
            foreach (var p in miListaProductos)
            {
                if (p.Codigo.Equals(producto.Codigo))
                {
                    condicion = true;
                }

            }

            if (condicion == false)
            {
                if (producto.Validar())
                {
                    miListaProductos.Add(producto);
                }
                MessageBox.Show($"Se edito el producto exitosamente");

            }
           
        }

        public void EliminarProducto(int codigo)
        {
            var producto = BuscarProducto(codigo);
            miListaProductos.Remove(producto);

        }

        public List<Producto> FiltrarLista(string descripcion)
        {
            return miListaProductos.FindAll(p => p.Descripcion.ToLower().Contains(descripcion.ToLower()));
        }

    }

}
