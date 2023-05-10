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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void BtnSueldoLiquido_Click(object sender, EventArgs e)
        {
            //declarasion de variables
            #region Declarasion de variables
            decimal SueldoLiquido = 0; //declaracion variable

            decimal fonasa = 0.07M;//la M es de decimal
            decimal DescuentoEnPlataFonasa = 0;

            string SueldoConFormato = null;//ESTA VARIABLE ALMACENA EL SUELDO CON FORMA DE PESO
            Decimal AFP = 0.10M;
            Decimal DescuentoEnPlataAFP = 0;
            #endregion
            try//ingresamos datos siguientes
            {
                DescuentoEnPlataFonasa = Convert.ToDecimal(txtSueldo.Text) * fonasa;

                DescuentoEnPlataAFP = Convert.ToDecimal(txtSueldo.Text) * AFP;

                //400000*0.07=28000 quedan en la variable DescuentoEnPlataFonasa
                SueldoLiquido = Convert.ToDecimal(txtSueldo.Text) - DescuentoEnPlataFonasa;
                //372000-400000-28000

                SueldoConFormato = string.Format("{0:c1}", SueldoLiquido);//estoy dando el formato de pesos

                MessageBox.Show("El sueldo liquido es:" + SueldoLiquido);
                //al suedo bruto ingresamos se debera descontar elporcentaje del valor de fonasa
                //y se debera mostrar el sueldo liquido(sueldo bruto-fonasa)
            }
            catch (Exception ex)//nombre de variable,este demuestra el error al usuario
            {

                throw ex;
            }
        }
    }
}
