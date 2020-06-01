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
    public partial class FrmListas : Form
    {
        public FrmListas()
        {
            InitializeComponent();
        }

        private void lstNombres_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(this.txtNombre.Text=="")
            {

            }
            else
            {
                this.lstNombres.Items.Add(this.txtNombre.Text);
                this.txtNombre.Text = "";
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                if (this.txtNombre.Text == "")
                {

                }
                else
                {
                    this.lstNombres.Items.Add(this.txtNombre.Text);
                    this.txtNombre.Text = "";
                }
            }
        }
    }
}
