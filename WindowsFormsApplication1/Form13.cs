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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void chbEmpanadas_CheckedChanged(object sender, EventArgs e)
        {

            if (chbEmpanadas.Checked)
            {
                //visible
                pnlEmpanadas.Visible = true;
                //lbl1.Text = "el panel esta visible";
            }
            else
            {
                //ocultamos panel
                pnlEmpanadas.Visible = false;
            }

        }


        private void chbChilenitos_CheckedChanged(object sender, EventArgs e)

        { 
                if (chbChilenitos.Checked)
                {
                    //MessageBox.Show("el control esta seleccionado");
                    //visible
                    pnlChilenitos.Visible = true;
                }
                else
                {
                    //ocultamos panel
                    pnlChilenitos.Visible = false;
                }

            //corregirrrrrrrr
        }

        private void BtnTotal_Click(object sender, EventArgs e)
        {
            string mensaje = "";


            try
            {
                //instanciar la clase en el EVENTO del botoon op. y llamamos lacmetodo CalcularTotal
                Operaciones2 op = new Operaciones2();
                mensaje = op.CalcularTotal(chbEmpanadas.Checked,//aqui los los valores que s eenvina al metodo bool y stirng de el .cs
                                                txtCantidad1.Text,//OJO todo debe estar ordenado 
                                                chbChilenitos.Checked,
                                                txtCantidad2.Text);
                MessageBox.Show(mensaje);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
