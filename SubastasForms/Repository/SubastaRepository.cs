using SubastasForms.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SubastasForms.Repository
{
    public class SubastaRepository
    {
        private readonly List<Subasta> subastas;

        public SubastaRepository()
        {
            subastas = new List<Subasta>();
        }
        public List<Subasta> Subastas { get { return subastas; } }

        public void CrearSubasta(Subasta s)
        {
            subastas.Add(s);
        }
        public Subasta? RetornarSubastaPorId(int id)
        {
            foreach (Subasta s in subastas)
            {
                if (s.Id == id)
                {
                    return s;
                }
            }
            return null;
        }
        public void EliminarSubasta(int id)
        {
            Subasta? subasta = RetornarSubastaPorId(id);
            if (subasta != null)
            {
                subastas.Remove(subasta);
            }
        }
        public List<Subasta> RetornarTodos()
        {
            return subastas;
        }
        public void ActualizarGanador(Postor p, Subasta s)
        {
            Subasta? subasta = RetornarSubastaPorId(s.Id);
            if (subasta != null)
            {
                subasta.ListaPostores.Add(p);
            }
        }
    }
}
