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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void chbEstudia_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if(chbEstudia.Checked)
                {
                    pnlEstudia.Visible = true;
                }
                else
                {
                    pnlEstudia.Visible = false;
                    txtLugar.Text = "";
                    txtCarrera.Text = "";
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnVerDatos_Click(object sender, EventArgs e)
        {
            #region
            string Estudia = "";
            #endregion
            try
            {
                if(chbEstudia.Checked)
                {
                    Estudia = "si estudia";
                    MessageBox.Show("los datos ingresados son " +
                        "  Nombre: " + txtNombre.Text + 
                        " - Edad: " + txtEdad.Text + 
                        " - Estudia : " + Estudia + 
                        "  Lugar : " + txtLugar.Text + 
                        "  Carrera :  " + txtCarrera.Text);      
                    
                }
                else
                {
                    Estudia = "No estudia";
                    MessageBox.Show("los datos ingresados son : " +
                        " nombre: " + txtNombre.Text + 
                        " - Edad:  " + txtEdad.Text + 
                        " -  Estudia: " + Estudia);   
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
