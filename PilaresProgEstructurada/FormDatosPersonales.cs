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
            // Estructuras secuenciales
            string saludo = ""; //Declarar una cadena
            saludo = this.txtNombres.Text + " " + this.txtApellidos.Text;
            MessageBox.Show("Hola: " + saludo);

            // Estructuras repetitivas
            string aux = "";
            for(int i = 1; i<=10; i++)
            {
                aux = aux + saludo + System.Environment.NewLine;
            }
            this.txtResultado.Text = aux;
        }
    }
}
