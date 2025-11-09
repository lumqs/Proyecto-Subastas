using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubastasForms.Models.Entidades
{
    public class Articulo
    {
        private static int ContadorId = 0;
        private int id;
        private string nombre;
        private string descripcion;
        private Subastador subastador;

        public Articulo(string nombre, string descripcion, Subastador subastador) 
        {
            id = ++ContadorId;
            Nombre = nombre;
            Descripcion = descripcion;
            this.subastador = subastador;
        }
        public int Id { get { return id; } }
        public string Nombre
        {
            get {return nombre;}
            set 
            { 
                if (!string.IsNullOrWhiteSpace(value))
                    nombre = value;
                else
                    throw new ArgumentException("El nombre no puede estar vacío.");
            }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public Subastador Subastador { get { return subastador; } }
    }
}
