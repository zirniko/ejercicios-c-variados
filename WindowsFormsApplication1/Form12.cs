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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {//evento .primero se crea en try-catch;
            if (!String.IsNullOrEmpty(txtNumero1.Text) && !String.IsNullOrEmpty(txtNumero2.Text))//todo funciona pero hay que valirar lo señalado

            {
                try
                {
                    //coloco el nombre de la clase y las valiables en este caso es 'op'
                    Operaciones op = new Operaciones();//se crea el op aqui
                                                       //aqui se llama la operacion sumar y los parametros enteros.
                    MessageBox.Show("La suma es: " + op.Sumar(Convert.ToInt32(txtNumero1.Text),
                                                             Convert.ToInt32(txtNumero2.Text)));
                }

                catch (Exception ex)//ex agregado
                {
                    throw ex;
                }
            }
            else
            {
                MessageBox.Show("debe ingresar ambas notas");//<-----este hay que ver que funciona
            }

        }


        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                Operaciones op = new Operaciones();
                MessageBox.Show("La Multiplicasion es: " + op.Multiplicar(Convert.ToInt32(txtNumero1.Text),
                                                         Convert.ToInt32(txtNumero2.Text)));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
