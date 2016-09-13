using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico01
{
    #region Clase
    class Calculadora
    {
     
        #region Metodos

        /// <summary>
        /// Metodo de clase llamado operar. Su valor de retorto es tipo Double.
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        
        public static double operar(Numero numero1, Numero numero2, string operador)
        {
            double total = 0;

            switch (validarOperador(operador))
            {
                case "+": 
                          total = numero1.getNumero() + numero2.getNumero();

                          break;

                case "-": total = numero1.getNumero() - numero2.getNumero();

                          break;

                case "*": total = numero1.getNumero() * numero2.getNumero();

                          break;

                case "/": if (numero2.getNumero() != 0)
                          {
                            total = numero1.getNumero() / numero2.getNumero();
                          }
                          else
                          {
                            return 0;
                          }

                          break;

                default: break;

            }
            return total;
        }

        /// <summary>
        /// Codificar un metodo e clase llamado ValidarOperador.Valida operador caso contrario retorna +.
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns>
        public static string validarOperador(string operador)
        {
        
            if (operador == "+")
            {
                return operador;
            }
            else if (operador == "-")
            {
                return operador;
            }
            else if (operador == "*")
            {
                return operador;
            }
            else if (operador == "/")
            {
                return operador;
            }
            else
          
                return "+";
        }

        #endregion 
    }
    #endregion
}
