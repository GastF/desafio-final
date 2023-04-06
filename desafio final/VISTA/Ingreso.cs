using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desafio_final
{

    public partial class ingresoVendedor : Form
    {
        

        Vendedor empleado = new Vendedor();
        public ingresoVendedor()
        {
            InitializeComponent();
        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {
            empleado.Nombre = nombre.Text;
        }

        private void apellido_TextChanged(object sender, EventArgs e)
        {
            empleado.Apellido = apellido.Text;
        }

        private void codigoVendedor_TextChanged(object sender, EventArgs e)
        {
            empleado.CodigoVendedor = codigoVendedor.Text;
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {

            //Validacion de Datos ingresados
            bool validarNombre = Utiles.ValidarCampo(nombre, "string");
            bool validarApellido = Utiles.ValidarCampo(apellido, "string");
            bool validarCodigo = Utiles.ValidarCampo(codigoVendedor, "string");
            
            if (!validarNombre || !validarApellido || !validarCodigo)
            {
                MessageBox.Show("Alguno de los parametros ingresados es erroneo");
            }
            else
            {
                cotizadorExpress cotizador = new cotizadorExpress(nombre.Text, apellido.Text, codigoVendedor.Text);
                cotizador.Show();
                Hide();
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
