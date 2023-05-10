using MediatR;
using StudentManagementSystem.Application.Common.Mappings;
using StudentManagementSystem.Domain.Entities;
using StudentManagementSystem.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Application.Features.User.Commands
{
    public record CreateUserCommand : IRequest<Result<int>>, IMapFrom<User>
    {
        //thay doi o day
        public int check()
        {
            return 0;
        }
    }
}
