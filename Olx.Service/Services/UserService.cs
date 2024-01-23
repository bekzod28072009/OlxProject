using Olx.Data.IRepositorys;
using Olx.Data.Repositorys;
using Olx.Domain.Entities;
using Olx.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Olx.Service.Services
{
    public class Userservice : IUserService
    {
        private readonly IGenericRepository<User> _repository;
        public Userservice()
        {
            _repository = new GenericRepository<User>();
        }

        public  async ValueTask<User> CreateAsync(User entity)
        {
            return await _repository.CreateAsync(entity);
            await _repository.SaveChangesAsync();
        }

        public ValueTask<bool> DeleteAsync(Expression<Func<User, bool>> expression)
        {
            return _repository.DeleteAsync(expression);
            _repository.SaveChangesAsync();
        }

        public  IQueryable<User> GetAll(Expression<Func<User, bool>> expression, string[] includes = null)
            =>  _repository.GetAll(expression,includes);

        public IQueryable<User> GetAllSort(Expression<Func<User, bool>> expression, string[] includes = null)
         => _repository.GetAll(expression, includes);

       

        public async ValueTask<User> GetAsync(Expression<Func<User, bool>> expression, string[] includes = null)
            => await _repository.GetAsync(expression, includes);


        public User Update( User entity)
        {
          return  _repository.Update(entity);
            _repository.SaveChangesAsync();
        }
    }
}
