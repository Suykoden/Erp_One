using System;

namespace ErpOne.Domain.Entities
{
    public class Cliente
    {
        public string ClienteID { get; set; }
        public string Nome  { get; set; }
        public string SobreNome { get; set; }
        public string  Email { get; set; }
        public DateTime  DataCadastro { get; set; }
        public bool Ativo { get; set; }

        public bool ClienteEspecial(Cliente cliente)
        {
            return cliente.Ativo && DateTime.Now.Year - cliente.DataCadastro.Year > 5;
        }
    }
}
