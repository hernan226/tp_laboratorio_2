namespace Entidades
{
    public class Calculadora
    {
        /// <summary>
        /// Toma los dos numeos recibidos y realiza la operacion indicada en la variable operador.
        /// </summary>
        /// <param name="num1">Primer numero a operar.</param>
        /// <param name="num2">Segundo numero a operar.</param>
        /// <param name="operador">El operador.</param>
        /// <returns>Devuelve el resultado de la operacion.</returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double retorno;
            switch (ValidarOperador(operador[0]))
            {
                case "/":
                    retorno = num1 / num2;
                    break;
                case "*":
                    retorno = num1 * num2;
                    break;
                case "-":
                    retorno = num1 - num2;
                    break;
                default:
                    retorno = num1 + num2;
                    break;

            }
            return retorno;
        }

        /// <summary>
        /// Valida que el operador recibido sea efectivamente uno,
        /// caso contrario, retonara +.
        /// </summary>
        /// <param name="operador">Operador a validar.</param>
        /// <returns>El operador validado.</returns>
        private static string ValidarOperador(char operador)
        {
            string retorno = "+";
            switch (operador)
            {
                case '/':
                case '*':
                case '-':
                    retorno = operador.ToString();
                    break;
            }
            return retorno;
        }
    }
}
