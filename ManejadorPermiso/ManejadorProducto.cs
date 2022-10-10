using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadPermiso;
using AccesoPermiso;
using Crud;
using System.Windows.Forms;

namespace ManejadorPermiso
{
    public class ManejadorProducto : IManejador
    {
        AccesoProducto ap = new AccesoProducto();
        Grafico g = new Grafico();
        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show(
                 string.Format("¿Está seguro de borrar {0}",
                 Entidad.CodigoBarras),
                 "!Atención", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                ap.Borrar(Entidad);
        }

        public void Guardar(dynamic Entidad)
        {
            throw new NotImplementedException();
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            throw new NotImplementedException();
        }
    }
}
