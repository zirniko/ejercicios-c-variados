using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Operaciones2
    {
        //aqui se realizan los metodos
        public string CalcularTotal //Metodo1.
                                    //aqui se reciblen todos los parametros.
                                    //el string señala que se devuelve un valor string
                                    //si es int se devuelen solo numeros ,etc.
            (//parametoros
            bool ChbEmpanda,//siempre es boolean para el verdadero o falso.
            string CantidadEmpanada, //contenido del checkbox
            bool ChbChilenito, //V o F
            string CantidadChilenito//contneido del checkbox
            )
        {
            string Resultado = "";
            int Calculo = 0;
            try
            {

                if (ChbEmpanda)//  <-----------    se pregunta si es verdadero directamente tal cual aparecese aqui  
                {
                    if (!String.IsNullOrEmpty(CantidadEmpanada))//paramtro 1 nulo o con contenido
                    {
                        Calculo = Convert.ToInt32(CantidadEmpanada) * 12000;//parametro 2 convierto entero y multiplico por 12.000
                    }
                    else
                    {
                        Resultado = "Debe ingresar una cantidad de docenas de empanadas";//y sin no envio un mensaje.
                        return Resultado;//siempre debe estar la sentnecia return y la variable resulatos para devolver el mensje.importante
                    }

                }
                if (ChbChilenito)
                {
                    if (!String.IsNullOrEmpty(CantidadChilenito))//paramtro 3
                    {
                        Calculo = Calculo + Convert.ToInt32(CantidadChilenito) * 2500;//paramtro 4
                    }
                    else
                    {
                        Resultado = "Debe ingresar una cantidad de docenas de chilenitos";
                        return Resultado;
                    }
                }
                if (!ChbEmpanda && !ChbChilenito)
                {
                    Resultado = "Debe seleccionar al menos una opción";
                    return Resultado;
                }

                Resultado = "El total a pagar es: " + Calculo.ToString();
                return Resultado;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
