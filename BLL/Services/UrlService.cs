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
    public class UrlService : IUrlService
    {
        IUrlRepository _urlRepository;
        IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UrlService(IUrlRepository urlRepository, IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _urlRepository = urlRepository;
            _mapper = mapper;
        }
        public UrlModel Create(UrlModel model)
        {
            var url = _urlRepository.Create(_mapper.Map<Url>(model));
            return _mapper.Map<UrlModel>(url);
        }

        public void DeleteById(int id)
        {
            _urlRepository.DeleteById(id);
        }

        public IEnumerable<UrlModel> GetAll()
        {
            var urls = _urlRepository.GetAll();
            return _mapper.Map<IEnumerable<UrlModel>>(urls);
        }

        public UrlModel GetById(int id)
        {
            var url = _urlRepository.GetById(id);
            return _mapper.Map<UrlModel>(url);
        }

        public UrlModel UrlShortener(string url)
        {
            byte[] bytes = Guid.NewGuid().ToByteArray();
            string base64String = Convert.ToBase64String(bytes).Trim('=');

            var urlModel = new UrlModel()
            {
                LongUrl = url,
                ShortUrl = "url.bit/" + base64String,
                CreatedDate = DateTime.Now.Date
            };
            Create(urlModel);
            return urlModel;
        }
    }
}

