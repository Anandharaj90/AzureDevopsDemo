using DevopsDemo.Models;
using DevopsDemo.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DevopsDemo.Controllers
{
    public class HomeController : Controller
    {

        private readonly IPostRepository _postRepository;
        //private readonly ILogger<HomeController> _logger;

        public HomeController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public IActionResult Index()
        {
            var model = _postRepository.GetPosts();
            return View(model);
        }

        public IActionResult About()
        {
            ViewData["Description"] = "Your Applicaation About page";

            return View();
        }
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your Application Contact page";

            return View();
        }

        public IActionResult Visit()
        {
            ViewData["Message"] = "Your Application Contact page";

            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}