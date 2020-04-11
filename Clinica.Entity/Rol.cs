using System.Collections.Generic;

namespace Clinica.Entity
{
    public class Rol
    {
        
        public int RolId{get;set;}

        
        public string RolDescription{get;set;}


        public List<Usuario> Usuarios{get;set;}
    }
}