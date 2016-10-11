using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_12_Library;

namespace Clase_12_Library_2
{
    public abstract class Vehiculo
    {
        #region "Enumerado"
        public enum EMarca
        {
            Yamaha, Chevrolet, Ford, Iveco, Scania, BMW
        }

        #endregion

        #region "Atributos"

        EMarca _marca;
        
        string _patente;
        
        ConsoleColor _color;

        protected short _cantidRue;

        #endregion

        #region "Constructores"

        protected Vehiculo(EMarca marc, string pat, ConsoleColor col)
        {
           this. _marca = marc;
           this. _patente = pat;
           this. _color = col;
        }

        #endregion

        #region "Metodos"
        /// <summary>
        /// Retornara la cantidad de ruedas de vehiculo
        /// </summary>
 
        public short CantidadRuedas
        {
            get
            {
                return this._cantidRue;
            }
        }
    

        /// <summary>
        /// Muestra Patente, Marca y Color
        /// </summary>
 
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("PATENTE: {0}\r\n", this._patente);
            sb.AppendFormat("MARCA  : {0}\r\n", this._marca.ToString());
            sb.AppendFormat("COLOR  : {0}\r\n", this._color.ToString());
            sb.AppendLine("---------------------");
            return sb.ToString();
        }

        #endregion

        #region "Operadores"
        /// <summary>
        /// Dos vehículos son iguales si comparten la misma patente
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            if (!object.ReferenceEquals(v1, null) && !object.ReferenceEquals(v2, null))
            {
                if (v1._marca == v2._marca & v1._color == v2._color & v1._patente ==v2._patente)
                {
                    return true;
                }

            }
            return false;
        }
        /// <summary>
        /// Dos vehículos son distintos si su patente es distinta
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

        #endregion
    }
}
