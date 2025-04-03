using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using NewProject.Models;

namespace NewProject.Controllers
{
    public class HomeController : ControllerBase
    {
        private readonly IMemoryCache _cache;

        public HomeController(IMemoryCache cache)
        {
            _cache = cache;
        }

        public IActionResult Index()
        {
            if (!_cache.TryGetValue("myData", out string data))
            {
                data = "Cache data example";
                _cache.Set("myData", data, TimeSpan.FromMinutes(5));
            }
            return Content(data);
        }

        
    }
}
