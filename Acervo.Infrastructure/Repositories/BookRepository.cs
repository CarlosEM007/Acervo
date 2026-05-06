using Acervo.Domain.Common;
using Acervo.Domain.Entities;
using Acervo.Domain.Interfaces;
using Acervo.Infrastructure.Data;

namespace Acervo.Infrastructure.Repositories
{
    public class BookRepository: IBookRepository
    {
        private readonly AppDbContext _context;

        public BookRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Result> Delete(long Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Book>> GetAllBook()
        {
            throw new NotImplementedException();
        }

        public async Task<Result<Book>> GetById(long Id)
        {
            throw new NotImplementedException();
        }

        public async Task<Result> Insert(Book Entity)
        {
            throw new NotImplementedException();
        }

        public async Task<Result> Update(Book Entity)
        {
            throw new NotImplementedException();
        }
    }
}
