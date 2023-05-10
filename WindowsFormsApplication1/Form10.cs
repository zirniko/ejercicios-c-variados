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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            #region declaracion de variables
            decimal nota1 = 0.0M;
            decimal nota2 = 0.0M;
            decimal nota3 = 0.0M;
            decimal nota4 = 0.0M;

            decimal promedio = 0.0M;

            decimal ponderacion1 = 0.20M;
            decimal ponderacion2 = 0.20M;
            decimal ponderacion3 = 0.30M;
            decimal ponderacion4 = 0.30M;

            //AÑADIDO
            /*   decimal valor = 4.0M;      */ 
            #endregion
            try
            {
                if (!String.IsNullOrEmpty(txtnota1.Text) && 
                    !String.IsNullOrEmpty(txtnota2.Text) && 
                    !String.IsNullOrEmpty(txtnota3.Text) && 
                    !String.IsNullOrEmpty(txtnota4.Text))
                {
                    #region convierto a decimal y multiplico por porcentaje
                    nota1 = Convert.ToDecimal(txtnota1.Text) * ponderacion1;
                    nota2 = Convert.ToDecimal(txtnota2.Text) * ponderacion2;//aqui la profe coloco la ponderacion directamente
                    nota3 = Convert.ToDecimal(txtnota3.Text) * ponderacion3;
                    nota4 = Convert.ToDecimal(txtnota4.Text) * ponderacion4;

                    /* este es mi metodo de la ponderacion
                    nota1 = ponderacion1 * nota1;
                    nota2 = ponderacion2 * nota2;
                    nota3 = ponderacion3 * nota3;
                    nota4 = ponderacion4 * nota4;
                    */
                    #endregion

                    #region calculo promedio
                    promedio = (nota1 + nota2 + nota3 + nota4)/4;//aqui quite el dividido en 4
                    #endregion

                    #region muestro resultado
                    lblpromedio.Text = "el promedio es" + promedio.ToString();
                    #endregion 
                }
                else
                {
                    
                        MessageBox.Show("debe ingresar ambas notas");
                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //decimal nota1 = 0.0M;
            /*
            nota1 = Convert.ToDecimal(txtnota1.Text);
            nota1 = Convert.ToDecimal(txtnota1.Text);

            */
            //estoy probado con decimal , en principio estaba en .ToInt32  asi ==>  int nota2 = Convert.ToInt32(txtnota2.Text);   
            decimal nota1 = Convert.ToDecimal(txtnota1.Text);
            decimal nota2 = Convert.ToDecimal(txtnota2.Text);
            decimal nota3 = Convert.ToDecimal(txtnota3.Text);
            decimal nota4 = Convert.ToDecimal(txtnota4.Text);

            if (nota1 < nota2 && nota1 < nota3 && nota1 < nota4)
            {
                lblresultado2.Text = "la nota menor es   " + nota1;
            }
            if (nota2 < nota1 && nota2 < nota3 && nota1 < nota4)
            {
                lblresultado2.Text = "la nota menor es   " + nota2;
            }
            if (nota3 < nota1 && nota3 < nota2 && nota3 < nota4)
            {
                lblresultado2.Text = "la nota menor es  " + nota3;
            }
            if (nota4 < nota1 && nota4 < nota2 && nota4 < nota3)
            {
                lblresultado2.Text = "la nota menor es    " + nota4;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            int nota1 = Convert.ToInt32(txtnota1.Text);
            int nota2 = Convert.ToInt32(txtnota2.Text);
            int nota3 = Convert.ToInt32(txtnota3.Text);
            int nota4 = Convert.ToInt32(txtnota4.Text);*/

            decimal nota1 = Convert.ToDecimal(txtnota1.Text);
            decimal nota2 = Convert.ToDecimal(txtnota2.Text);
            decimal nota3 = Convert.ToDecimal(txtnota3.Text);
            decimal nota4 = Convert.ToDecimal(txtnota4.Text);


            //aqui canbie el int por decimal en todos 
            //decimal nota4 = Convert.ToInt32(txtnota4.Text);

            if (nota1 > nota2 && nota1 > nota3 && nota1 > nota4)
            {
                lblresultado.Text = "la nota mayor es    " + nota1;
            }
            if (nota2 > nota1 && nota2 > nota3 && nota1 > nota4)
            {
                lblresultado.Text = "la nota mayor es    " + nota2;
            }
            if (nota3 > nota1 && nota3 > nota2 && nota3 > nota4)
            {
                lblresultado.Text = "la nota mayor es    " + nota3;
            }
            if (nota4 > nota1 && nota4 > nota2 && nota4 > nota3)
            {
                lblresultado.Text = "la nota mayor es  " + nota4;
            }
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {//inicio
            decimal promedio = 0.0M;

            decimal valor = 4.0M;

            if (promedio >= valor)
            {
                lblEstado.Text ="SE EXIME";
            }
            else
            {
                lblEstado.Text ="RENDIR EXAMEN";
            }

        }//fin

    }
}
