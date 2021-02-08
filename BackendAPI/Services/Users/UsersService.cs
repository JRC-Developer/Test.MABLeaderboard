using BackendAPI.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendAPI.Services.Users
{
    public class UsersService : IUsersService
    {
        private List<UserModel> _userList;
        public UsersService()
        {
            _userList = new List<UserModel>(){
                new UserModel()
                {
                    ID = 1,
                    Firstname = "Bob",
                    Lastname = "Smith"
                },
                new UserModel()
                {
                    ID = 2,
                    Firstname = "Jenny",
                    Lastname = "Smith"
                },
                new UserModel()
                {
                    ID = 3,
                    Firstname = "Joe",
                    Lastname = "Thomas"
                }
            };
        }
        public UserModel GetUser(int id)
        {
            return _userList.Where(u => u.ID == id).FirstOrDefault();
        }

        public List<UserModel> GetUsers()
        {
            return _userList.OrderBy(u => u.ID).ToList();
        }

        public UpdateUserResponseModel UpdateUser(int id, string firstName, string lastName, string email, string telephone)
        {
            if (string.IsNullOrWhiteSpace(firstName))
                return new UpdateUserResponseModel()
                {
                    Success = false,
                    ErrorMessage = "First name cannot be empty"
                };
            else if (string.IsNullOrWhiteSpace(lastName))
                return new UpdateUserResponseModel()
                {
                    Success = false,
                    ErrorMessage = "Last name cannot be empty"
                };

            var existingUser = _userList.Where(u => u.ID == id).FirstOrDefault();

            if (existingUser != null)
            {
                _userList.Remove(existingUser);

                var UserToUpdate = new UserModel()
                {
                    ID = id,
                    Firstname = firstName,
                    Lastname = lastName,
                    Email = email == "null" ? null : email,
                    Telephone = telephone == "null" ? null : telephone
                };

                _userList.Add(UserToUpdate);

                return new UpdateUserResponseModel()
                {
                    Success = true
                };
            }
            else
                return new UpdateUserResponseModel()
                {
                    Success = false,
                    ErrorMessage = "ID provided does not exist"
                };
        }
    }
}
