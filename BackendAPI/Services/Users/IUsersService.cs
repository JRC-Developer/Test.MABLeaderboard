using BackendAPI.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendAPI.Services.Users
{
    public interface IUsersService
    {
        List<UserModel> GetUsers();
        UserModel GetUser(int id);
        UpdateUserResponseModel UpdateUser(int id, string firstName, string lastName, string email, string telephone);
    }
}
