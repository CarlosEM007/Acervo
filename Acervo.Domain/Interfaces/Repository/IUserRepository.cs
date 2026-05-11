using Acervo.Domain.Entities;

namespace Acervo.Domain.Interfaces.Repository
{
    public interface IUserRepository
    {
        Task<User> ObterPorEmailAsync(string email);
    }
}
