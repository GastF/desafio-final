using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_final
{
    public class Cotizacion : Tienda
    {
        private int NumeroIdentificacion;
        private DateTime FechaHoraCotizacion;
        private string CodigoVendedor;
        private Prenda PrendaCotizada;
        private int CantidadUnidadesCotizadas;
        private double ResultadoCalculoCotizacion;

        public int NumeroIdentificacion1 { get => NumeroIdentificacion; set => NumeroIdentificacion = value; }
        public DateTime FechaHoraCotizacion1 { get => FechaHoraCotizacion; set => FechaHoraCotizacion = value; }
        public string CodigoVendedor1 { get => CodigoVendedor; set => CodigoVendedor = value; }
        public Prenda PrendaCotizada1 { get => PrendaCotizada; set => PrendaCotizada = value; }
        public int CantidadUnidadesCotizadas1 { get => CantidadUnidadesCotizadas; set => CantidadUnidadesCotizadas = value; }
        public double ResultadoCalculoCotizacion1 { get => ResultadoCalculoCotizacion; set => ResultadoCalculoCotizacion = value; }

        public Cotizacion(int numeroIdentificacion, DateTime fechaHoraCotizacion, string codigo, Prenda prendaCotizada, int cantidadUnidadesCotizadas)
        {
            NumeroIdentificacion = numeroIdentificacion;
            FechaHoraCotizacion = fechaHoraCotizacion;
            CodigoVendedor = codigo;
            PrendaCotizada = prendaCotizada;
            CantidadUnidadesCotizadas = cantidadUnidadesCotizadas;
        }

        private void CalcularCotizacion()
        {
            double precio = PrendaCotizada.PrecioUnitario;

            // Aplicar reglas de negocio para Tipo de prenda
            if (PrendaCotizada is Camisa camisa)
            {
                if (camisa.TipoManga == TipoManga.Corta)
                {
                    precio *= 0.9;
                }

                if (camisa.TipoCuello == TipoCuello.Mao)
                {
                    precio *= 1.03;
                }
            }
            else if (PrendaCotizada is Pantalon pantalon)
            {
                if (pantalon.TipoPantalon == TipoPantalon.Chupin)
                {
                    precio *= 0.88;
                }
            }

            // Aplicar reglas de negocio para Calidad de prenda
            if (PrendaCotizada.Calidad == CalidadPrenda.Premium)
            {
                precio *= 1.3;
            }

            ResultadoCalculoCotizacion = precio * CantidadUnidadesCotizadas;
        }
        

        public double ObtenerResultadoCalculoCotizacion()
        {
            CalcularCotizacion();
            return ResultadoCalculoCotizacion;
        }

    }
}
