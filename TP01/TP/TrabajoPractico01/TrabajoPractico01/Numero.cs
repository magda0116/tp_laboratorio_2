using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico01
{
    class Numero
    {
        #region Atributo

        private double _miNumero;

        #endregion

        /// <summary>
        /// Metodos
        /// </summary>
        #region Constructores

        /// <summary>
        /// 1er Constructor por defecto. Parametro vacio. Inicializa el atributo numero en cero 
        /// </summary>
        public Numero()
        {
            _miNumero = 0;
        }

        /// <summary>
        /// 2do Constructor. Parametro tipo double
        /// </summary>
        /// <param name="numero"></param>
        public Numero(double numero)
        {
            this._miNumero = numero;
        }

        /// <summary>
        /// 3er Constructor.Parametro tipo string
        /// </summary>
        /// <param name="numero"></param>
        public Numero(string numero)
        {
            setNumero(numero);
        }

        #endregion

        #region Metodos


        public double getNumero()
        {
            return this._miNumero;
        }


        private void setNumero(string numero)
        {
            this._miNumero = validarNumero(numero);
        }


        private double validarNumero(string numeroString)
        {
            double num = 0;

            if (double.TryParse(numeroString, out num))
            {
                return num;
            }
            return 0;
        }

        #endregion  

    }
}
