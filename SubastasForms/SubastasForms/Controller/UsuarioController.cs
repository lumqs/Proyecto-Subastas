using SubastasForms.Models.Entidades;
using SubastasForms.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubastasForms.Controller
{
    public class UsuarioController
    {
        private readonly UsuarioService service;
        private readonly PostorController pController;
        private readonly SubastadorController SController;

        public UsuarioController()
        {
            service = new UsuarioService();
            pController = new PostorController();
            SController = new SubastadorController();
        }
        public bool AgregarUsuario(string nombre, string email, string password)
        {
            return service.CrearUsuario(new Usuario(nombre, email, password));
        }
        public List<Usuario> ObtenerUsuario()
        {
            return service.ObtenerUsuario();
        }
        public void ModificarUsuario(Usuario u)
        {
            service.ModificarUsuario(u);
        }
        public void EliminarUsuario(string email)
        {
            service.EliminarUsuario(email);
        }
    }
}
