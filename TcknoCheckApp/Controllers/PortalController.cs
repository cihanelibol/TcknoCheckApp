using Microsoft.AspNetCore.Mvc;
using TcknoCheckApp.BusinessLogic.Abstract;
using TcknoCheckApp.Models.Concrete;

namespace TcknoCheckApp.Controllers
{
    public class PortalController : Controller
    {
        private IPortalManager _portalManager;
        public PortalController(IPortalManager portalManager)
        {
            _portalManager = portalManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var result = _portalManager.GetList();
            return View(result);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Portal portal)
        {
            _portalManager.Add(portal);
            return RedirectToAction("Index");
        }

      
    }
}
