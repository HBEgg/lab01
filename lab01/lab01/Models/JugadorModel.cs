using lab01.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab01.Models
{
    public class JugadorModel
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Posicion { get; set; }
        public int Salario { get; set; }
        public string Club { get; set; }

        public bool Save()
        {
            try
            {
                Storage.Instancia.jugadorLista.Add(this);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}