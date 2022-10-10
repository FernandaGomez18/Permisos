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
    public class AccesoUsuario : IEntidades
    {
        Base b = new Base("localhost", "root", "", "agencia");
        public void Borrar(dynamic Entidad)
        {
            b.Comando(string.Format("call p_eliminarUsuario({0})",
              Entidad.Idusuario));
        }

        public void Guardar(dynamic Entidad)
        {
            b.Comando(string.Format("call p_insertarUsuario(" +
                "'{0}','{1}','{2}','{3}','{4}','{5}')", Entidad.Idusuario, Entidad.Nombre,
                Entidad.Apellidop, Entidad.Apellidom, Entidad.Fechanacimiento, Entidad.Rfc));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener
                (string.Format("select * from usuario",
                filtro), "usuario");
        }
        
    }
}
