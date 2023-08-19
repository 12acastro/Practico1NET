using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.IDALs
{
    public interface IDAL_Personas
    {
        public void Insert(Persona persona);
        public List<Persona> GetPersonas();
        public List<Persona> GetPersonasOrdenados();
    }
}
