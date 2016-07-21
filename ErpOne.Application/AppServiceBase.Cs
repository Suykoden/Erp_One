using ErpOne.Application.Inteface;
using ErpOne.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace ErpOne.Application
{
    public class AppServiceBase<Tentity> : IDisposable, IAppServiceBase<Tentity> where Tentity : class

    {
        private readonly IServicoBase<Tentity> _servicoBase;

        public AppServiceBase(IServicoBase<Tentity> servicoBase)
        {
            _servicoBase = servicoBase;
        }
        public void Dispose()
        {
            _servicoBase.Dispose();
        }

        void IAppServiceBase<Tentity>.Add(Tentity obj)
        {
            _servicoBase.Add(obj);
        }

        IEnumerable<Tentity> IAppServiceBase<Tentity>.GetAll()
        {
            return _servicoBase.GetAll();
        }

        Tentity IAppServiceBase<Tentity>.GetById(int id)
        {
            return _servicoBase.GetById(id);
        }

        void IAppServiceBase<Tentity>.Remove(Tentity obj)
        {
            _servicoBase.Remove(obj);
        }

        void IAppServiceBase<Tentity>.Update(Tentity obj)
        {
            _servicoBase.Update(obj);
        }
    }
}
