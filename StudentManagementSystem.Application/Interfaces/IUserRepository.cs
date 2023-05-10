using StudentManagementSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Application.Interfaces
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllUsersAsync(int pageNum, int pageSize = 10);

        Task<List<User>> GetAllUsersAsync();

        Task<User> GetUserByCodeAsync(string code);

        Task<List<User>> GetUsersByNameAsync(string name);
    }
}
