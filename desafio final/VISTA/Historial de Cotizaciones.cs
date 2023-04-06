using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desafio_final
{
    public partial class historialCotizaciones : Form
    {
        public historialCotizaciones(List<Cotizacion> historialCotizaciones)
        {
            InitializeComponent();
            lbHistorial.Text = null;
            // Mostrar el historial de cotizaciones en el formulario
            foreach (Cotizacion cotizacion in historialCotizaciones)
            {
                string pren = Convert.ToString(cotizacion.PrendaCotizada1);
                string sub = pren.Substring(21);
                lbHistorial.Text = ($"{lbHistorial.Text}Vendedor #{cotizacion.CodigoVendedor1}                  {cotizacion.FechaHoraCotizacion1}\n\n Prenda:{sub}                   Cantidad Cotizada: {cotizacion.CantidadUnidadesCotizadas1}                   #{cotizacion.NumeroIdentificacion1}\n\nCotizacion: ${cotizacion.ObtenerResultadoCalculoCotizacion()}\n");
                lbHistorial.Text = ($"{lbHistorial.Text}--------------------------------------------------------------------------------------------\n");
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            // Crear un documento imprimible
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;

            // Mostrar un cuadro de diálogo para seleccionar una impresora y configurar las opciones de impresión
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // Imprimir el documento
                printDocument.Print();
            }
        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Obtener el contenido del control lbHistorial
            string text = lbHistorial.Text;

            // Crear una fuente para imprimir el texto
            Font font = new Font("Segoe UI", 10);

            // Imprimir el texto en el documento
            e.Graphics.DrawString(text, font, Brushes.Black, e.MarginBounds);
        }
    }
}
