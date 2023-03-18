using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IUserService
    {
        UserModel Create(UserModel model);
        IEnumerable<UserModel> GetAll();
        UserModel GetById(int id);
        void DeleteById(int id);
        UserModel SignUp(UserModel model);
        int LogIn(string email, string password);
    }
}
