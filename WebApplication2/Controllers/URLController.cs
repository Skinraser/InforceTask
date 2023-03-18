using BLL.Interfaces;
using BLL.Models;
using DAL;
using DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class URLController : ControllerBase
    {
        IUrlService _urlService;
        public URLController(IUrlService urlService)
        {
            _urlService = urlService;
        }
        [HttpGet]
        [Route("getUrls")]
        public IEnumerable<UrlModel> GetUrlList()
        {
            return _urlService.GetAll();
        }
        [HttpGet]
        [Route("getUrl/{id}")]
        public UrlModel GetUrl(int id)
        {
            var url = _urlService.GetById(id);
            return url;
        }
        [HttpDelete]
        [Route("delete/{id}")]
        public void Delete(int id)
        {
            _urlService.DeleteById(id);
        }
        [HttpPost]
        [Route("shortUrl")]
        public UrlModel UrlShortener(UrlTransferModel url)
        {
            return _urlService.UrlShortener(url.Url);
        }
    }
}
