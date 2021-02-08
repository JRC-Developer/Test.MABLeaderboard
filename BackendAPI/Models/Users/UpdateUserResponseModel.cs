using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendAPI.Models.Users
{
    public class UpdateUserResponseModel
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
    }
}
