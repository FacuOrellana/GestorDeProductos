using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7.Dominio
{
   public class Producto
    {
        private double _margenGanancia;
        private double _precioFinalVenta;
        private bool _precio;

        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public double CostoSinIva { get; set; }
        public double PorcentajeIva { get; set; }

        public double MargenGanancia
        {
            get
            {
                if (_precio)
                {
                    return Math.Round((PrecioFinalVenta - CostoConIva) / CostoConIva, 2);
                }
                else
                {
                    return Math.Round(_margenGanancia, 2);
                }

            }
            set
            {
                _margenGanancia = value;
                _precio = false;
                _precioFinalVenta = 0;
            }
        }

        public double PrecioFinalVenta
        {
            get
            {
                if (!_precio)
                {
                    return Math.Round(CostoConIva + CostoConIva * MargenGanancia, 2);
                }
                else
                {
                    return Math.Round(_precioFinalVenta, 2);
                }
            }

            set
            {
                _precioFinalVenta = value;
                _precio = true;
                _margenGanancia = 0;
            }
        }
        public int Existencia { get; set; }
        public Estado Estado { get; set; }
        public double CostoConIva
        {
            get
            {
                return Math.Round(CostoSinIva + CostoSinIva * PorcentajeIva, 2);
            }
        }
        
        public Producto()
        {
            Codigo = 0;
            Descripcion = "Ingresar un producto";

        }

        

        public Producto(int codigo, string descripcion, double costoSIva, double porcIva, double margenGanancia, int cantidad, Estado estado)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            CostoSinIva = costoSIva;
            PorcentajeIva = porcIva;
            MargenGanancia = margenGanancia;
            Existencia = cantidad;
            Estado = estado;
        }

        public bool Validar()
        {

            if (CostoSinIva <= 0 )
            {
                return false;
            }
            if (PrecioFinalVenta <= 0)
            {
                return false;
            }
            if (PorcentajeIva <= 0)
            {
                return false;
            }
            if (MargenGanancia <= 0)
            {
                return false;
            }
            if (Existencia <= 0)
            {
                return false;
            }

            return true;
        }


    }
}
