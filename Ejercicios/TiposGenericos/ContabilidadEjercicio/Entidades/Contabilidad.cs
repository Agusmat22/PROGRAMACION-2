﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Contabilidad<T,U> where T : Documento where U : Documento, new()
    {
        private List<T> egresos;
        private List<U> ingresos;

        public Contabilidad()
        {
            this.egresos = new List<T>();
            this.ingresos = new List<U>();
        }

        public List<T> Egresos { get => egresos; set => egresos = value; }
        public List<U> Ingresos { get => ingresos; set => ingresos = value; }

        public static Contabilidad<T,U> operator +(Contabilidad<T, U> c, T egreso)
        {
            c.egresos.Add(egreso);

            return c;

        }

        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, U ingreso)
        {
            c.ingresos.Add(ingreso);

            return c;
        }

    }
}
