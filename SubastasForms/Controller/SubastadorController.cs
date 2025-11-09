using SubastasForms.Models.Entidades;
using SubastasForms.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SubastasForms.Controller
{
    public class SubastadorController
    {
        private readonly SubastadorService service ;
        private readonly ArticuloController aController;
        private readonly SubastaController sController;

        //prueba
        public Usuario usuario { get; set; }
        public Subastador subastador { get; set; }
        public SubastadorController()
        {
            service = new SubastadorService();
            aController = new ArticuloController();
            sController = new SubastaController();

            //prueba
            this.usuario = new Usuario("lucas", "luumqs@", "lool");
            this.subastador = new Subastador(usuario);
        }

        public ArticuloController Acontroller 
        { 
            get
            { 
                return aController; 
            } 
        }
        public SubastaController Scontroller 
        { 
            get
            { 
                return sController; 
            } 
        }
        public List<Articulo> MostrarMisArticulos()
        {
            return aController.RetornarPorSubastador(subastador.RetornarEmail());
        }



        //prueba
        public void Hardcodear()
        {
            aController.CrearArticulo("Gibson", "nuevito", subastador);
            aController.CrearArticulo("Microfono", "casi nuevito", subastador);
            aController.CrearArticulo("sintetizer", "permutado por un 147", subastador);
        }
    }
}
