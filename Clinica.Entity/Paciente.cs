namespace Clinica.Entity
{
    public class Paciente
    {
       public int PacienteId { get; set; }
        public string Name{get;set;}

        public string LastName_Maternal {get;set;}

        public string LastName_Paternal {get;set;}

        public string Email{get;set;}

        public string Phone{get;set;}

        public string dni { get; set; }

        public string Age{get;set;}

         
        public string Genger{get;set;}


        public Usuario Usuario{get;set;}

        public int UsuarioId{get;set;}


       public string Country{get;set;} 

       public string City{get;set;}

       public string Distrito{get;set;}

      public string Address{get;set;}

        
      public System.DateTime BornDate { get; set; }

    }
}