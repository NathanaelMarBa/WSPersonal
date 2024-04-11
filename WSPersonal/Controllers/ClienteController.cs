using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WSPersonal.Models;

namespace WSPersonal.Controllers
{
    public class ClienteController : ApiController
    {
        [ActionName("listar")]
        [HttpGet]
        public dynamic ListarCliente()
        {
            List<Cliente> clientes = new List<Cliente>
            {
                new Cliente
                {
                    id = "1",
                    correo = "kevinnathanaelm@gmail.com",
                    edad = "20",
                    nombre = "Nathanael Martinez"
                },
                new Cliente
                {
                    id = "2",
                    correo = "paty@gmail.com",
                    edad = "40",
                    nombre = "Patricia Barrera"
                }
            };
            return clientes;
        }
        [ActionName("guardar")]
        [HttpPost]
        public dynamic guardarCliente(Cliente cliente)
        {
            return new
            {
                success = true,
                message = "Cliente Registrado",
                result = cliente
            };
        }
    }
}
