using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static desafio_final.Tienda;

namespace desafio_final
{
    public partial class cotizadorExpress : Form 
    {
        private Tienda tienda;
        private List<Cotizacion> historialCotizaciones;
        private string codigo;
        private int cotizacionID;
     
        public cotizadorExpress(string nombre, string apellido, string codigoVendedor)
        {
            InitializeComponent();
            
            nombreApellido.Text = ($"{nombre} {apellido} | #{codigoVendedor}");
            codigo = codigoVendedor;
            tienda = new Tienda();
            historialCotizaciones = new List<Cotizacion>();
     
        }

        private void btnCamisa_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarStock();
            if (btnCamisa.Checked)
            {
                checkCmao.Enabled = true;
                checkMcorta.Enabled = true;
                checkChupin.Checked = false;
                checkChupin.Enabled = false;
            }
        }
        private void btnPantalon_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarStock();
            if (btnPantalon.Checked)
            {
                
                checkChupin.Enabled = true;
                checkCmao.Enabled = false;
                checkMcorta.Enabled = false;
                checkCmao.Checked = false;
                checkMcorta.Checked = false;
              
            }

        }
        private Prenda ObtenerPrendaSeleccionada()
        {
            Prenda prendaSeleccionada = null;
            #region standart
            if (btnCamisa.Checked && btnStandart.Checked)
            {
                
                if (checkCmao.Checked)
                {
                    // Devolver una camisa mangas larga con cuello mao
                    prendaSeleccionada = new Camisa { TipoManga = TipoManga.Larga, TipoCuello = TipoCuello.Mao, Calidad = CalidadPrenda.Standard };
                }
                else
                {
                    // Devolver una camisa mangas larga  con cuello normal
                    prendaSeleccionada = new Camisa { TipoManga = TipoManga.Larga, TipoCuello = TipoCuello.Comun, Calidad = CalidadPrenda.Standard };
                }
                if (checkCmao.Checked && checkMcorta.Checked)
                {
                    // Devolver una camisa mangas corta con cuello mao
                    prendaSeleccionada = new Camisa { TipoManga = TipoManga.Corta, TipoCuello = TipoCuello.Mao, Calidad = CalidadPrenda.Standard };
                }
                else if (checkMcorta.Checked)
                {
                    // Devolver una camisa mangas corta  con cuello normal
                    prendaSeleccionada = new Camisa { TipoManga = TipoManga.Corta, TipoCuello = TipoCuello.Comun, Calidad = CalidadPrenda.Standard };
                }
                
            }   
            else if (btnPantalon.Checked && btnStandart.Checked)
             {
                    if (checkChupin.Checked)
                    {
                        // Devolver un pantalón chupín
                        prendaSeleccionada = new Pantalon { TipoPantalon = TipoPantalon.Chupin, Calidad = CalidadPrenda.Standard };
                    }
                    else
                    {
                        // Devolver un pantalón comun
                        prendaSeleccionada = new Pantalon { TipoPantalon = TipoPantalon.Comun, Calidad = CalidadPrenda.Standard };
                    }
            }
            #endregion
            #region premium
            if (btnCamisa.Checked && btnPremium.Checked)
            {

                if (checkCmao.Checked)
                {
                    // Devolver una camisa mangas larga con cuello mao
                    prendaSeleccionada = new Camisa { TipoManga = TipoManga.Larga, TipoCuello = TipoCuello.Mao, Calidad = CalidadPrenda.Premium };
                }
                else
                {
                    // Devolver una camisa mangas larga  con cuello normal
                    prendaSeleccionada = new Camisa { TipoManga = TipoManga.Larga, TipoCuello = TipoCuello.Comun, Calidad = CalidadPrenda.Premium };
                }
                if (checkCmao.Checked && checkMcorta.Checked)
                {
                    // Devolver una camisa mangas corta con cuello mao
                    prendaSeleccionada = new Camisa { TipoManga = TipoManga.Corta, TipoCuello = TipoCuello.Mao, Calidad = CalidadPrenda.Premium };
                }
                else if (checkMcorta.Checked)
                {
                    // Devolver una camisa mangas corta  con cuello normal
                    prendaSeleccionada = new Camisa { TipoManga = TipoManga.Corta, TipoCuello = TipoCuello.Comun, Calidad = CalidadPrenda.Premium };
                }

            }
            else if (btnPantalon.Checked && btnPremium.Checked)
            {
                if (checkChupin.Checked)
                {
                    // Devolver un pantalón chupín
                    prendaSeleccionada = new Pantalon { TipoPantalon = TipoPantalon.Chupin, Calidad = CalidadPrenda.Premium };
                }
                else
                {
                    // Devolver un pantalón comun
                    prendaSeleccionada = new Pantalon { TipoPantalon = TipoPantalon.Comun, Calidad = CalidadPrenda.Premium };
                }
            }
            #endregion
            return prendaSeleccionada;
        }

        #region Actualizar Stock
        private void ActualizarStock()
        {
            // Obtener la prenda seleccionada
            Prenda prendaSeleccionada = ObtenerPrendaSeleccionada();

            // Obtener la cantidad de stock disponible para la prenda seleccionada
            int stockDisponible = tienda.ObtenerStock(prendaSeleccionada);

            // Actualizar el texto del label con la cantidad de stock disponible
            txtStock.Text = ($"{stockDisponible}");
        }

        private void checkCmao_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarStock();
        }

        private void checkMcorta_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarStock();
        }

        private void checkChupin_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarStock();
        }

        private void btnStandart_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarStock();
        }

        private void btnPremium_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarStock();
        }
        #endregion
        private void btnCotizar_Click(object sender, EventArgs e) 
        {
            Prenda prendaSeleccionada = ObtenerPrendaSeleccionada();

            if (prendaSeleccionada == null)
            {
                MessageBox.Show("Debe seleccionar una prenda antes de cotizar.");

            }
            else
            {
                //Validacion de Datos ingresados
                bool validarPrecioUnitario = Utiles.ValidarCampo(txtPrecioUnitario, "double");
                bool validarCantidad = Utiles.ValidarCampo(txtCantidad, "int");


                if (!validarPrecioUnitario || !validarCantidad)
                {
                    MessageBox.Show("Alguno de los parametros ingresados es erroneo");

                }

                else
                {
                    
                    int cantidadVendida = Convert.ToInt32(txtCantidad.Text);

                    // Verificar si hay suficiente stock disponible
                    int stockDisponible = tienda.ObtenerStock(prendaSeleccionada);
                    if (cantidadVendida > stockDisponible)
                    {
                        // Si no hay suficiente stock disponible, mostrar un mensaje de error
                        MessageBox.Show("No se puede realizar una cotización sobre una cantidad de stock no disponible.");

                    }
                    else if (cantidadVendida <= 0)
                    {
                        // Si no hay suficiente stock disponible, mostrar un mensaje de error
                        MessageBox.Show("No se pude realizar una cotizacion de 0 productos. Ingrese una cantidad de stock mayor a 0.");

                    }
                    else {
                        prendaSeleccionada.PrecioUnitario = Convert.ToDouble(txtPrecioUnitario.Text);
                        cotizacionID++;
                        Cotizacion cotizacion = new Cotizacion(cotizacionID, DateTime.Now, codigo, prendaSeleccionada, cantidadVendida);

                        double resultado = cotizacion.ObtenerResultadoCalculoCotizacion();
                        resultadoCotizacion.Text = resultado.ToString("C");
                        tienda.ActualizarStock(prendaSeleccionada, cantidadVendida);
                        historialCotizaciones.Add(cotizacion);
                        ActualizarStock();
                    }


                    
                }
            }
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            Form historial = new historialCotizaciones(historialCotizaciones);
            historial.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }

}
