using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLQueries.Models
{
    public class Productos
    {
        public int ID { get; set; }
        public int Producto { get; set; }
        public float Precio { get; set; }
        public int Unidades { get; set; }
        public string CantidadUnidad { get; set; }
        public string Categoria { get; set; }
        public string Proveedor { get; set; }
        public int UnidadesOrdenadas { get; set; }
        public int NivelOrdenes { get; set; }
        public bool Estado { get; set; }

    }
}
