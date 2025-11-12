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

        public List<Postor> ObtenerTodos()
        {
            return postores;
        }

        public Postor ObtenerPorId(int id)
        {
            foreach (Postor postor in postores)
            {
                if (postor.Id == id)
                {
                    return postor;
                }
            }
            return null;
        }

        public void AgregarPostor(Postor postor)
        {
            postores.Add(postor);
        }

        public void EliminarPostor(Postor postor)
        {
            postores.Remove(postor);
        }
    }
}
