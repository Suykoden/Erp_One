using ErpOne.Application.Inteface;
using ErpOne.Domain.Entities;
using ErpOne.Domain.Interfaces.Services;

namespace ErpOne.Application
{
    public  class ClienteAppService: AppServiceBase<Cliente>, IClienteAppService
    {
        private readonly IClienteService _clienteService;



        public ClienteAppService(IClienteService clienteService)
        :base(clienteService)
        {
            _clienteService = clienteService;
        }


        ///Implementação especializada aqui
    }
}
