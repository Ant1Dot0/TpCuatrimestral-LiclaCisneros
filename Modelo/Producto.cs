using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    class Producto
    {
        public int id { get; set; }
        public string codigo { get; set; }
        public string descripcion { get; set; }
        public decimal ganancia { get; set; }
        public decimal cantidad { get; set; }
        public decimal precioCompra { get; set; }
        public decimal stockMinimo { get; set; }
        public decimal stock { get; set; }
        public Tipo tipo { get; set; }
        public Categoria categoria { get; set; }
        public Marca marca { get; set; }
    }
}
