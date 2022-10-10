using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadPermiso;
using ManejadorPermiso;
namespace UsuarioPermiso
{
    public partial class FrmRegistro : Form
    {
        ManejadorRegistro mu;
        public FrmRegistro()
        {
            InitializeComponent();
            mu = new ManejadorRegistro();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            GuardarUsuario();
        }
        private void GuardarUsuario()
        {
            Registro registro = new Registro( txtNombre.Text, txtContraseña.Text);

            var valida = mu.ValidarRegistro(registro);

            if (valida.Item1)
            {
                mu.Guardar(new Registro( txtNombre.Text, txtContraseña.Text));
                Close();
            }
            else
            {
                MessageBox.Show(valida.Item2, "OCURRIO UN ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
