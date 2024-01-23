using Olx.Domain.Entities;
using System.Linq.Expressions;

namespace Olx.Service.IServices
{
    public interface IUserService
    {
        IQueryable<User> GetAllSort(Expression<Func<User, bool>> expression, string[] includes = null);
        IQueryable<User> GetAll(Expression<Func<User, bool>> expression, string[] includes = null);
        ValueTask<User> GetAsync(Expression<Func<User, bool>> expression, string[] includes = null);
        ValueTask<User> CreateAsync(User entity);
        ValueTask<bool> DeleteAsync(Expression<Func<User, bool>> expression);
        User Update( User entity);
    }
}
