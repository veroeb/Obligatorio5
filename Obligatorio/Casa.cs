using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio.Models
{
    public class Casa : Inmueble
    {
        #region Propiedades
        public bool Jardin { get; set; }
        public bool Patio { get; set; }

        #endregion

    }
}
