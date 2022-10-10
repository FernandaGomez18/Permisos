using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadPermiso;
using AccesoPermiso;
using Crud;
using System.Drawing;

namespace ManejadorPermiso
{
    public class ManejadorHerramienta : IManejador
    {
        AccesoHerramientas ah = new AccesoHerramientas();
        Grafico g = new Grafico();
        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show(
                string.Format("¿Está seguro de borrar '{0}'",
                Entidad.CodigoHerramienta),
                "!Atención", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                ah.Borrar(Entidad);
        }

        public void Guardar(dynamic Entidad)
        {
            ah.Guardar(Entidad);
            g.Mensaje("Herramienta guardado", "¡ATENCIÓN!",
                MessageBoxIcon.Information); throw new NotImplementedException();
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource =
                ah.Mostrar(filtro).Tables["herramienta"];
            tabla.Columns.Insert(5, g.Boton("Editar", Color.Green));
            tabla.Columns.Insert(6, g.Boton("Borrar", Color.Red));
        }
    }
}
