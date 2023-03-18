using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        UrlsDBContext _context;
        public UserRepository(UrlsDBContext context)
        {
            _context = context;
        }
        public User Create(User model)
        {
            _context.Users.Add(model);
            _context.SaveChanges();
            return model;
        }

        public void DeleteById(int id)
        {
            var url = _context.Users.FirstOrDefault(x => x.Id == id);
            _context.Users.Remove(url);
            _context.SaveChanges();
        }

        public IEnumerable<User> GetAll()
        {
            var users = _context.Users.AsEnumerable();
            return users;
        }

        public User GetById(int id)
        {
            var user = _context.Users.FirstOrDefault(x => x.Id == id);
            return user;
        }
        public User GetUserByEmail(string email)
        {
            return _context.Users.FirstOrDefault(x => x.Email == email);
        }
    }
}
