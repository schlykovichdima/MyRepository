using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Shlykovich.Controllers
{
    public class HomeController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpPost]
        public IActionResult Index ([FromForm] int[] CheckBox, int RadioDef)
        {
            return View();
        }
        private readonly ILogger<HomeController> _logger;
        private readonly List<ListDemo> _listData;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _listData = new List<ListDemo>
 {
 new ListDemo {Id=1, Name="Item 1"},
 new ListDemo {Id=2, Name="Item 2"},
 new ListDemo {Id=3, Name="Item 3"}
 };
        }
        public IActionResult Index()
        {
            ViewData["text"] = "Лабораторная работа №2";
            SelectList data = new SelectList(_listData, "Id", "Name");
            return View(data);
        }
        public class ListDemo
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        


    }
}
