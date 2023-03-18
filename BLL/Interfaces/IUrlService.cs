using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IUrlService
    {
        UrlModel Create(UrlModel model);
        IEnumerable<UrlModel> GetAll();
        UrlModel GetById(int id);
        void DeleteById(int id);
        UrlModel UrlShortener(string url);
    }
}
