using SubastasForms.Models.Estaticas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubastasForms.Models.Entidades
{
    public class Usuario
    {
        private static int ContadorId = 0;
        private int Id;
        private string nombre;
        private string email;
        private string password;
        
        public Usuario (string nombre, string email, string password)
        {
            Id = ++ContadorId;
            Nombre = nombre;
            Email = email;
            Password = password;
        }
        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    nombre = value;
                else
                    throw new ArgumentException("El nombre no puede estar vacío.");
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    email = value;
                else
                    throw new ArgumentException("El email no puede estar vacío.");
            }
        }
        public string Password
        {
            get { return password; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    password = value;
                else
                    throw new ArgumentException("La contraseña no puede estar vacío.");
            }
        }
    }
}
