using ErpOne.Domain.EntitiesBase;
using System;

namespace ErpOne.Domain.Entities
{
    public class Anunciante 
    {
        public Guid id { get; set; }
        public string Email { get; set; }
  //      public DateTime Data_Cadastro { get; set; }
        public string Senha { get; set; }
        public Boolean Ativo { get; set; }


    }
}
