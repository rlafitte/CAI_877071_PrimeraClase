using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraClase.LibreriaClases
{
    public class Class1
    {
        public static bool Longitud(string palabra, int longitudMaxima)
        {
            //Método que valida si excede longitud

            return (palabra.Length >= longitudMaxima);

        }

        public static bool ValidaNumero(string valor)
        {
            // valida que se ingresó un número
            int value = 0;
            return (int.TryParse(valor, out value));
        }

        public static bool ValidaOperador(string valor)
        {
            bool flag = false;
            string operadores = "+-*/";

            //validamos que el operador ingresado está dentro de los valores previstos
            if (operadores.Contains(valor))
            {
                flag = true;
            }
            return flag;
        }

        public static void Operacion(int valor1, int valor2, string operador, out string resultado)
        {
            resultado = "";
            int resultado_aux=0;
            switch(operador)
            {
                case "+":
                    resultado_aux = valor1 + valor2;
                    break;
                case "-":
                    resultado_aux = valor1 - valor2;
                    break;
                case "*":
                    resultado_aux = valor1 * valor2;
                    break;
                case "/":
                    resultado_aux = valor1 / valor2;
                    break;
                default:
                    resultado = "Operación no identificada.";
                    break;
            }
            resultado = Convert.ToString(resultado_aux);
        }
    }
}
