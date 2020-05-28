using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilaresProgEstructurada
{
    public partial class FormDatosPersonales : Form
    {
        public FormDatosPersonales()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola: " + this.txtApellidos.Text + " " + this.txtNombres.Text);
        }
    }
}
