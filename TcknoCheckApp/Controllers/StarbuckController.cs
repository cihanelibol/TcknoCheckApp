using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TcknoCheckApp.BusinessLogic.Abstract;
using TcknoCheckApp.BusinessLogic.Concrete;
using TcknoCheckApp.Models.Concrete;

namespace TcknoCheckApp.Controllers
{
    public class StarbuckController : Controller
    {
        private IStarbuckManager _starbuckManager;
        public StarbuckController(IStarbuckManager starbuckManager)
        {
            _starbuckManager = starbuckManager;
        }
        public IActionResult Index()
        {
            var result = _starbuckManager.GetList();
            return View(result);
        }
        public IActionResult Add()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Starbuck starbuck)
        {

            var control = await _starbuckManager.Add(starbuck);
            if (!control)
            {
                ViewBag.Message = "hatali giris";
                return View();
            }
            return RedirectToAction("Index");

        }

    }
}
