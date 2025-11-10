using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SubastasForms.Models.Entidades;

namespace SubastasForms.Repository
{
    internal class PostorRepository
    {
        private readonly List<Postor> postores;

        public PostorRepository()
        {
            postores = new List<Postor>();
        }

        public List<Postor> Postores { get { return postores; } }

        public void AgregarPostor(Postor postor)
        {
            postores.Add(postor);
        }
    }
}
