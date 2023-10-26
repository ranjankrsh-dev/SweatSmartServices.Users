using SweatSmart.UserService.Domain;
using SweatSmart.UserService.Persistence.Data;
using SweatSmart.UserService.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweatSmart.UserService.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private UserDbContext _userDbContext;

        public UserRepository(UserDbContext userDbContext)
        {
            this._userDbContext = userDbContext;
        }

        public Task<List<User>> GetById(int id)
        {
            //User user = new User();
            //user.Id = 10001;
            //user.Name = "Ranjan Kumar Sharma";
            var resp = _userDbContext.Users.ToList();
            return Task.FromResult(resp);
        }
    }
}
