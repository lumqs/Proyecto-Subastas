using SubastasForms.Models.Entidades;
using SubastasForms.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubastasForms.Services
{
    internal class SubastadorService
    {
        private readonly SubastadorRepository repository;

        public SubastadorService()
        {
            repository = new SubastadorRepository();
        }

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

    }
}
