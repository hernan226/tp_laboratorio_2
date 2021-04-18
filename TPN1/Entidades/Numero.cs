using System;

namespace Entidades
{
    public class Numero
    {
        /// <summary>
        /// Atributo que guarda el numero a operar.
        /// </summary>
        private double numero;

        /// <summary>
        /// Propiedad que guarda el numero y lo valida, 
        /// si la validacion falla guardara 
        /// </summary>
        public string SetNumero
        {
            set { numero = ValidarNumero(value); }
        }

        #region Constructores

        /// <summary>
        /// Constructor por defecto Asignandose cero.
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }

        /// <summary>
        /// Se asigna el numero de presicion doble.
        /// </summary>
        /// <param name="num">Numero que se asignara.</param>
        public Numero(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// Se asigna el numero recibido en un string validado.
        /// </summary>
        /// <param name="numero">Numero que se asignara.</param>
        public Numero(string numero)
        {
            this.SetNumero = numero;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Convierte un numero binario a decimal.
        /// </summary>
        /// <param name="binario">Numero binario a convertir.</param>
        /// <returns>Numero convertido a decimal.</returns>
        public static string BinarioDecimal(string binario)
        {
            return EsBinario(binario) ?
                Convert.ToInt32(binario, 2).ToString() : "Valor inválido";
        }

        /// <summary>
        /// Convierte el numero recibido a binario y lo retorna como string.
        /// </summary>
        /// <param name="numero">Numero a convertir.</param>
        /// <returns>Un numero convertido a binario.</returns>
        public static string DecimalBinario(double numero)
        {
            string cadena = "";
            int aux = (int)numero;

            if (aux > 0)
            {
                while (aux > 0)
                {
                    if (aux % 2 == 0)
                        cadena = "0" + cadena;
                    else
                        cadena = "1" + cadena;
                    aux = (aux / 2);
                }
            }
            else if (aux == 0)
                cadena = "0";

            return cadena;
        }

        /// <summary>
        /// Convierte y valida el numero recibido a binario 
        /// y lo retorna como string.
        /// </summary>
        /// <param name="binario">Numero a convertir.</param>
        /// <returns>Un numero convertido a binario o "Valor invalido." en caso de error.</returns>
        public static string DecimalBinario(string binario)
        {
            double doble;
            return double.TryParse(binario, out doble) ?
                DecimalBinario(doble) : "Valor inválido";
        }

        /// <summary>
        /// Comprueba si el numero recibido es un binario valido.
        /// </summary>
        /// <param name="binario">Binario a validar.</param>
        /// <returns>Retorna true si es valido y false si no.</returns>
        private static bool EsBinario(string binario)
        {
            bool retorno = true;
            string numeroBinario = binario.Trim();
            foreach (char bit in numeroBinario)
            {
                if (bit != '1' && bit != '0')
                {
                    retorno = false;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Comprueba que el valor recibido sea numérico, y lo retornará en
        /// formato double. Caso contrario, retornará 0.
        /// </summary>
        /// <param name="strNumero">String con el numero a validar.</param>
        /// <returns>El numero validado.</returns>
        public double ValidarNumero(string strNumero)
        {
            double.TryParse(strNumero, out double retorno);
            return retorno;
        }
        #endregion

        #region Operadores
        /// <summary>
        /// suma dos Numeros.
        /// </summary>
        /// <param name="n1">Numero a sumar.</param>
        /// <param name="n2">Numero a sumar.</param>
        /// <returns>Resultado de la suma.</returns>
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// Resta dos numeros.
        /// </summary>
        /// <param name="n1">Numero a restar.</param>
        /// <param name="n2">Numero que resta.</param>
        /// <returns>Resultado de la resta.</returns>
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// Multiplica dos numeros.
        /// </summary>
        /// <param name="n1">Numero a multiplicar.</param>
        /// <param name="n2">Numero a multiplicar.</param>
        /// <returns>Resultado de la multiplicacion.</returns>
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// Divide dos numeros.
        /// </summary>
        /// <param name="n1">Dividendo.</param>
        /// <param name="n2">Divisor.</param>
        /// <returns>Resultado de la division o double.MinValue si el divisor es cero.</returns>
        public static double operator /(Numero n1, Numero n2)
        {
            return (n2.numero != 0) ?
                n1.numero / n2.numero : double.MinValue;
        }
        #endregion
    }
}