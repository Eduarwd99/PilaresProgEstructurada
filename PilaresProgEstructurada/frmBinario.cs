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

        private void frmBinario_Load(object sender, EventArgs e)
        {

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
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

        void binarioDecimal(int num128, int num64, int num32, int num16, int num8, int num4, int num2, int num1)
        {
            int num_Trans = 0, n1, n2, n3, n4, n5, n6, n7, n8;
            n1 = (num128 * Convert.ToInt32(Math.Pow(2, 7)));
            n2 = (num64 * Convert.ToInt32(Math.Pow(2, 6)));
            n3 = (num32 * Convert.ToInt32(Math.Pow(2, 5)));
            n4 = (num16 * Convert.ToInt32(Math.Pow(2, 4)));
            n5 = (num8 * Convert.ToInt32(Math.Pow(2, 3)));
            n6 = (num4 * Convert.ToInt32(Math.Pow(2, 2)));
            n7 = (num2 * Convert.ToInt32(Math.Pow(2, 1)));
            n8 = (num1 * Convert.ToInt32(Math.Pow(2, 0)));
            num_Trans = n1 + n2 + n3 + n4 + n5 + n6 + n7 + n8;
            this.txtDecimal.Text = Convert.ToString(num_Trans);
        }

        private void checkBox9_Click(object sender, EventArgs e)
        {
            //Binario 128
            int on_off128 = 0, on_off64 = 0, on_off32 = 0, on_off16 = 0, on_off8 = 0, on_off4 = 0, on_off2 = 0, on_off1 = 0;
            
            if (this.checkBox9.Checked == true) on_off128 = 1;
            else on_off128 = 0;

            if (this.checkBox10.Checked == true) on_off64 = 1;
            else on_off64 = 0;

            if (this.checkBox11.Checked == true) on_off32 = 1;
            else on_off32 = 0;

            if (this.checkBox12.Checked == true) on_off16 = 1;
            else on_off16 = 0;

            if (this.checkBox13.Checked == true) on_off8 = 1;
            else on_off8 = 0;

            if (this.checkBox14.Checked == true) on_off4 = 1;
            else on_off4 = 0;

            if (this.checkBox15.Checked == true) on_off2 = 1;
            else on_off2 = 0;

            if (this.checkBox16.Checked == true) on_off1 = 1;
            else on_off1 = 0;

            binarioDecimal(on_off128, on_off64, on_off32, on_off16, on_off8, on_off4, on_off2, on_off1);
        }

        private void checkBox10_Click(object sender, EventArgs e)
        {
            //Binario 64
            int on_off128 = 0, on_off64 = 0, on_off32 = 0, on_off16 = 0, on_off8 = 0, on_off4 = 0, on_off2 = 0, on_off1 = 0;

            if (this.checkBox9.Checked == true) on_off128 = 1;
            else on_off128 = 0;

            if (this.checkBox10.Checked == true) on_off64 = 1;
            else on_off64 = 0;

            if (this.checkBox11.Checked == true) on_off32 = 1;
            else on_off32 = 0;

            if (this.checkBox12.Checked == true) on_off16 = 1;
            else on_off16 = 0;

            if (this.checkBox13.Checked == true) on_off8 = 1;
            else on_off8 = 0;

            if (this.checkBox14.Checked == true) on_off4 = 1;
            else on_off4 = 0;

            if (this.checkBox15.Checked == true) on_off2 = 1;
            else on_off2 = 0;

            if (this.checkBox16.Checked == true) on_off1 = 1;
            else on_off1 = 0;

            binarioDecimal(on_off128, on_off64, on_off32, on_off16, on_off8, on_off4, on_off2, on_off1);
        }

        private void checkBox11_Click(object sender, EventArgs e)
        {
            //Binario 32
            int on_off128 = 0, on_off64 = 0, on_off32 = 0, on_off16 = 0, on_off8 = 0, on_off4 = 0, on_off2 = 0, on_off1 = 0;

            if (this.checkBox9.Checked == true) on_off128 = 1;
            else on_off128 = 0;

            if (this.checkBox10.Checked == true) on_off64 = 1;
            else on_off64 = 0;

            if (this.checkBox11.Checked == true) on_off32 = 1;
            else on_off32 = 0;

            if (this.checkBox12.Checked == true) on_off16 = 1;
            else on_off16 = 0;

            if (this.checkBox13.Checked == true) on_off8 = 1;
            else on_off8 = 0;

            if (this.checkBox14.Checked == true) on_off4 = 1;
            else on_off4 = 0;

            if (this.checkBox15.Checked == true) on_off2 = 1;
            else on_off2 = 0;

            if (this.checkBox16.Checked == true) on_off1 = 1;
            else on_off1 = 0;

            binarioDecimal(on_off128, on_off64, on_off32, on_off16, on_off8, on_off4, on_off2, on_off1);
        }

        private void checkBox12_Click(object sender, EventArgs e)
        {
            //Binario 16
            int on_off128 = 0, on_off64 = 0, on_off32 = 0, on_off16 = 0, on_off8 = 0, on_off4 = 0, on_off2 = 0, on_off1 = 0;

            if (this.checkBox9.Checked == true) on_off128 = 1;
            else on_off128 = 0;

            if (this.checkBox10.Checked == true) on_off64 = 1;
            else on_off64 = 0;

            if (this.checkBox11.Checked == true) on_off32 = 1;
            else on_off32 = 0;

            if (this.checkBox12.Checked == true) on_off16 = 1;
            else on_off16 = 0;

            if (this.checkBox13.Checked == true) on_off8 = 1;
            else on_off8 = 0;

            if (this.checkBox14.Checked == true) on_off4 = 1;
            else on_off4 = 0;

            if (this.checkBox15.Checked == true) on_off2 = 1;
            else on_off2 = 0;

            if (this.checkBox16.Checked == true) on_off1 = 1;
            else on_off1 = 0;

            binarioDecimal(on_off128, on_off64, on_off32, on_off16, on_off8, on_off4, on_off2, on_off1);
        }

        private void checkBox13_Click(object sender, EventArgs e)
        {
            //Binario 8
            int on_off128 = 0, on_off64 = 0, on_off32 = 0, on_off16 = 0, on_off8 = 0, on_off4 = 0, on_off2 = 0, on_off1 = 0;

            if (this.checkBox9.Checked == true) on_off128 = 1;
            else on_off128 = 0;

            if (this.checkBox10.Checked == true) on_off64 = 1;
            else on_off64 = 0;

            if (this.checkBox11.Checked == true) on_off32 = 1;
            else on_off32 = 0;

            if (this.checkBox12.Checked == true) on_off16 = 1;
            else on_off16 = 0;

            if (this.checkBox13.Checked == true) on_off8 = 1;
            else on_off8 = 0;

            if (this.checkBox14.Checked == true) on_off4 = 1;
            else on_off4 = 0;

            if (this.checkBox15.Checked == true) on_off2 = 1;
            else on_off2 = 0;

            if (this.checkBox16.Checked == true) on_off1 = 1;
            else on_off1 = 0;

            binarioDecimal(on_off128, on_off64, on_off32, on_off16, on_off8, on_off4, on_off2, on_off1);
        }

        private void checkBox14_Click(object sender, EventArgs e)
        {
            //Binario 4
            int on_off128 = 0, on_off64 = 0, on_off32 = 0, on_off16 = 0, on_off8 = 0, on_off4 = 0, on_off2 = 0, on_off1 = 0;

            if (this.checkBox9.Checked == true) on_off128 = 1;
            else on_off128 = 0;

            if (this.checkBox10.Checked == true) on_off64 = 1;
            else on_off64 = 0;

            if (this.checkBox11.Checked == true) on_off32 = 1;
            else on_off32 = 0;

            if (this.checkBox12.Checked == true) on_off16 = 1;
            else on_off16 = 0;

            if (this.checkBox13.Checked == true) on_off8 = 1;
            else on_off8 = 0;

            if (this.checkBox14.Checked == true) on_off4 = 1;
            else on_off4 = 0;

            if (this.checkBox15.Checked == true) on_off2 = 1;
            else on_off2 = 0;

            if (this.checkBox16.Checked == true) on_off1 = 1;
            else on_off1 = 0;

            binarioDecimal(on_off128, on_off64, on_off32, on_off16, on_off8, on_off4, on_off2, on_off1);
        }

        private void checkBox15_Click(object sender, EventArgs e)
        {
            //Binario 2
            int on_off128 = 0, on_off64 = 0, on_off32 = 0, on_off16 = 0, on_off8 = 0, on_off4 = 0, on_off2 = 0, on_off1 = 0;

            if (this.checkBox9.Checked == true) on_off128 = 1;
            else on_off128 = 0;

            if (this.checkBox10.Checked == true) on_off64 = 1;
            else on_off64 = 0;

            if (this.checkBox11.Checked == true) on_off32 = 1;
            else on_off32 = 0;

            if (this.checkBox12.Checked == true) on_off16 = 1;
            else on_off16 = 0;

            if (this.checkBox13.Checked == true) on_off8 = 1;
            else on_off8 = 0;

            if (this.checkBox14.Checked == true) on_off4 = 1;
            else on_off4 = 0;

            if (this.checkBox15.Checked == true) on_off2 = 1;
            else on_off2 = 0;

            if (this.checkBox16.Checked == true) on_off1 = 1;
            else on_off1 = 0;

            binarioDecimal(on_off128, on_off64, on_off32, on_off16, on_off8, on_off4, on_off2, on_off1);
        }

        private void checkBox16_Click(object sender, EventArgs e)
        {
            //Binario 1
            int on_off128 = 0, on_off64 = 0, on_off32 = 0, on_off16 = 0, on_off8 = 0, on_off4 = 0, on_off2 = 0, on_off1 = 0;

            if (this.checkBox9.Checked == true) on_off128 = 1;
            else on_off128 = 0;

            if (this.checkBox10.Checked == true) on_off64 = 1;
            else on_off64 = 0;

            if (this.checkBox11.Checked == true) on_off32 = 1;
            else on_off32 = 0;

            if (this.checkBox12.Checked == true) on_off16 = 1;
            else on_off16 = 0;

            if (this.checkBox13.Checked == true) on_off8 = 1;
            else on_off8 = 0;

            if (this.checkBox14.Checked == true) on_off4 = 1;
            else on_off4 = 0;

            if (this.checkBox15.Checked == true) on_off2 = 1;
            else on_off2 = 0;

            if (this.checkBox16.Checked == true) on_off1 = 1;
            else on_off1 = 0;

            binarioDecimal(on_off128, on_off64, on_off32, on_off16, on_off8, on_off4, on_off2, on_off1);
        }
    }
}
