using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void chbox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                if (chbox1.Checked)
                {
                    MessageBox.Show("el control esta seleccionado");
                    //visible
                    pnlPanel.Visible = true;
                    lbl1.Text = "el panel esta visible";
                }
                else
                {
                    MessageBox.Show("el control checkbox NO esta seleccionado");

                    //ocultamos panel
                    pnlPanel.Visible = false;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
