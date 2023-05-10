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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            

            #region declaracion de variables

            int edad = 0;//listo -- 2 declarcion de variables
            /*
            decimal interesA  = 0.04M;// M de decimal
            decimal interesB = 0.10M;
            */
            decimal interesMensual = 0.0M;
            decimal valorCuota = 0.0M;
            decimal MontoPrestamo = 0.0M;
            decimal interes = 0.0M;
            int numcuota = 0;
            decimal total = 0.0M;
            
            #endregion
            //paso 1 realizar el try
            try
            {
                //ejercico profe
                // la ! PREGUNTA SI ES DISTINTTO DE NULO O VACIO
                if (!String.IsNullOrEmpty(txtedad.Text))//si tiene datos

                {
                    edad = Convert.ToInt32(txtedad.Text);//CONVIERTO A ENTERO
                    if(edad>=18)
                    {
                        //determinar interes DIRECTAMENTE PARA NO HACER TNTO CALCULO
                        if(edad>60)
                        {
                            interes = 0.04M;//(OPCION 1)
                        }
                        else
                        {
                            interes = 0.10M;//(OPCION 2)
                        }
                        //CALCULO
                       if(!String.IsNullOrEmpty (txtmontoPrestamo.Text) && !String.IsNullOrEmpty(txtNumCuotas.Text))//&& añadido para valor cuota
                        {
                            //CONVERSION
                            MontoPrestamo = Convert.ToDecimal(txtmontoPrestamo.Text);
                            interesMensual = MontoPrestamo * interes;

                            txtInteresMensual.Text = interesMensual.ToString();//convierto a string o si no No sep uede

                            numcuota = Convert.ToInt32(txtNumCuotas.Text);

                            valorCuota = numcuota * interesMensual;
                            //ASIGNAMOS EL RESULTADO A UN TEXTBOX ,PERO CONVERTIDO A STRING
                            txtValorCuotas.Text = valorCuota.ToString();


                            total = valorCuota * numcuota;
                            txtTotal.Text = total.ToString();
                            panelDatos.Visible = true;//al final hacer visible el panel
                        }
                        else
                        {
                            MessageBox.Show("Debe ingresar el monto y cuotas");
                        }
                    }
                    else
                    {
                       MessageBox.Show("no cumple CON LA EDAD NO INSISTA!!");
                        return;//para que termine aqui la eejecucion ,solo cuando termina el proceso
                    }
                }
                /*
                 * mi ejercicio
                //convertirrrrrrr
                
                //FIN
                edad = Convert.ToInt32(txtedad.Text);
                

            if (edad >= 60)
            {

                    lblmensaje.Text = "eres mayor de edad";
                    MessageBox.Show("eres mayor de edad");


                    pnlresultado.Visible = true;

                }
            if (edad < 60)
                {
                    lblmensaje.Text = "eres mayor de edad";
                    MessageBox.Show("eres mayor de edad");

                    pnlresultado.Visible = true;
                }


            else
            {
                lblmensaje.Text = "no eres mayor de edad";
                MessageBox.Show("no eres mayor de edad");
                pnlresultado.Visible = false;

            
                }
              */
            
         }
            catch (Exception)
            {


            /* mi ejericio
                lblmensaje.Text = ex.Message.ToString();
                throw ex;
            */

            throw ;
                /*aqui dejamos el error*/
            
            }

        }
    }
}
