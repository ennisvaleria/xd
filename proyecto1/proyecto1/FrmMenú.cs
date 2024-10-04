using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto1
{
    public partial class FrmMenú : Form
    {
        public FrmMenú()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmMenú_Load(object sender, EventArgs e)
        {

        }

        private void labelApellido_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNombre1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            FrmAlumnos frm = new FrmAlumnos();  
            frm.ShowDialog();
        }

        private void btnNotas_Click(object sender, EventArgs e)
        {
            FrmNotas frm = new FrmNotas();
            frm.ShowDialog();
        }

        private void btnHorario_Click(object sender, EventArgs e)
        {
            FrmHorario frm = new FrmHorario();
            frm.ShowDialog();
        }
    }
}
