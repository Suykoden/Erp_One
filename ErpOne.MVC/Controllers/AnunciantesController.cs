using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ErpOne.Domain.Entities;
using ErpOne.Domain.Services;
using ErpOne.Domain.Interfaces.Services;
using ErpOne.Application.Inteface;

namespace ErpOne.MVC.Controllers
{
    public class AnunciantesController : ApiController
    {

        private IAnuncianteAppService _AnuncianteService { get; set; }


        public AnunciantesController(IAnuncianteAppService AnuncianteService)
        {
            _AnuncianteService = AnuncianteService;
        }
        // GET: api/Anunciantes
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Anunciantes/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Anunciantes
        public void Post([FromBody]Anunciante anunciante)
        {
            _AnuncianteService.Add(anunciante);
        }

        // PUT: api/Anunciantes/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Anunciantes/5
        public void Delete(int id)
        {
        }
    }
}
