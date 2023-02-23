using ChapterUC14.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChapterUC14.Controllers
{
    [Produces ("application/json")]//formato de resposta do tipo json.
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly LivroRepository _livroRepository;
        public LivroController(LivroRepository livro) 
        {
            _livroRepository = livro;
        }

        public IActionResult Listar()
        {
            try{
                return Ok(_livroRepository.Ler());
                
            }catch(Exception error){

                throw new Exception(error.Message);
            }
        }


    }
}
