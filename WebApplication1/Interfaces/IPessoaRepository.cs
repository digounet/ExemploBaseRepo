using WebApplication1.Models;

namespace WebApplication1.Interfaces
{
    public interface IPessoaRepository : IRepository<Pessoa>
    {
        List<Produto> GetByName(string name);
    }
}
