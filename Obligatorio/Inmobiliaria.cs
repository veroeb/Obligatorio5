using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio.Models
{
    class Inmobiliaria
    {
        #region Propiedades

        private List<Inmueble> Inmuebles;
        private List<Propietario> Owners;
        private List<Comprador> Buyers;
        private List<String> Listado;
        private List<String> FichaCompradores;
        private List<String> FichaPropietarios;
        public String FechaVisita { get; set; }
        public Comprador Buyer { get; set; }
        public Inmueble Inmueble { get; set; }
        public ManejadorDeArchivos Archivo { get; set; }

        #endregion

        #region Singleton
        public static Inmobiliaria Instancia = null;
        public static Inmobiliaria GetInmobiliaria()
        {
            if (Instancia == null)
            {
                Instancia = new Inmobiliaria();
            }

            return Instancia;
        }
        #endregion

        ManejadorDeArchivos manejadorDeArchivos = new ManejadorDeArchivos();
        ManejadorArchivosImagenes ManejadorArchivosImagenes = new ManejadorArchivosImagenes();

        public Inmobiliaria()
        {
            Inmuebles = new List<Inmueble>();
            Owners = new List<Propietario>();
            Buyers = new List<Comprador>();
            Listado = new List<String>();
            //Las listas fichacomprador y fichapropietarios van a ser las que se impriman en el archivo.
            FichaCompradores = new List<string>();
            FichaPropietarios = new List<string>();
        }

        public virtual String VenderAlquilar(Inmueble inmueble, Comprador comprador)
        {
            this.Inmuebles.Remove(inmueble);
            return ("Ahora esta propiedad es de: " + comprador.Nombre);
        }

        public void VisitarPropiedad(String fechaVisita, Inmueble inmueble, String comentarios,Comprador comprador)
        {
            FichaCompradores.Add(comprador.FichaComprador());
            String FechaVisita = fechaVisita;
            String Comentarios = comentarios;
            this.Inmueble.Comentarios.Add(Comentarios);
        }
        
        public void AgregarPropiedad(Inmueble InmuebleaAgregar)
        {
            Inmuebles.Add(InmuebleaAgregar);
            AgregarPropiedadArchivo();
            //Agregar la propiedad al archivo. manejadorDeArchivos.Escribir();            
        }

        public void AgregarPropiedadArchivo()
        {
            foreach(Inmueble i in Inmuebles)
            {
                manejadorDeArchivos.Escribir("propiedades.txt", i.Barrio + i.AñoConstruccion);
            }
        }

        public void AgregarPropietario(Propietario propietario)
        {
            Owners.Add(propietario);
        }
        public void AgregarComprador(Comprador comprador)
        {
            Buyers.Add(comprador);
        }

    }
}
