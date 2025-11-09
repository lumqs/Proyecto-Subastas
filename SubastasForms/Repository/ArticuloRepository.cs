using SubastasForms.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubastasForms.Repository
{
    public class ArticuloRepository
    {
        private readonly List<Articulo> articulos;
        public ArticuloRepository()
        {
            articulos = new List<Articulo>();
        }
        public List<Articulo> RetornarTodos()
        {
            return articulos;
        }
        public Articulo? RetornarPorId(int id)
        {
            foreach (Articulo a in articulos) 
            {
                if (a.Id == id) 
                    return a; 
            } 
            return null;
        }
        public void AgregarArticulo(Articulo a) 
        {
            articulos.Add(a); 
        }
        public void EliminarArticulo(int id)
        {
            Articulo? a = RetornarPorId((int)id);
            if (a != null)
            {
                articulos.Remove(a);
            }
        }
        public void ModificarArticulo(int id, Articulo a)
        {
            Articulo? articuloviejo = RetornarPorId(id);
            if (articuloviejo != null)
            {
            articuloviejo.Nombre = a.Nombre;
            articuloviejo.Descripcion = a.Descripcion;
            }

        }
    }
}
