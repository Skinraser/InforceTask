using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUserRepository
    {
        User Create(User model);
        IEnumerable<User> GetAll();
        User GetById(int id);
        void DeleteById(int id);
        User GetUserByEmail(string email);
    }
}
