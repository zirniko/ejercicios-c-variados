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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                Estudiante es = new Estudiante();
                //es.InsertarEstudiante();
                MessageBox.Show("conectado");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
