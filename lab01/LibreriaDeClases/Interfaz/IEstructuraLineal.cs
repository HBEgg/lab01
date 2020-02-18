using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases.Interfaz
{
    interface IEstrucutraLineal<T>
    {
        void Insertar();
        void Eliminar();
        T Get();

    }
}
