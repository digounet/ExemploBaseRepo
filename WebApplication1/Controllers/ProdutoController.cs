using Microsoft.AspNetCore.Mvc;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        [HttpGet]
        public IActionResult GetProdutos()
        {
            return Ok(_produtoRepository.GetAll());
        }

        [HttpPost]
        public IActionResult Save([FromBody]Produto produto) {
            _produtoRepository.Save(produto);
            return Ok();
        }
    }
}
