using Microsoft.AspNetCore.Mvc;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PessoaController : Controller
    {
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaController(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        [HttpGet]
        public IActionResult GetPessoas()
        {
            return Ok(_pessoaRepository.GetAll());
        }

        [HttpPost]
        public IActionResult Save([FromBody]Pessoa pessoa) {
            _pessoaRepository.Save(pessoa);
            return Ok();
        }
    }
}
