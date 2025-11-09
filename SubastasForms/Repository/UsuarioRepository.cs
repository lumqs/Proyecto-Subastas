using SubastasForms.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubastasForms.Repository
{
    public class UsuarioRepository
    {
        private readonly List<Usuario> usuarios;

        public UsuarioRepository()
        {
            usuarios = new List<Usuario>();
        }
        public List<Usuario> ObtenerTodos()
        {
            return usuarios;
        }
        public Usuario ObtenerPorEmail(string email)
        {
            foreach(Usuario u in usuarios){
                if (u.Email == email)
                {
                    return u;
                }
            } 
            return null;
        }

        public void AgregarUsuario(Usuario usuario)
        {
            usuarios.Add(usuario);
        }
        public void EliminarUsuario(Usuario usuario)
        {
            usuarios.Remove(usuario);
        }
    }
}
