using DataAccessLayer.IDALs;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DALs
{
    public class DAL_Personas : IDAL_Personas
    {
        private  List<Persona> personas = new List<Persona>();
        public List<Persona> GetPersonas()
        {
            return personas;
        }
        public List <Persona> GetPersonasOrdenados() { 
            return personas.OrderBy(p => p.FechaNacimiento).ToList();
            
        }

        public void Insert(Persona persona)
        {
            personas.Add(persona);
        }
    }
}
