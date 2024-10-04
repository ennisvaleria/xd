using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto1
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtcontraseña.Clear();
            txtApellido.Clear();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre" && txtcontraseña.Text == "Contraseña" && txtApellido.Text == "Apellido")
            {
                FrmMenú frm = new FrmMenú();
                frm.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Credenciales incorrectos");
                txtNombre.Clear();
                txtcontraseña.Clear();
                txtApellido.Clear();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
