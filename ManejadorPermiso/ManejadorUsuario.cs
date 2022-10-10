using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoPermiso;
using EntidadPermiso;
using Crud;
using System.Windows.Forms;
using System.Drawing;

namespace ManejadorPermiso
{
    public class ManejadorUsuario : IManejador
    {
        AccesoUsuario au = new AccesoUsuario();
        Grafico g = new Grafico();
        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show(
                string.Format("¿Está seguro de borrar {0}",
                Entidad.Idusuario),
                "!Atención", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                au.Borrar(Entidad);
        }

        public void Guardar(dynamic Entidad)
        {
            au.Guardar(Entidad);
            g.Mensaje("Usuario guardado", "¡ATENCIÓN!",
                MessageBoxIcon.Information);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = au.Mostrar(filtro).Tables["usuario"];
            tabla.Columns.Insert(6, g.Boton("Editar", Color.Green));
            tabla.Columns.Insert(7, g.Boton("Borrar", Color.Red));

        }
    }
}
