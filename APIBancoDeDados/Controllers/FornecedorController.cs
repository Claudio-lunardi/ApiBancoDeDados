using APIBancoDeDados.Database;
using APIBancoDeDados.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIBancoDeDados.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FornecedorController : ControllerBase
    {
        [HttpGet("ObterTodosFornecedores")]
        public List<FornecedorModel> get()
        {
            return new FornecedorDB().ObterTodosFornecedor();
        }
        [HttpGet("ObterDadosFornecedor")]
        public FornecedorModel get([FromQuery] string cnpj)
        {
            return new FornecedorDB().ObterDadosFornecedor(cnpj);
        }
        [HttpPost()]
        public void post([FromBody] FornecedorModel cli)
        {
            new FornecedorDB().Inserir(cli);
        }
        [HttpPut()]
        public void Put([FromBody] FornecedorModel c)
        {
            new FornecedorDB().Alterar(c);
        }

        [HttpDelete]
        public void Delete(string cnpj)
        {
            new FornecedorDB().deletar(cnpj);
         
        }





    }
}
