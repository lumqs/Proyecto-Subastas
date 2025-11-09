using SubastasForms.Models.Entidades;
using SubastasForms.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubastasForms.Services
{
    public class UsuarioService
    {
        private readonly UsuarioRepository repository;

        public UsuarioService()
        {
            repository = new UsuarioRepository();
        }

        public bool CrearUsuario(Usuario usuario)
        {
            Usuario existente = repository.ObtenerPorEmail(usuario.Email);
            if (existente != null)
            {
                return false;
            }
            repository.AgregarUsuario(usuario);
            return true;
        }
        public List<Usuario> ObtenerUsuario()
        {
            return repository.ObtenerTodos();
        }
        public void ModificarUsuario(Usuario u)
        {
            Usuario usuario = repository.ObtenerPorEmail(u.Email);
            if (usuario != null)
            {
                usuario.Nombre = u.Nombre;
                usuario.Password = u.Password;
            }     
        }

        public void EliminarUsuario(string email)
        {
            Usuario usuario = repository.ObtenerPorEmail(email);
            if (usuario == null)
            {
                return;
            }
            repository.EliminarUsuario(usuario);
        }
    }
}
