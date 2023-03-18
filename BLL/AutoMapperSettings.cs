using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BLL.Models;
using DAL.Entities;

namespace BLL
{
    public class AutoMapperSettings : Profile
    {
        public AutoMapperSettings()
        {
            CreateMap<Url, UrlModel>()
                .ReverseMap();

            CreateMap<User, UserModel>()
                .ReverseMap();
        }
        
    }

}