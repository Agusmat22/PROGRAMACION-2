﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Llamada
    {
        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public Llamada(float duracion,string nroDestino,string nroOrigen) 
        { 
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;   
        }

        //PROPERTY
        public float Duracion
        {
            get { return this.duracion; }
        }

        public string NroDestino
        {
            get { return this.nroDestino; }

        }

        public string NroOrigen
        {
            get { return this.nroOrigen; }

        }


        //METHOD

        /// <summary>
        /// Metodo COMPARISON sirve para usarlo dentro del .Sort() y en ese caso compara de menor a mayor
        /// </summary>
        /// <param name="llamada1"></param>
        /// <param name="llamada2"></param>
        /// <returns></returns>
        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            return llamada1.Duracion.CompareTo(llamada2.Duracion);
        }

        //Metodo de instancia
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Duracion de llamada: {this.Duracion}");
            sb.AppendLine($"Numero de Origen: {this.NroOrigen}");
            sb.AppendLine($"Numero de Destino: {this.NroDestino}");

            return sb.ToString(); 
        }



    }
}
