using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ErpOne.Domain.Entities;
using ErpOne.Domain.EntitiesBase;


namespace ErpOne.Domain.Entities
{
    public class Evento : EntityWithCodeAndName
    {
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Cep { get; set; }
        public DateTime Data_Evento { get; set; }
        public string Descricao { get; set; }
        public Boolean Ativo { get; set; }
        public Guid AnuncianteId { get; set; }
        public Anunciante anunciante { get; set; }
    }
}

