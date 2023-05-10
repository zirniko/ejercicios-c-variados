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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //añadido
        public int a = 0;

        public int ee = 0;

        public int i = 0;

        public int o = 0;

        public int u = 0;
        //fin

        private void buttonA_Click(object sender, EventArgs e)
        {
            
            try
            {
                panel1.Visible = true;
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                a = a + 1;
                txt1.Text = "pulso " + a.ToString();
               


            }
            catch (Exception)
            {
                throw;
            }
        }
        



        private void buttonE_Click(object sender, EventArgs e)
        {
            
          

            try
            {
                panel1.Visible = false;
                panel2.Visible = true;
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                ee = ee + 1;
                txt2.Text = "pulso " + ee.ToString();
               
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            
          
            try
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = true;
                panel4.Visible = false;
                panel5.Visible = false;
                i = i + 1;
                txt3.Text = "pulso " + i.ToString();
                
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void buttonO_Click(object sender, EventArgs e)
        {
            
           
            try
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = true;
                panel5.Visible = false;
                o = o + 1;
                txt4.Text = "pulso " + o.ToString();
               
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            
            try
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = true;

                o = o + 1;
                txt5.Text = "pulso " + o.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
