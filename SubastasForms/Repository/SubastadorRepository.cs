<<<<<<< HEAD
<<<<<<< HEAD
﻿using System;
=======
﻿using SubastasForms.Models.Entidades;
using System;
>>>>>>> 2626e29ecccad085d0ac75dfcb3370e923fbf7d3
=======
﻿using SubastasForms.Models.Entidades;
using System;
>>>>>>> 2626e29ecccad085d0ac75dfcb3370e923fbf7d3
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
<<<<<<< HEAD
using SubastasForms.Models.Entidades;
=======
>>>>>>> 2626e29ecccad085d0ac75dfcb3370e923fbf7d3
=======
>>>>>>> 2626e29ecccad085d0ac75dfcb3370e923fbf7d3

namespace SubastasForms.Repository
{
    internal class SubastadorRepository
    {
<<<<<<< HEAD
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
=======
>>>>>>> 2626e29ecccad085d0ac75dfcb3370e923fbf7d3
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
<<<<<<< HEAD
>>>>>>> 2626e29ecccad085d0ac75dfcb3370e923fbf7d3
=======
>>>>>>> 2626e29ecccad085d0ac75dfcb3370e923fbf7d3
                }
            }
            return null;
        }
<<<<<<< HEAD
<<<<<<< HEAD

        public void AgregarSubastador(Subastador subastador)
        {
            subastadores.Add(subastador);
        }

        public void EliminarSubastador(Subastador subastador)
        {
            subastadores.Remove(subastador);
=======
=======
>>>>>>> 2626e29ecccad085d0ac75dfcb3370e923fbf7d3
        public void EliminarSubastador(string email)
        {
            Subastador? sub = ObtenerPorEmail(email);
            if (sub != null) 
            { 
                subastadores.Remove(sub);
            }
<<<<<<< HEAD
>>>>>>> 2626e29ecccad085d0ac75dfcb3370e923fbf7d3
=======
>>>>>>> 2626e29ecccad085d0ac75dfcb3370e923fbf7d3
        }
    }
}
