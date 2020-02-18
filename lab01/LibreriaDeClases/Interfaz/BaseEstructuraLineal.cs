using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases.Interfaz
{
    public abstract class BaseEstructuraLineal<T>
    {
        protected abstract void Insertar(T valor);
        protected abstract void Eliminar();
        protected abstract T Get();

    }
}

