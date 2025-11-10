using SubastasForms.Models.Entidades;
using SubastasForms.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubastasForms.Services
{
    public class SubastaService
    {
        private readonly SubastaRepository repository;
        public SubastaService()
        {
            repository = new SubastaRepository();
        }

        public void CrearSubasta(Subasta s)
        {
            repository.CrearSubasta(s);
        }

        public List<Subasta> SubastasEnVivo()
        {
            DateTime ahora = DateTime.Now;
            List<Subasta> todas = repository.RetornarTodos();
            List<Subasta> enVivo = new List<Subasta>();

            foreach (var subasta in todas)
            {
                DateTime inicio = subasta.FechaInicio;
                DateTime fin = inicio.AddMinutes(subasta.DuracionTotal);

                if (ahora >= inicio && ahora <= fin)
                {
                    enVivo.Add(subasta);
                }
            }
            return enVivo;
        }
        public List<Subasta> RetornarPorSubastador(string email)
        {
            List<Subasta> lista = new List<Subasta>();
            foreach (Subasta s in repository.RetornarTodos())
            {
                if (s.Subastador.RetornarEmail() == email)
                {
                    lista.Add(s);
                }
            }
            return lista;
        }
        public void EliminarSubasta(int id)
        {
            Subasta? s = repository.RetornarSubastaPorId(id);
            if (s != null)
            {
                repository.EliminarSubasta(id);
            }
        }
        public void GanadorActual(Postor p, Subasta s)
        {
            repository.ActualizarGanador(p, s);
        }

        public TimeSpan TiempoRestante(Subasta s)
        {
           Subasta? subasta = repository.RetornarSubastaPorId(s.Id);
            DateTime ahora = DateTime.Now;
            if (subasta != null)
            {
                return subasta.FechaFin - ahora;
            }
            return TimeSpan.Zero;
        }
    }
}

