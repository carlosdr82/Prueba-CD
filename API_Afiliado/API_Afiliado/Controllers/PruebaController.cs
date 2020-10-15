using Blo;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static Blo.ClienteBlo;

namespace API_Afiliado.Controllers
{
    public class PruebaController : ApiController
    {
        // GET api/Prueba
        public List<CLIENTE> Get()
        {
            ClienteBlo clienteBlo = new ClienteBlo();
            return clienteBlo.GetAll();
        }

        // GET api/Prueba/5
        public CLIENTE Get(int id)
        {
            ClienteBlo clienteBlo = new ClienteBlo();
            return clienteBlo.GetById(id);
        }

        // POST api/Prueba
        public void Post(CLIENTE cliente)
        {

            ClienteBlo clienteBlo = new ClienteBlo();
            clienteBlo.Insert(cliente);
        }

        // PUT api/Prueba
        public void Put(CLIENTE data)
        {
            ClienteBlo clienteBlo = new ClienteBlo();

            CLIENTE cliente = clienteBlo.GetById(data.ID);
            cliente.CORREO = data.CORREO;
            clienteBlo.Update(cliente);
        }

        // DELETE api/Prueba/5
        public void Delete(int id)
        {
            ClienteBlo clienteBlo = new ClienteBlo();
            clienteBlo.Delete(id);
        }
    }
}
