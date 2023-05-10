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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*con las comas funcionana las notas*/
        private void Btnpromedio_Click(object sender, EventArgs e)
        {
            #region decraracion de variable
            decimal nota1 = 0.0M;//para nota
            decimal nota2 = 0.0M;
            decimal nota3 = 0.0M;//añadido
            decimal promedio = 0.0M;
            decimal p1 = 0.40m;
            decimal p2 = 0.30m;
            decimal p3 = 0.30m;

            //AÑADIDO
            decimal valor = 4.0M;
            #endregion
            try
            { //verifica contenido
                if (!String.IsNullOrEmpty(txtnota1.Text) && !String.IsNullOrEmpty(txtnota2.Text) && !String.IsNullOrEmpty(txtnota3.Text))
                {
                //captura la nota del texbox y asigno a variable
                    nota1 = Convert.ToDecimal(txtnota1.Text);
                    nota2 = Convert.ToDecimal(txtnota2.Text);

                    nota3 = Convert.ToDecimal(txtnota3.Text);

                    nota1 = p1 * nota1;
                    nota2 = p2 * nota2;
                    nota3 = p3 * nota3;

                promedio = (nota1 + nota2 + nota3);

                txtpromedio.Text = promedio.ToString();//convierto a string el contenido de la variable .ToString()
                    //AÑADIDO
                if (promedio >= valor) 
                    {
                    MessageBox.Show("se exime ");
                    pnlAprobado.Visible = true;

                    pnlReprobado.Visible = false;
                    }
                else
                {
                    MessageBox.Show("rendir examen");
                    pnlAprobado.Visible = false;

                    pnlReprobado.Visible = true;
                }
            }
            else
                {
                    MessageBox.Show("debe ingresar ambas notas");
                }
             }
            //se agregan notas con coma o punto //depende para que funcione
 
            catch (Exception ex)//la variable ex almacena la excepcion o error que se genere
            {
                throw ex;
            }
    }
}
}