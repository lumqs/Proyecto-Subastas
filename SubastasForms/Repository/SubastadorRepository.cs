using SubastasForms.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubastasForms.Repository
{
    internal class SubastadorRepository
    {
        private List<Subastador> subastadores;
        public SubastadorRepository() 
        { 
            subastadores = new List<Subastador>();
        }
        public void AgregarSubastador(Subastador s)
        {
            subastadores.Add(s);
        }
        public List<Subastador> RetornarTodos()
        {
            return subastadores;
        }
        public Subastador? ObtenerPorEmail(string email)
        {
            foreach (Subastador s in subastadores) 
            {
                if (s.RetornarEmail() == email)
                {
                    return s;
                }
            }
            return null;
        }
        public void EliminarSubastador(string email)
        {
            Subastador? sub = ObtenerPorEmail(email);
            if (sub != null) 
            { 
                subastadores.Remove(sub);
            }
        }
    }
}
