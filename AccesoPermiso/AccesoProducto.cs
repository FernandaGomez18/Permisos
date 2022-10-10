using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadPermiso;
using ConectarBd;

namespace AccesoPermiso
{

    public class AccesoProducto : IEntidades
    {
        Base b = new Base("localhost", "root", "", "agencia");
        public void Borrar(dynamic Entidad)
        {
            b.Comando(string.Format("call p_eliminarProducto('{0}')",
               Entidad.CodigoBarras));
        }

        public void Guardar(dynamic Entidad)
        {
            b.Comando(string.Format("call p_insertarProducto(" +
               "'{0}','{1}','{2}','{3}')", Entidad.CodigoBarras, Entidad.Nombre,
               Entidad.Descripcion, Entidad.Marca));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener
                (string.Format("select * from producto",
                filtro), "producto");
        }
    }
}
