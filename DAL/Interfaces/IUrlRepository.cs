using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUrlRepository
    {
        Url Create(Url model);
        IEnumerable<Url> GetAll();
        Url GetById(int id);
        void DeleteById(int id);
    }
}
