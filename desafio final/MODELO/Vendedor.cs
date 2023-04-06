using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_final
{
    internal class Vendedor
    {
        private string nombre;
        private string apellido;
        private string codigoVendedor;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string CodigoVendedor { get => codigoVendedor; set => codigoVendedor = value; }
    }
}
