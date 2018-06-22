using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio.Models
{
    public class Apartamento : Inmueble
    {
        #region Propiedades
        public int NroPiso { get; set; }
        public bool Porteria { get; set; }
        public int TotalPisos { get; set; }
        public int GastosComunes { get; set; }
        
        #endregion

        
    }
}
