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
    public partial class frmBinario : Form
    {
        public frmBinario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            //validar que sea numero y no letras
            //validar que el num ingresado este entre 0 y 255
            if (this.txtNumero.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar un numero Entero...");
                return;
            }
            else
            {
                if(int.TryParse(this.txtNumero.Text, out int numero))
                {
                    if ((int.Parse(this.txtNumero.Text) >= 0) && (int.Parse(this.txtNumero.Text) <= 255))
                    {
                        numero = int.Parse(this.txtNumero.Text);
                        decimalBinario(numero);
                    }
                    else if ((int.Parse(this.txtNumero.Text) < 0) || (int.Parse(this.txtNumero.Text) > 255))
                    {
                        MessageBox.Show("Numero Ingresado Fuera del Rango Permitido");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar un numero Entero...");
                    return;
                } 
            }
            
            //diseñar un formulario nuevo o n el mismo pero ahora debe marcar los checkbox y al hacer click en un boton debe aparecer equivalente en enteros 
            
        }
        void decimalBinario (int num)
        {
            int[] vector = new int[8];
            int residuo = 0, i = 0;
            while(num > 0)
            {
                residuo = num % 2;
                vector[i++] = residuo;
                num = num / 2;
                
            }
            i = 0;
            foreach (int k in vector)
            {
                if (i == 0) this.checkBox8.Checked = k == 1 ? true : false;
                if (i == 1) this.checkBox7.Checked = k == 1 ? true : false;
                if (i == 2) this.checkBox6.Checked = k == 1 ? true : false;
                if (i == 3) this.checkBox5.Checked = k == 1 ? true : false;
                if (i == 4) this.checkBox4.Checked = k == 1 ? true : false;
                if (i == 5) this.checkBox3.Checked = k == 1 ? true : false;
                if (i == 6) this.checkBox2.Checked = k == 1 ? true : false;
                if (i == 7) this.checkBox1.Checked = k == 1 ? true : false;
                i++;
            }
        }

        void binarioDecimal(int num)
        {
            
        }

        private void frmBinario_Load(object sender, EventArgs e)
        {

        }
    }
}
