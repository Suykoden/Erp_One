using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ErpOne.Domain.EntitiesBase;

namespace ErpOne.Domain.Entities
{
    public class Fotos : EntityBase
    {
        public string Caminho { get; set; }
        public Guid EventoID { get; set; }
        public Evento evento { get; set; }
    }
}
