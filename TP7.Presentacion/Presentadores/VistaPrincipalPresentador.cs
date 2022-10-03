using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP7.Vistas;
using TP7.Presentacion.Interfaces;

namespace TP7.Presentadores
{
    public class VistaPrincipalPresentador
    {
        public IVistaPrincipal _vistaPrincipal;       
        public VistaListaProductosPresentador _listapresentador;


        public VistaPrincipalPresentador(VistaListaProductosPresentador presentador)
        {
            _listapresentador = presentador;            

        }

        public void SetVistaPrincipal(IVistaPrincipal vista)
        {
            _vistaPrincipal = vista;
        }

        public void IniciarVista()
        {
            _listapresentador.Iniciar(_vistaPrincipal);
           
        }

    }
}
