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
    public class ManejadorRegistro : IManejador
    {
        AccesoRegistro ar = new AccesoRegistro();
        Grafico g = new Grafico();
        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show(
                string.Format("¿Está seguro de borrar {0}",
                Entidad.Idusuario),
                "!Atención", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                ar.Borrar(Entidad);
        }

        public void Guardar(dynamic Entidad)
        {
            ar.Guardar(Entidad);
            g.Mensaje("Registro guardado", "¡ATENCIÓN!",
                MessageBoxIcon.Information);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = ar.Mostrar(filtro).Tables["registro"];
            tabla.Columns.Insert(2, g.Boton("Editar", Color.Green));
            tabla.Columns.Insert(3, g.Boton("Borrar", Color.Red));
        }
        public Tuple<bool, string> ValidarRegistro(Registro registro)
        {
            bool error = true;
            string cadenaErrores = "";

            if (registro.Nombre.Length == 0 || registro.Nombre == null)
            {
                cadenaErrores = cadenaErrores + "El campo Nombre no puede ser vacio\n";
                error = false;
            }
            if (registro.Contraseña.Length == 0 || registro.Contraseña == null)
            {
                cadenaErrores = cadenaErrores + "El campo Contraseña es incorrecto\n";
                error = false;
            }
            var valida = new Tuple<bool, string>(error, cadenaErrores);
            return valida;
        }
    }
}
