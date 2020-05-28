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
            
            //Estructuras selectivas
            int a = 100; 
            int b = 20;
            if(a>b)
            {
                aux = aux + "a mayor que b";
            }
            else
            {
                aux = aux + "b mayor que a";
            }
            this.txtResultado.Text = aux;
            //Llamada de la funcion
            this.getSaludos(saludo);
            this.lblNombre.Text = this.lblNombre.Text + " ---> " + this.getcalculo(a, b).ToString();
        }
        //Procedimientos - Funciones
        //Procedimiento: Funcion que no retorna valor (void)
        //Las Funciones devuelven un valor
        void getSaludos(string nombres)
        {
            this.lblNombre.Text = "Uso de Funcion que no devuelve valor (" + nombres + ")";
        }
        //Funcion que devuelve valor
        double getcalculo(int a, int b)
        {
            double resultado = 0;
            resultado = (a * 10) / (b * 2.5);
            return resultado;
        }
        //Tipos de Datos en C#
        //Operadores Logicos
        // " Relacionales
        // " Aritmeticos
        //Estructuras Repetitivas
    }
}
