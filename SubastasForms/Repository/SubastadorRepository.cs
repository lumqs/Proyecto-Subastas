<<<<<<< HEAD
﻿using System;
=======
﻿using SubastasForms.Models.Entidades;
using System;
>>>>>>> 2626e29ecccad085d0ac75dfcb3370e923fbf7d3
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
using SubastasForms.Models.Entidades;
=======
>>>>>>> 2626e29ecccad085d0ac75dfcb3370e923fbf7d3

namespace SubastasForms.Repository
{
    internal class SubastadorRepository
    {
<<<<<<< HEAD
        private readonly List<Subastador> subastadores;

        public SubastadorRepository()
        {
            subastadores = new List<Subastador>();
        }

        public List<Subastador> ObtenerTodos()
        {
            return subastadores;
        }

        public Subastador ObtenerPorId(int id)
        {
            foreach (Subastador subastador in subastadores)
            {
                if (subastador.Id == id)
                {
                    return subastador;
=======
        private List<Subastador> subastadores;
        public SubastadorRepository() 
        { 
            subastadores = new List<Subastador>();
        }
        public void AgregarSubastador(Subastador s)
        {
            subastadores.Add(s);
        }
        public List<Subastador> RetornarTodos()
        {
            return subastadores;
        }
        public Subastador? ObtenerPorEmail(string email)
        {
            foreach (Subastador s in subastadores) 
            {
                if (s.RetornarEmail() == email)
                {
                    return s;
>>>>>>> 2626e29ecccad085d0ac75dfcb3370e923fbf7d3
                }
            }
            return null;
        }
<<<<<<< HEAD

        public void AgregarSubastador(Subastador subastador)
        {
            subastadores.Add(subastador);
        }

        public void EliminarSubastador(Subastador subastador)
        {
            subastadores.Remove(subastador);
=======
        public void EliminarSubastador(string email)
        {
            Subastador? sub = ObtenerPorEmail(email);
            if (sub != null) 
            { 
                subastadores.Remove(sub);
            }
>>>>>>> 2626e29ecccad085d0ac75dfcb3370e923fbf7d3
        }
    }
}
