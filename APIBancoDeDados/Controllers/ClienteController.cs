using APIBancoDeDados.Database;
using APIBancoDeDados.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIBancoDeDados.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        [HttpGet("ObterTodosClientes")]
        public List<ClienteModel> get()
        {
            return new ClienteDB().ObterTodosClientes();
        }
        [HttpGet("ObterDadosCliente")]
        public ClienteModel get([FromQuery] string cpf)
        {
            return new ClienteDB().ObterDadosCliente(cpf);
        }
        [HttpPost()]
        public void Post([FromBody] ClienteModel cli)
        {
            new ClienteDB().Inserir(cli);
        }
        [HttpPut]
        public void put([FromBody] ClienteModel c)
        {
            new ClienteDB().Alterar(c);
        }

        [HttpDelete]
        public void delete( string cpf)
        {
             new ClienteDB().DeletarCliente(cpf);
        }




    }
}
