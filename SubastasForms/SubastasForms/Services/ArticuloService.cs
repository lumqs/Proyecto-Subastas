using SubastasForms.Models.Entidades;
using SubastasForms.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubastasForms.Services
{
    public class ArticuloService
    {
        private readonly ArticuloRepository repository;
        public ArticuloService()
        {
            repository = new ArticuloRepository();
        }
        public List<Articulo> RetornarPorSubastador(string email)
        {
            List<Articulo> lista = new List<Articulo>();

            foreach (Articulo a in repository.RetornarTodos())
            {
                if (a.Subastador.RetornarEmail() == email)
                {
                    lista.Add(a);
                }
            }
            return lista;
        }
        public void CrearArticulo(Articulo a)
        {
            repository.AgregarArticulo(a);
        }
        public void EliminarArticulo(int id)
        { 
            repository.EliminarArticulo(id);
        }
        public void ModificarArticulo(int id, Articulo a)
        {
            repository.ModificarArticulo(id,a);
        }

    }
}
