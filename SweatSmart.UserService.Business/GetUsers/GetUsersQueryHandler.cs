using MediatR;
using SweatSmart.UserService.Domain;
using SweatSmart.UserService.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweatSmart.UserService.Business.GetUsers
{
    public class GetUsersQueryHandler : IRequestHandler<GetUsersQuery, List<User>>
    {
        private readonly IUserRepository _userRepository;
        public GetUsersQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<List<User>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
        {
            return await _userRepository.GetById(1);
        }
    }
}
