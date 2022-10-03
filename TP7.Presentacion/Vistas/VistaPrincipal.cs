using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP7.Presentacion.Interfaces;
using TP7.Presentadores;

namespace TP7.Vistas
{
    public partial class VistaPrincipal : Form, IVistaPrincipal
    {
        
        public readonly VistaPrincipalPresentador _presentador;

        public VistaPrincipal(VistaPrincipalPresentador presentador)
        {
            InitializeComponent();
            _presentador = presentador;
            _presentador.SetVistaPrincipal(this);
        }

       

        private void tsmProductos_Click(object sender, EventArgs e)
        {
            _presentador.IniciarVista();
        }

        
    }
}
