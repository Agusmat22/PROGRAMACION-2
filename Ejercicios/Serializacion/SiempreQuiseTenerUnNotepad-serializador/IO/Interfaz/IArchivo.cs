﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO.Interfaz
{
    public interface IArchivo <T>
    {
        public void Guardar(string ruta, T contenido);
        public void GuardarComo(string ruta, T contenido);

        public T Leer(string ruta);

    }
}
