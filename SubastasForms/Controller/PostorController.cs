using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SubastasForms.Models.Entidades;
using SubastasForms.Services;

namespace SubastasForms.Controller
{
    internal class PostorController
    {
        private readonly PostorService service;

        public PostorController()
        {
            service = new PostorService();
        }

        public void AgregarPostor(Usuario usuario)
        {
            Postor postor = new Postor(usuario);
            service.AgregarPostor(postor);
        }


        /*
        public void EliminarPostor()
        {
            service.EliminarPostor(this.postor.usuario.email);
        }*/
    }
}
