using System;

namespace Entidades
{
    public class Calculadora
    {
        #region Metodos
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            char operadorValido = ValidarOperador(operador);
            double res = 0;

            if (operadorValido == '+')
            {
                res = num1 + num2;
            }
            if (operadorValido == '-')
            {
                res = num1 - num2;
            }
            if (operadorValido == '/')
            {
                res = num1 / num2;
            }
            if (operadorValido == '*')
            {
                res = num1 * num2;
            }
            return res;
        }
        private static char ValidarOperador(char operador)
        {
            if (operador == '+' || operador == '-' || operador == '/' || operador == '*')
            {
                return operador;
            }
            else
            {
                return '+';
            }
        }
        #endregion
    }
}
