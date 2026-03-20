using System.Web.Mvc;

namespace Platform.Client.Controllers
{
    public class HomeController : Controller
    {
        private readonly ServiceClient _serviceClient = new ServiceClient();

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegisterTopic(string topic)
        {
            var result = _serviceClient.RegisterTopic(topic);
            ViewBag.Result = result;

            return View("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact page";

            return View();
        }
    }
}