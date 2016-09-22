using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ErpOne.Domain.Interfaces.Services;
using ErpOne.Domain.Entities;
using ErpOne.Domain.Interfaces.Repositories;

namespace ErpOne.Domain.Services
{
   public  class AnuncianteService: ServiceBase<Anunciante>, IAnuncianteService
    {
        private IAnuncianteRepository _AnuncianteRepository;

        public AnuncianteService(IAnuncianteRepository AnuncianteRepository)
            :base(AnuncianteRepository)
        {
            _AnuncianteRepository = AnuncianteRepository;
        }
    }
}
