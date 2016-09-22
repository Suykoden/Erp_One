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

        private readonly IAnuncianteAppService _AnuncianteService;

        public AnunciantesController()
        {
            
            
        }
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
            Anunciante _anunciante = new Anunciante();

            //_anunicante = anunciante;
            _anunciante.Id = Guid.Parse("f39e7794-58de-423a-ab07-a2f3957a0855");
        //    _anunciante.Data_Cadastro = DateTime.Now;
            _anunciante.Ativo = true;
     //       _anunciante.Nome = "rafael";
            _anunciante.Senha = "123";
            _anunciante.Email = "dada";
            //      _anunciante.Codigo = "55555";

            _AnuncianteService.Add(_anunciante);
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
