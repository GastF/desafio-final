using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_final
{
    public class Tienda
    {
        public enum CalidadPrenda { Standard, Premium }
        public enum TipoManga { Corta, Larga }
        public enum TipoCuello { Mao, Comun }
        public enum TipoPantalon { Comun, Chupin }

        public class Prenda
        {
            public CalidadPrenda Calidad { get; set; }
            public double PrecioUnitario { get; set; }
            public int CantidadStock { get; set; }
        }

        public class Camisa : Prenda
        {
            public TipoManga TipoManga { get; set; }
            public TipoCuello TipoCuello { get; set; }

        }

        public class Pantalon : Prenda
        {
            public TipoPantalon TipoPantalon { get; set; }
        }
        #region LISTA DE PRENDAS
        public List<Prenda> Prendas { get; set; }
        public Tienda()
        {
            Prendas = new List<Prenda>();

        //CAMISAS

            // Agregar camisas de manga corta con cuello mao
            Prendas.Add(new Camisa { TipoManga = TipoManga.Corta, TipoCuello = TipoCuello.Mao, Calidad = CalidadPrenda.Standard, CantidadStock = 100 });
            Prendas.Add(new Camisa { TipoManga = TipoManga.Corta, TipoCuello = TipoCuello.Mao, Calidad = CalidadPrenda.Premium, CantidadStock = 100 });

            // Agregar camisas de manga corta con cuello comun
            Prendas.Add(new Camisa { TipoManga = TipoManga.Corta, TipoCuello = TipoCuello.Comun, Calidad = CalidadPrenda.Standard, CantidadStock = 150 });
            Prendas.Add(new Camisa { TipoManga = TipoManga.Corta, TipoCuello = TipoCuello.Comun, Calidad = CalidadPrenda.Premium, CantidadStock = 150 });

            // Agregar camisas de manga larga con cuello mao
            Prendas.Add(new Camisa { TipoManga = TipoManga.Larga, TipoCuello = TipoCuello.Mao, Calidad = CalidadPrenda.Standard, CantidadStock = 75 });
            Prendas.Add(new Camisa { TipoManga = TipoManga.Larga, TipoCuello = TipoCuello.Mao, Calidad = CalidadPrenda.Premium, CantidadStock = 75 });

            // Agregar camisas de manga larga con cuello comun
            Prendas.Add(new Camisa { TipoManga = TipoManga.Larga, TipoCuello = TipoCuello.Comun, Calidad = CalidadPrenda.Standard, CantidadStock = 175 });
            Prendas.Add(new Camisa { TipoManga = TipoManga.Larga, TipoCuello = TipoCuello.Comun, Calidad = CalidadPrenda.Premium, CantidadStock = 175 });

        //PANTALONES

            // Agregar pantalones chupines
            Prendas.Add(new Pantalon { TipoPantalon = TipoPantalon.Chupin, Calidad = CalidadPrenda.Standard, CantidadStock = 750 });
            Prendas.Add(new Pantalon { TipoPantalon = TipoPantalon.Chupin, Calidad = CalidadPrenda.Premium, CantidadStock = 750 });

            // Agregar pantalones comunes
            Prendas.Add(new Pantalon { TipoPantalon = TipoPantalon.Comun, Calidad = CalidadPrenda.Standard, CantidadStock = 250 });
            Prendas.Add(new Pantalon { TipoPantalon = TipoPantalon.Comun, Calidad = CalidadPrenda.Premium, CantidadStock = 250 });
        }
        public int ObtenerStock(Prenda prenda)
        {
            // Buscar en la lista de prendas la prenda que coincida con la prenda dada
            Prenda prendaEncontrada = null;
            foreach (Prenda p in Prendas)
            {
                if (PrendasCoinciden(p, prenda))
                {
                    prendaEncontrada = p;
                    break;
                }
            }

            if (prendaEncontrada != null)
            {
                // Si se encontró una prenda que coincida, devolver su cantidad de stock
                return prendaEncontrada.CantidadStock;
            }
            else
            {
                // Si no se encontró una prenda que coincida, devolver 0
                return 0;
            }
        }
        public void ActualizarStock(Prenda prenda, int cantidadVendida)
        {
            // Buscar en la lista de prendas la prenda que coincida con la prenda dada
            Prenda prendaEncontrada = null;
            foreach (Prenda p in Prendas)
            {
                if (PrendasCoinciden(p, prenda))
                {
                    prendaEncontrada = p;
                    break;
                }
            }

            if (prendaEncontrada != null)
            {
                // Si se encontró una prenda que coincida, actualizar su cantidad de stock
                prendaEncontrada.CantidadStock -= cantidadVendida;
            }
        }

        private bool PrendasCoinciden(Prenda p1, Prenda p2)
        {
            if (p1 is Camisa camisa1 && p2 is Camisa camisa2)
            {
                return camisa1.TipoManga == camisa2.TipoManga &&
                       camisa1.TipoCuello == camisa2.TipoCuello &&
                       camisa1.Calidad == camisa2.Calidad;
            }
            else if (p1 is Pantalon pantalon1 && p2 is Pantalon pantalon2)
            {
                return pantalon1.TipoPantalon == pantalon2.TipoPantalon &&
                       pantalon1.Calidad == pantalon2.Calidad;
            }

            return false;
        }
        #endregion
    }
}
