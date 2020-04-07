using System.Collections.Generic;

namespace Clinica.Entity
{
    public class Usuario
    {
        
        public int UsuarioId{get;set;}

       
        public string UserName{get;set;}

        
        public string UserPassword{get;set;}

        public Rol Rol{get;set;}

        public int RolId{get;set;}
    }
}