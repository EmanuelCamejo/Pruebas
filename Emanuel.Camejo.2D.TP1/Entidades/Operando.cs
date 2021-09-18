using System;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        #region Propiedades

        //public string Numero
        //{
        //    get 
        //    {
        //        return numero.ToString();

        //    }
        //    set
        //    {
                
        //        Operando.ValidarOperando()=value;
        //    }
        //}

        #endregion

        #region Constructores
        public Operando() : this(0)
        {

        }

        public Operando(double num1)
        {
            this.numero = num1;
        }

        public Operando(string strNum1)
        {
            this.numero = int.Parse(strNum1);
        }
        #endregion

        #region Metodos
        private double ValidarOperando(string strNumero)
        {
            double res,num;

            bool a = double.TryParse(strNumero, out num);
            if (a==true)
            {
                res = num;
            }
            else
            {
                res = 0;
            }
            return res;
        }

        private bool EsBinario(string binario)
        {
            bool res;

            return res;
        }

        public static string DecimalABinario(double numero)
        {
            string binario = "";

            while (numero / 2 > 0)
            {
                if (numero % 2 == 0)
                    binario = "0" + binario;
                if (numero % 2 == 1)
                    binario = "1" + binario;
                numero = numero / 2;
            }
            if (numero == 0)
            {
                binario = "0" + binario;
            }
            if (numero == 1)
            {
                binario = "1" + binario;
            }

            return binario;
        }
        #endregion

        #region Sobrecargas
        public static double operator +(Operando num1, Operando num2)
        {
            return num1.numero + num2.numero;
        }
        public static double operator -(Operando num1, Operando num2)
        {
            return num1.numero - num2.numero;
        }
        public static double operator /(Operando num1, Operando num2)
        {
            return num1.numero / num2.numero;
        }
        public static double operator *(Operando num1, Operando num2)
        {
            return num1.numero * num2.numero;
        }


        #endregion
    }
}
