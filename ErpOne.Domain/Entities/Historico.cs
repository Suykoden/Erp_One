using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ErpOne.Domain.EntitiesBase;

namespace ErpOne.Domain.Entities
{
    public class Historico: EntityBase
    {
        public DateTime Data_Consulta { get; set; }

        public Guid EventoID { get; set; }
        public Evento evento { get; set; }
    }
}
