using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIExemplo.Models;

namespace WebAPIExemplo.Controllers
{
    public class ClientesController : ApiController
    {
        private static List<Clientes> clientes = new List<Clientes>();

        [HttpGet]
        public List<Clientes> getClientes()
        {
            return clientes;
        }

        [HttpPost]
        public void insertCliente (string nome)
        {
            if(!string.IsNullOrEmpty(nome))
            {
                clientes.Add(new Clientes(nome));
            }
            
        }
        [HttpDelete]
        public void deleteClientes(string nome)
        {
            if (!string.IsNullOrEmpty(nome))
            {
                clientes.RemoveAt(clientes.IndexOf(clientes.First(x => x.Nome.Equals(nome))));
            }
        }
    }
}
