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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void BtnNotaExamen_Click(object sender, EventArgs e)
        {
            #region
            decimal promedioNota = 0.0M;
            decimal notaAprobada = 0.0M;

            decimal promedioValor = 0.30M;
            decimal examen = 0.70M;

            decimal notaNesesaria = 4.0M;//NOTA EXAMEN

            decimal porcentaje1 = 0.70M;
            #endregion


            try
            {
                if(ChbAsistencia.Checked)
                {
                    if (!String.IsNullOrEmpty(TxtNotas.Text))
                    {

                    promedioNota = Convert.ToDecimal(TxtNotas.Text)*porcentaje1;
                        TxtResultado.Text = promedioNota.ToString();

                   // notaAprobada = promedioNota;  este falta obtener - el notaAprobada
                    }
                    else
                    {
                        MessageBox.Show("ingrese datos");
                    }

                }
                else
                {
                    MessageBox.Show("Reprobado");

                }
                

            }
            catch (Exception)
            {

                throw;
            }


        }

        private void ChbAsistencia_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                if (ChbAsistencia.Checked)
                {
                    MessageBox.Show("cumple con asistencia");
                    //visible
                    pnlResultado.Visible = true;
                    lblmensaje.Text = "el panel esta visible";
                }
                else
                {
                    MessageBox.Show("Usted esta reprobado");

                    //ocultamos panel
                    pnlResultado.Visible = false;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
