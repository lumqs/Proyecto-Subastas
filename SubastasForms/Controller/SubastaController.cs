using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SubastasForms.Models.Entidades;
using SubastasForms.Services;

namespace SubastasForms.Controller
{
    public class SubastaController
    {
        private readonly SubastaService service; 

        public SubastaController()
        {
            service = new SubastaService();
        }
        public List<Subasta> RetornarPorSubastador(string email)
        {
            return service.RetornarPorSubastador(email);
        }
        public List<Subasta> ObtenerSubastasEnVivo()
        {
            return service.SubastasEnVivo();
        }

        public void EliminarSubasta(int id)
        {
            service.EliminarSubasta(id);
        }
        public void GanadorActual(Postor p, Subasta s)
        {
            service.GanadorActual(p, s);
        }
        public TimeSpan TiempoRestante(Subasta s)
        {
            service.TiempoRestante(s);
        }
    }
}
