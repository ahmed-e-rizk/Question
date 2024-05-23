using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Question.DbContext;
using Question.DbContext.Entities;
using Question.Repository;

namespace Question.BL.Auth
{
    public class AuthBLL : IAuthBLL
    {
        private readonly IRepository _repository;
        private readonly IPasswordHasher<User> _passwordHasher;
        public AuthBLL(IDbContextFactory<AppDbContext> contextFactory, IPasswordHasher<User> passwordHasher)
        {
            var context = contextFactory.CreateDbContext();
            _repository = new BaseRepository(context);
            _passwordHasher = passwordHasher;
        }


        

    }
}
