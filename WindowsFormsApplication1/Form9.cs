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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            #region declaracion de variables
            int cantidad = 0;

            int cantidad1 = 0;
            int cantidad2 = 0;
            int cantidad3 = 0;
            int TotalCompra = 0;
            //descuento                   FALTA APLICAR EL EJERCICIO DE LOS DESCUENTOS
            
            //decimal totaldescuento = 0.0M;
            decimal descuento1 = 0.10M;
            decimal descuento2 = 0.20M;
            
            #endregion


            try
            {
                if(chb1.Checked)
                {
                    if (!String.IsNullOrEmpty(txtcantidad1.Text))
                    {
                        cantidad1 = Convert.ToInt32(txtcantidad1.Text);
                        cantidad1 = cantidad1 * 1200;
                    }
                    else
                    {
                        MessageBox.Show("ingrese cantidad");
                    }
                }

                if(chb2.Checked)
                {
                    if(!string.IsNullOrEmpty(txtcantidad2.Text))
                    {
                        cantidad2 = Convert.ToInt32(txtcantidad2.Text);
                        cantidad2 = cantidad2 * 1500;
                    }
                    else
                    {
                        MessageBox.Show("ingrese cantidad");
                    }

                }
                if (chb3.Checked)
                {
                    if (!string.IsNullOrEmpty(txtcantidad3.Text))
                    {
                        cantidad3 = Convert.ToInt32(txtcantidad3.Text);
                        cantidad3 = cantidad3 * 2500;
                    }
                    else
                    {
                        MessageBox.Show("ingrese cantidad");
                    }
               
                }
                //Descuento ,                   FALTA APLICAR EL EJERCICIO DE LOS DESCUENTOS

                /*
                if  (TotalCompra > 10000)
                    {
                    totaldescuento = Convert.ToDecimal(txtResultado.Text)-( Convert.ToDecimal(txtResultado.Text) * descuento1);
                    }
                    else
                    {
                    resulDescuento = Convert.ToDecimal(txtResultado.Text) - (Convert.ToDecimal(txtResultado.Text) * descuento2);
                    }
                
                */

                //fin descuento

                TotalCompra = cantidad1 + cantidad2 + cantidad3;//este agrege y funcionaaaaaaaaaaa
                /* TotalCompra = TotalCompra1 + TotalCompra2 + TotalCompra3; */   //comento para probar
                //totaldescuento = TotalCompra;

                if(TotalCompra >10000)
                {
                    descuento1 = Convert.ToDecimal(lbltotalcompra.Text) - (Convert.ToDecimal(lbltotalcompra.Text) * descuento1);
                }
                else
                {
                    descuento2 = Convert.ToDecimal(lbltotalcompra.Text) - Convert.ToDecimal(lbltotalcompra.Text) * descuento2;
                }


                lbltotaltotal.Text = TotalCompra.ToString();
                pnlResultado.Visible = true;

            }
            catch(Exception ex)//añadi el ex
            {
                 throw ex;//añadi el ex
            }

            
        }
        
        private void TxtResultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
