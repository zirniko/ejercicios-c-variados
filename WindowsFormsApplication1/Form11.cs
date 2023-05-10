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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void BtnSueldoLiquido_Click(object sender, EventArgs e)
        {
            #region declaracion de variables
            decimal SueldoLiquido = 0; //declaracion variable
            decimal SueldoBruto = 0;

            decimal sueldo = 0.0M;

            
            decimal descuentofonasa = 0.07M;//la M es de decimal
            decimal DescuentoSeguro = 0.03M;
            decimal descuentoAFP = 0.11M;
            decimal bono = 0.12M;

            decimal resuldescuentoseguro = 0.0M;
            decimal resulFonasa = 0.0M;
            decimal resulAFP = 0.0M;

            string Sueldoliquido = null;//ESTA VARIABLE ALMACENA EL SUELDO CON FORMA DE PESO
            string Sueldobruto = null;
            #endregion

            //CHB
            try
            {

                if (chBono.Checked)//si esta checkado el sueldo aumenta un 12% mefaltaaaaaa esteeee
                {
                    if(!String.IsNullOrEmpty(txtSueldobruto.Text))
                    {
                        resulFonasa = Convert.ToDecimal(txtSueldobruto.Text) * descuentofonasa;
                        txtFonasa.Text = resulFonasa.ToString();

                        resuldescuentoseguro = Convert.ToDecimal(txtSueldobruto.Text) * DescuentoSeguro;
                        txtDesSeguro.Text = resuldescuentoseguro.ToString();


                        resulAFP = Convert.ToDecimal(txtSueldobruto.Text) * descuentoAFP;
                        txtDesAFP.Text = resulAFP.ToString();

                        SueldoLiquido = Convert.ToDecimal(txtSueldobruto.Text) - resulFonasa;
                        txtSueldoLiqudo.Text = SueldoLiquido.ToString();

                        panel1.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("ingrese sueldo bruto");
                    }

                }
                else
                {
                    MessageBox.Show("el control checkbox NO esta seleccionado");

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        


    }

        private void chBono_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
