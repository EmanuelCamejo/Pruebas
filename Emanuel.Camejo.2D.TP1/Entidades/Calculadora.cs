using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        #region Metodos
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double res = 0;
            char validarOperador = ValidarOperador(operador);
            if (validarOperador == '+')
            {
                res = num1 + num2;
            }
            if (validarOperador == '-')
            {
                res = num1 - num2;
            }
            if (validarOperador == '/')
            {
                res = num1 / num2;
            }
            if (validarOperador == '*')
            {
                res = num1 * num2;
            }
            return res;
        }
        private static char ValidarOperador(char operador)
        {
            char res = ' ';
            if (operador == '+' || operador == '-' || operador == '/' || operador == '*')
            {
                res = operador;
            }
            else
            {

            }
            return res = '+';
        }

        #endregion

    }
}
