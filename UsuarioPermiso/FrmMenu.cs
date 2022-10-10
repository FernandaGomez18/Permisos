using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsuarioPermiso
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void txtUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuario fu = new FrmUsuario();
            fu.ShowDialog();
        }

        private void txtProductos_Click(object sender, EventArgs e)
        {
            FrmProducto fp = new FrmProducto();
            fp.ShowDialog();
        }

        private void txtHerramientas_Click(object sender, EventArgs e)
        {
            FrmHerramienta fh = new FrmHerramienta();
            fh.ShowDialog();
        }
    }
}
