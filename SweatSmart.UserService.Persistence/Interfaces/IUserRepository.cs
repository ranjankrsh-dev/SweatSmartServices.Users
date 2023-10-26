using SweatSmart.UserService.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweatSmart.UserService.Persistence.Interfaces
{
    public interface IUserRepository
    {
        Task<List<User>> GetById(int id);
    }
}
