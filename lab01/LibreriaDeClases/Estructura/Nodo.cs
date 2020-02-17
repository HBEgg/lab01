﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases.Estructura
{
    class Nodo<T>
    {
        public Nodo<T> Siguiente { get; set; }
        public Nodo<T> Anterior { get; set; }
        public T Valor { get; set; }
    }
}
