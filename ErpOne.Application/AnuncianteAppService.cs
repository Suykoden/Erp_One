using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ErpOne.Application.Inteface;
using ErpOne.Domain.Entities;
using ErpOne.Domain.Interfaces.Services;

namespace ErpOne.Application
{
    public class AnuncianteAppService : AppServiceBase<Anunciante>, IAnuncianteAppService
    {
        private readonly IAnuncianteService _AnuncianteService;



        public AnuncianteAppService(IAnuncianteService AnuncianteService)
        : base(AnuncianteService)
        {
            _AnuncianteService = AnuncianteService;
        }


        ///Implementação especializada aqui
    }
}
