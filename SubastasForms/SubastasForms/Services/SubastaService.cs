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
        //crearSubasta

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
        public bool EliminarSubasta(int id)
        {
            Subasta? s = repository.RetornarSubastaPorId(id);
            if (s != null)
            {
                if (DateTime.Now >= s.FechaInicio && DateTime.Now <= s.FechaInicio.AddMinutes(s.DuracionTotal))
                    return false; // está en vivo, no se puede eliminar
                repository.EliminarSubasta(id);
                return true;
            }
            else
            {
                return false;
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


/* ejemplo para reveer
 public bool EliminarSubasta(int id)
{
    Subasta subasta = repository.ObtenerPorId(id);
    if (subasta == null)
        return false;

    // Lógica de negocio opcional
    if (subasta.EstaActiva)
        return false;

    return repository.EliminarSubasta(id);
}

 */
