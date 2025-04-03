using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewProject.Services;

namespace NewProject.Controllers
{
    public class HomeController1 : ControllerBase
    {
        private readonly IScopedService _scoped;
        private readonly ISingletonService _singleton;
        private readonly ITransService _trans;

        public HomeController1(ISingletonService singleton, IScopedService scoped, ITransService trans)
        {
            _scoped = scoped;
            _singleton = singleton;
            _trans = trans;
        }
        public IActionResult Index()
        {
            _trans.DOWork();
            _scoped.DOWork();
            _singleton.DOWork();
            return Content("Service executed...");
        }
    }
}

