using System;
using System.Windows.Forms;
using TP7.Datos;
using TP7.Dominio;
using TP7.Presentadores;
using TP7.Presentacion;
using TP7.Presentacion.Interfaces;

namespace TP7
{
    public partial class VistaProducto : Form, IVistaProducto
    {
        const string message = "No se encontro el producto ¿Desea cargar un nuevo producto?";
        const string caption = "Se cierra la ventana";
        private VistaProductoPresentador _presentador;

        public event Action Actualizar;

        public VistaProducto()
        {
            InitializeComponent();         
        }


        private void VistaProducto_Load(object sender, EventArgs e)
        {
            botonBuscar.Enabled = false;
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            bsProducto.DataSource = _presentador.NuevoProducto();
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            GuardarOModificar();
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            bsProducto.DataSource = Buscar();
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }

        public void Salir()
        {           
            Visible = false;            
        }

        public void Mostrar(bool editar, Producto producto = null)
        {
            if (editar == true)
            {                
                botonGuardar.Text = "EDITAR";
                comboEstado.Enabled = true;
                bsProducto.DataSource = producto;
                Show();
                return;
            }
            comboEstado.Enabled = false;
            bsProducto.DataSource = _presentador.NuevoProducto();
            Show();
        }



        public void Limpiar()
        {
            bsProducto.DataSource = new Producto();
        }

        public void GuardarOModificar()
        {
            var producto = new Producto();
            producto = bsProducto.DataSource as Producto;
            comboEstado.Enabled = false;
            botonGuardar.Text = "GUARDAR";
            _presentador.CargarProducto(producto);
            Actualizar();
            Salir();
        }

        public Producto Buscar()
        {
            return _presentador.Buscar(int.Parse(txtCodigo.Text));
        }

        public void SetPresentador(VistaProductoPresentador presentador)
        {
            _presentador = presentador;
            comboEstado.DataSource = _presentador.GetEstados();
        }

        
    }


}

