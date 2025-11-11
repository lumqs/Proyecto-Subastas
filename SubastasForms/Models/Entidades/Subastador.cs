using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SubastasForms.Models.Estaticas;

namespace SubastasForms.Models.Entidades
{
    public class Subastador
    {
        private static int ContadorId = 0;
        private int id;
        private Usuario usuario;
        private List<string> notificaciones = new();

        public Subastador (Usuario usuario)
        {
            id = ++ContadorId;
            this.usuario = usuario;
        }
        public int Id { get { return id; } }
        public List<string> Notificaciones { get { return notificaciones; } }

        public string RetornarEmail() 
        {
            return usuario.Email;
        }
    }
}
