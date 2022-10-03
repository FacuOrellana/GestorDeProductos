using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP7;
using TP7.Datos;
using TP7.Dominio;
using TP7.Presentacion.Interfaces;
using TP7.Vistas;
namespace TP7.Presentadores
{
    public class VistaProductoPresentador
    {
        public IVistaProducto _vista;
        public IRepositorio _repositorio;
        VistaListaProductosPresentador _listaPresentador;

        public Array GetEstados()
        {
            var estados = Enum.GetValues(typeof(Estado));
            
            return estados;
        }

        public VistaProductoPresentador(IVistaProducto vista)
        {
            _vista = vista;
            _vista.SetPresentador(this);
        }

        public void Mostrar()
        {
            _vista.Mostrar(false, null);
        }

        public Producto NuevoProducto()
        {
            return new Producto();
        }

        public void SetRepositorio(IRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void SetListaPresentador(VistaListaProductosPresentador presentador)
        {
            _listaPresentador = presentador;
            _vista.Actualizar += _listaPresentador.ActualizarLista;
        }

        public void MostrarProducto(Producto producto)
        {
            _vista.Mostrar(true, producto);
        }

        public void CargarProducto(Producto producto)
        {
            try
            {
                if (!_repositorio.ExisteProducto(producto.Codigo))
                {
                    if (producto.Validar())
                    {
                        _repositorio.AgregarProducto(producto);                        
                    }
                    else
                    {
                        MessageBox.Show("Error, no se pudo agregar el producto, formato invalido", "PAV 2020", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return;

                }
                else
                {
                    _repositorio.ActualizarProducto(producto);
                    _vista.Salir();
                    return;
                }

               

            }
            //catchs
            #region
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }

            #endregion

        }



        public Producto Buscar(int codigo)
        {
            try
            {
                return _repositorio.BuscarProducto(codigo);
            }

            #region Catchs
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            #endregion

        }

    }
}
