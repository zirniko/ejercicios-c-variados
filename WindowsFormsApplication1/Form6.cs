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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void BtnAutentificar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text=="zirniko"|| txtContraseña.Text=="123")
            {
                pnlpermitido.Visible=true;
                pnlDenegado.Visible = false;
            }
            else
            {
                pnlpermitido.Visible = false;
                pnlDenegado.Visible = true;
            }
        }
    }
}
