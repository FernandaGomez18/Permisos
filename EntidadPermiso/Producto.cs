using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadPermiso
{
    public class Producto
    {
        public Producto(string cogigo, string nombre, string descripcion, string marca)
        {
            CogigoBarras = cogigo;
            Nombre = nombre;
            Descripcion = descripcion;
            Marca = marca;
        }

        public string CogigoBarras { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
    }
}
