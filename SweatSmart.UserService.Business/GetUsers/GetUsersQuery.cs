using MediatR;
using SweatSmart.UserService.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweatSmart.UserService.Business.GetUsers
{
    public class GetUsersQuery: IRequest<List<User>>
    {
        public int Id { get; set; }
        public GetUsersQuery(int id)
        {
            Id = id;
        }
    }
}
