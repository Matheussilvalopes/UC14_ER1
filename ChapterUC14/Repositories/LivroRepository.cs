using ChapterUC14.Contexts;
using ChapterUC14.Interfaces;
using ChapterUC14.Models;

namespace ChapterUC14.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        private readonly ChapterContext _chapterContext;
        public LivroRepository(ChapterContext context)
        {
            _chapterContext = context;  
        }

        public List<Livro> Ler()
        {
            return _chapterContext.Livros.ToList();
        }
    }
}
