using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class UrlRepository : IUrlRepository
    {
        UrlsDBContext _context; 
        public UrlRepository(UrlsDBContext context)
        {
            _context = context;
        }
        public Url Create(Url model)
        {
            _context.Urls.Add(model);
            _context.SaveChanges();
            return model;
        }

        public void DeleteById(int id)
        {
            var url = _context.Urls.FirstOrDefault(x => x.Id == id);
            _context.Urls.Remove(url);
            _context.SaveChanges();
        }

        public IEnumerable<Url> GetAll()
        {
            var urls = _context.Urls.AsEnumerable();
            return urls;
        }

        public Url GetById(int id)
        {
            var url = _context.Urls.FirstOrDefault(x => x.Id == id);
            return url;
        }
    }
}
