using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIExemplo.Models
{
    public class Clientes
    {
        public string Nome { get; set; }

        public Clientes(string nome)
        {
            Nome = nome;
        }
    }
}