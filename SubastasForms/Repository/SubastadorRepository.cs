using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SubastasForms.Models.Entidades;

namespace SubastasForms.Repository
{
    internal class SubastadorRepository
    {
        private readonly List<Subastador> subastadores;

        public SubastadorRepository()
        {
            subastadores = new List<Subastador>();
        }

        public List<Subastador> ObtenerTodos()
        {
            return subastadores;
        }

        public Subastador ObtenerPorId(int id)
        {
            foreach (Subastador subastador in subastadores)
            {
                if (subastador.Id == id)
                {
                    return subastador;
                }
            }
            return null;
        }

        public void AgregarSubastador(Subastador subastador)
        {
            subastadores.Add(subastador);
        }

        public void EliminarSubastador(Subastador subastador)
        {
            subastadores.Remove(subastador);
        }
    }
}
