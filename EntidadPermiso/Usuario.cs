using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadPermiso
{
    public class Usuario
    {
        public Usuario(int idusuario, string nombre, string apellidop, string apellidom, string fechanacimiento, string rfc)
        {
            Idusuario = idusuario;
            Nombre = nombre;
            Apellidop = apellidop;
            Apellidom = apellidom;
            Fechanacimiento = fechanacimiento;
            Rfc = rfc;
        }

        public int Idusuario { get; set; }
        public string Nombre { get; set; }
        public string Apellidop { get; set; }
        public string Apellidom { get; set; }
        public string Fechanacimiento { get; set; }
        public string Rfc { get; set; }
    }
}
