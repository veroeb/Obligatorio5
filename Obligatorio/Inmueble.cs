using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio.Models
{
    public abstract class Inmueble
    {
        #region Propiedades
        public double Precio { get; set; }
        public int Habitaciones { get; set; }
        public int Dormitorios { get; set; }
        public int Baños { get; set; }
        public int AñoConstruccion { get; set; }
        public double MetrosCuadrados { get; set; }
        public string Departamento { get; set; }
        public string Ciudad { get; set; }
        public string Barrio { get; set; }
        public string EstadoFisico { get; set; }
        public int Garages { get; set; }
        public string Direccion { get; set; }
        public bool Parrillero { get; set; }      
        public Propietario Propietario { get; set; }
        public List<String> Comentarios { get; set; }
        
        #endregion
                
    }
}
