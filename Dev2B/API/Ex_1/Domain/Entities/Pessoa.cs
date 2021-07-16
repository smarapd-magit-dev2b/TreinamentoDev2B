using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
 
    // Propriedades da Pessoa 
    
    public class Pessoa
    {  
        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public decimal Height { get; set; }

        public decimal Weight { get; set; }

        public string Race { get; set; }

        public bool Status { get; set; }
        
        public string Cpf { get; set; }


    }
}
