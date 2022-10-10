using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadPermiso;
using ConectarBd;
using System.Data;

namespace AccesoPermiso
{
    public class AccesoRegistro : IEntidades
    {

        Base b = new Base("localhost", "root", "", "agencia");
        public void Borrar(dynamic Entidad)
        {
            b.Comando(string.Format("call p_eliminarRegistro('{0}')",
               Entidad.Nombre));
        }

        public void Guardar(dynamic Entidad)
        {
            b.Comando(string.Format("call p_insertarRegistro(" +
                "'{0}','{1}')", Entidad.Nombre, Entidad.Contraseña));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener
                 (string.Format("select * from registro",
                 filtro), "registro");
        }
    }
}
