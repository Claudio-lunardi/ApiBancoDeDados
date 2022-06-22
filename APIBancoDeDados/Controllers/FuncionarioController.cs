using APIBancoDeDados.Database;
using APIBancoDeDados.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIBancoDeDados.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        [HttpGet("ObterTodosFuncionarios")]
        public List<FuncionarioModel> get()
        {
            return new FuncionarioDB().ObterTodosFuncionarios();

        }
        [HttpGet("ObterDadosFuncionario")]
        public FuncionarioModel get([FromQuery] string cpf)
        {
            return new FuncionarioDB().ObterDadosFuncionario(cpf);
        }
        [HttpPost()]
        public void post([FromBody]  FuncionarioModel Dados)
        {
            new FuncionarioDB().Inserir(Dados);
        }
        [HttpPut()]
        public void put([FromBody]  FuncionarioModel Dados)
        {
            new FuncionarioDB().Alterar(Dados);
        }
        
        [HttpDelete]
        public void Delete(string cpf)
        {
            new FuncionarioDB().deletarFuncionario(cpf);
        }



    }
}
