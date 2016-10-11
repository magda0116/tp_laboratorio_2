﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Clase_12_Library_2;

namespace Clase_12_Library
{
    public class Moto: Vehiculo
    {
        #region "Constructor"
        public Moto(EMarca marca, string patente, ConsoleColor color)
            : base(marca,patente,color)
        {
        }

        #endregion

        #region "Metodos"

        /// <summary>
        /// Las motos tienen 2 ruedas
        /// </summary>
        
        public short CantidadRuedas
        {
            get
            {
                return 2;
            }
        }

        /// <summary>
        /// Muestra la cantidad de ruedas de la Moto
        /// </summary>
 
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("MOTO");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("RUEDAS : {0}", this.CantidadRuedas);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

        
            return sb.ToString();
        }

        #endregion
    }
}
