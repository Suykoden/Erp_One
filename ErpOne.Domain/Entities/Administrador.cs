using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ErpOne.Domain.EntitiesBase;

namespace ErpOne.Domain.Entities
{
    public class Administrador: EntityWithCodeAndName
    {
        public string Senha { get; set; }
        public Boolean Ativo { get; set; }
    }
}
