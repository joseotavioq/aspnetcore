using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebAPIApplication.Controllers
{
    [Route("api/[controller]")]
    public class PessoasController : Controller
    {
        private readonly DataContext _dataContext;

        public PessoasController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        public async Task<IActionResult> ObterPessoas()
        {
            var pessoas = await _dataContext.Pessoas.ToListAsync();
            return Json(pessoas);
        }

        [HttpPost]
        public async Task<IActionResult> CriarPessoa([FromBody]Pessoa pessoa)
        {
            await _dataContext.Pessoas.AddAsync(pessoa);
            await _dataContext.SaveChangesAsync();

            return Json(pessoa);
        }
    }
}