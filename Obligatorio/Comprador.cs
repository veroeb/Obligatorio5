using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio.Models
{
    public class Comprador : Persona
    {
        private List<Inmueble> PropiedadesVisitadas;
        public Comprador(String nombre, String ci, String correo, Int32 telefono) : base(ci, nombre, correo, telefono)
        {
            Nombre = nombre;
            CI = ci;
            Correo = correo;
            Telefono = telefono;
            PropiedadesVisitadas = new List<Inmueble>();
        }
        public String FichaComprador()
        {
            return($"{Nombre}, {CI}, {Correo}, {Telefono}.");
        }   
    }
}
