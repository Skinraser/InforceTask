using AutoMapper;
using BLL.Interfaces;
using BLL.Models;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UserService : IUserService
    {
        IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public UserModel Create(UserModel model)
        {
            var user = _userRepository.Create(_mapper.Map<User>(model));
            return _mapper.Map<UserModel>(user);
        }

        public void DeleteById(int id)
        {
            _userRepository.DeleteById(id);
        }

        public IEnumerable<UserModel> GetAll()
        {
            var users = _userRepository.GetAll();
            return _mapper.Map<IEnumerable<UserModel>>(users);
        }

        public UserModel GetById(int id)
        {
            var user = _userRepository.GetById(id);
            return _mapper.Map<UserModel>(user);
        }

        public int LogIn(string email, string password)
        {
            var user = _userRepository.GetUserByEmail(email);
            if (user == null)
            {
                throw new Exception("Such user doesn't exists");
            }
            if(user.Password == password)
            {
                return user.Id;
            }
            else
            {
                throw new Exception("Wrong email or password");
            }
        }

        public UserModel SignUp(UserModel model)
        {
            var user = _userRepository.GetUserByEmail(model.Email);
            if (user != null)
            {
                throw new Exception("User already exists");
            }
            _userRepository.Create(_mapper.Map<User>(model));
            return model;

        }
    }
}
