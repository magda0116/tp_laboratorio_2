using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_12_Library_2;

namespace Clase_12_Library
{
    public class Camion:Vehiculo
    {
        #region "Constructor"
  
        public Camion(EMarca marca, string patente, ConsoleColor color)
            : base(marca, patente,color)    
        {
        }

        #endregion

        #region "Metodos"
        /// <summary>
        /// Los camiones tienen 8 ruedas
        /// </summary>

        protected short CantidadRuedas
        {
            get
            {
                return 8;
            }
        }
        /// <summary>
        /// Muestra Cantidad de Ruedas del Camion
        /// </summary>
 
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CAMION");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("RUEDAS : {0}", this.CantidadRuedas);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        #endregion
    }
}
