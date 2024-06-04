using DeckofCards.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DeckofCards.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetDeck()
        {
            NewDeck result = NewDeckDAL.NewDeck();
            return View(result);
        }

        [HttpPost]
        public IActionResult ViewCards(string deckId)
        {
            DrawCardModel drawresult = DrawCardDAL.GetCard(deckId);
            return View(drawresult);
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
