using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SubastasForms.Models.Entidades;
using SubastasForms.Repository;

namespace SubastasForms.Services
{
    internal class SubastadorService
    {
        private readonly SubastadorRepository repository;

        public SubastadorService()
        {
            repository = new SubastadorRepository();
        }

        public void AgregarSubastador(Subastador subastador)
        {
            repository.AgregarSubastador(subastador);
        }
        public List<Subastador> ObtenerTodos()
        {
            return repository.Subastadores;
        }

        public void EliminarSubastador(int id)
        {
            Subastador subastador = repository.ObtenerPorId(id);
            if (subastador == null)
            {
                return;
            }
            repository.EliminarSubastador(subastador);
        }
    }
}
