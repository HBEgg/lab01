using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaDeClases.Interfaz;
using System.Collections;


namespace LibreriaDeClases.Estructura
{
    public class ListaDobleEnlazada<T> : BaseEstructuraLineal<T>, IEnumerable<T>
    {
        private Nodo<T> Nuevo { get; set; }
        
        public void Agregar(T valor)
        {
            Insertar(valor);
        }

        public T Quitar()
        {
            var valor = Get();
            Eliminar();
            return valor;
        }

        protected override void Insertar(T valor)
        {
            if (Nuevo == null)
            {
                Nuevo = new Nodo<T>
                {
                    Valor = valor,
                    Anterior = null,
                    Siguiente = null,
                };
            }
            else
            {
                var actual = Nuevo;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = new Nodo<T>
                {
                    Valor = valor,
                    Anterior = Nuevo,
                    Siguiente = null
                };
            }

        }

        protected override void Eliminar()
        {
           
        }

        protected override T Get()
        {
            return Nuevo.Valor;
        }


        public IEnumerator<T> GetEnumerator()
        {
            var ListaCopia = this;
            while (ListaCopia.Nuevo != null)
            {
                yield return ListaCopia.Quitar();
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
