using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManejadorPermiso;
using EntidadPermiso;
namespace UsuarioPermiso
{
    public partial class FrmUsuario : Form
    {
        ManejadorUsuario mp;
        public static Usuario usuario = new Usuario(0, "", "","","","");
        int columna = 0, fila = 0;
        public FrmUsuario()
        {
            InitializeComponent();
            mp = new ManejadorUsuario();
        }

        private void dtgUsuarios_Enter(object sender, EventArgs e)
        {

        }
        void Actualizar()
        {
            mp.Mostrar(dtgUsuarios, txtBuscar.Text);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgUsuarios_Click(object sender, EventArgs e)
        {
            usuario.Idusuario = int.Parse(dtgUsuarios.Rows[fila].Cells[0].Value.ToString());
            usuario.Nombre = dtgUsuarios.Rows[fila].Cells[1].Value.ToString();
            usuario.Apellidop = dtgUsuarios.Rows[fila].Cells[2].Value.ToString();
            usuario.Apellidom = dtgUsuarios.Rows[fila].Cells[3].Value.ToString();
            usuario.Fechanacimiento = dtgUsuarios.Rows[fila].Cells[4].Value.ToString();
            usuario.Rfc = dtgUsuarios.Rows[fila].Cells[5].Value.ToString();
            switch (columna)
            {
                case 3:
                    {
                        FrmUsuarioAdd fp = new FrmUsuarioAdd();
                        fp.ShowDialog();
                        txtBuscar.Text = "-1";
                        txtBuscar.Clear();
                        Actualizar();
                    }
                    break;
                case 4:
                    {
                        mp.Borrar(usuario);
                        txtBuscar.Text = "";
                        Actualizar();

                    }
                    break;
            }
        }
    }
}
