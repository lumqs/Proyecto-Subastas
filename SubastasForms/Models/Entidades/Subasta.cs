using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubastasForms.Models.Entidades
{
    public class Subasta
    {
        private static int _contadorId = 0;
        private int id {  get; set; }
        private Articulo articulo;
        private Subastador subastador;
        private decimal pujaInicial;
        private decimal pujaAumento;
        private List<Postor> listaPostores = new List<Postor>();
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private int duracionTotal;

        public Subasta
            (
                Articulo articuloExistente,
                Subastador subastador,
                decimal pujaInicial,
                decimal pujaAumento,
                DateTime fechaInicio,
                int duracionTotal
            )
        {
            id = ++_contadorId;
            Articulo = articuloExistente;
            Subastador = subastador;
            PujaInicial = pujaInicial;
            PujaAumento = pujaAumento;
            FechaInicio = fechaInicio;
            DuracionTotal = duracionTotal;
            fechaFin = FechaInicio.AddMinutes(DuracionTotal);
        }
        public int Id { get { return id; } }
        public Articulo Articulo { get;}
        public Subastador Subastador { get;}
        public decimal PujaInicial
        {
            get {  return pujaInicial; }
            private set
            {
                if (value > 100 && value <1000000)
                {
                    pujaInicial = value;
                }
                else
                {
                    throw new ArgumentException("El valor de la puja debe ser entre 100 y 1000000.");
                }
            }
        }
        public decimal PujaAumento
        {
            get { return pujaAumento; }
            private set
            {
                if (value > 100 && value < 1000000)
                {
                    pujaAumento = value;
                }
                else
                {
                    throw new ArgumentException("El valor de la puja de aumento debe ser entre 100 y 1000000");
                }
            }
        }
        public List<Postor> ListaPostores { get { return listaPostores; } }
        public DateTime FechaInicio 
        {
            get { return fechaInicio; }
            private set
            {
                DateTime ahora = DateTime.Now;
                DateTime maximoDias = ahora.AddDays(7).Date.AddHours(23).AddMinutes(59).AddSeconds(59);
                if (value >= ahora && value < maximoDias)
                {
                   fechaInicio = value; 
                }
                else
                {
                    throw new ArgumentException("La fecha de inicio no puede ser una fecha pasada o con más de 7 días de anticipación.");
                }
            }
        }
        public int DuracionTotal
        { 
            get { return duracionTotal; } 
            private set
            {
                if (value > 30 && value <= 420)
                {
                    duracionTotal = value;
                }
                else 
                {
                    throw new ArgumentException("La duración debe ser entre 30 y 420 minutos");
                }
            }
        }
        public DateTime FechaFin 
        { 
            get 
            {
                return fechaFin;
            }
        }

    }
}
