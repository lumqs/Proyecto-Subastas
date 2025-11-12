using SubastasForms.Models.Entidades;
using SubastasForms.Repository;
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

<<<<<<< HEAD
        public void AgregarSubastador(Subastador subastador)
        {
            repository.AgregarSubastador(subastador);
        }
        public List<Subastador> ObtenerTodos()
        {
            return repository.ObtenerTodos();
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
=======
        public bool CrearSubastador(Subastador s)
        {
            if ( repository.ObtenerPorEmail( s.RetornarEmail() ) != null)
            {
                return false;
            }
            repository.AgregarSubastador(s);
            return true;
        }
        public bool ExisteSubastador(string email)
        {
            foreach (Subastador sub in repository.RetornarTodos())
            {
                if (sub.RetornarEmail() == email)
                {
                    return true;
                }
            }
            return false;
        }
        public void EliminarSubastador(string email)
        {
            repository.EliminarSubastador(email);
        }

>>>>>>> 2626e29ecccad085d0ac75dfcb3370e923fbf7d3
    }
}
