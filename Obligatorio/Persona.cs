using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio.Models
{
    public abstract class Persona
    {
        #region Propiedades
        public String CI { get; set; }
        public String Nombre { get; set; }        
        public String Correo { get; set; }
        public Int32 Telefono { get; set; }
        #endregion
        public Persona(String ci, String nombre, String correo, Int32 telefono)
        {
            CI = ci;
            Nombre = nombre;
            Correo = correo;
            Telefono = telefono;
        }
    }
}
