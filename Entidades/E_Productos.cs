using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Productos
    {
        public int Codigo_pr { get; set; }
        public string Nombre_pr { get; set; }
        public string Descripcion_pr { get; set; }
        public int Codigo_po { get; set; }
        public int Codigo_me { get; set; }
        public string Abreviatura_me { get; set; }
        public string Descripcion_me { get; set; }
        public decimal PrecioUnitario_pr { get; set; }
        public decimal Stock { get; set; }
        public bool Activo { get; set; }
    }
}
