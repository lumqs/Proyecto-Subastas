using SubastasForms.Models.Entidades;
using SubastasForms.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubastasForms.Controller
{
    public class ArticuloController
    {
        private readonly ArticuloService service;

        public ArticuloController()
        {
            service = new ArticuloService();
        }
        public List<Articulo>RetornarPorSubastador(string email)
        {
            return service.RetornarPorSubastador(email);
        }
        public void CrearArticulo(string nombre, string descripcion, Subastador subastador)
        {
            service.CrearArticulo(new Articulo(nombre, descripcion, subastador));
        }
        public void EliminarArticulo(int id)
        {
            service.EliminarArticulo(id);
        }
        public void ModificarArticulo(int idArticulo, string nombre, string descripcion, Subastador subastador)
        {
            service.ModificarArticulo( idArticulo, new Articulo(nombre, descripcion, subastador) );
        }
    }
}
