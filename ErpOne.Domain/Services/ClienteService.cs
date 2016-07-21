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
    public class ClienteService: ServiceBase<Cliente>, IClienteService
    {
        private IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
            :base(clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }


        ///Aqui implementa as rotinas de banco
    }
}
