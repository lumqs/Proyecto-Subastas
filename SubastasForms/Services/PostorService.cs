using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SubastasForms.Models.Entidades;
using SubastasForms.Repository;

namespace SubastasForms.Services
{
    internal class PostorService
    {
        private readonly PostorRepository repository;
        public PostorService()
        {
            repository = new PostorRepository();
        }

        public void AgregarPostor(Postor postor)
        {
            repository.AgregarPostor(postor);
        }
        public List<Postor> ObtenerTodos()
        {
            return repository.Postores;
        }
    }
}
