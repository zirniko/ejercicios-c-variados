using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    //          CORRESPONDIENTE AL FORM 12 METODOS Y CLASES //SUMA -RESTA.
    //aqui se impcpora un public en la clase operacioens
    public class Operaciones//<=aqui se agrego el public
    //si es public sera utilizada en todo el proyecto.
    {
        //metodo para sumar.
        public int Sumar(int num1, int num2)//devuenve numero entreros por el int.pero se puede cambiar
                        
        {
            int Resultado = 0;
            try
            {
                Resultado = num1 + num2;
                return Resultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Multiplicar(int num1,
                         int num2)
        {
            int Resultado = 0;
            try
            {
                Resultado = num1 * num2;
                return Resultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Restar(int num1,
                            int num2)
        {
            int Resultado = 0;
            try
            {
                Resultado = num1 - num2;
                return Resultado;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public int Divicion(int num1,
                            int num2)
        {
            int Resultado = 0;
            try
            {
                Resultado = num1 / num2;
                return Resultado;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
