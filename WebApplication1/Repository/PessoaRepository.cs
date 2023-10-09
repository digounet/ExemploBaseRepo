using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class PessoaRepository : BaseRepository<Pessoa>, IPessoaRepository
    {
        public List<Produto> GetByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
