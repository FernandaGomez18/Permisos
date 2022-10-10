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
    public partial class FrmUsuarioAdd : Form
    {
        ManejadorUsuario mu;
        public FrmUsuarioAdd()
        {
            InitializeComponent();
            mu = new ManejadorUsuario();
            if(FrmUsuario.usuario.Idusuario >0)
            {
                txtNombre.Text = FrmUsuario.usuario.Nombre;
                txtApellidop.Text = FrmUsuario.usuario.Apellidop;
                txtapellidom.Text = FrmUsuario.usuario.Apellidom;
                dtpFecha.Text = FrmUsuario.usuario.Fechanacimiento;
                txtRfc.Text = FrmUsuario.usuario.Rfc;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            mu.Guardar(new Usuario(FrmUsuario.usuario.Idusuario, txtNombre.Text, txtApellidop.Text,
                txtapellidom.Text, dtpFecha.Text, txtRfc.Text));
        }
    }
}
