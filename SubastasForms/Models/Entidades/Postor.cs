using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SubastasForms.Models.Estaticas;


namespace SubastasForms.Models.Entidades
{
    public class Postor
    {
        private static int ContadorId = 0;
        private int id;
        private Usuario usuario;
        private List<string> notificaciones = new();

        public Postor(Usuario usuario)
        {
            id = ++ContadorId;
            this.usuario = usuario;
        }
        public List<string> Notificaciones { get { return notificaciones; } }
        public int Id { get{ return id; } }
    }
}
