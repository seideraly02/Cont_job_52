using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Store.Models;

namespace Store.Controllers
{
    public class StoreController : Controller
    {
        private StoreContext db;

        public StoreController(StoreContext _db)
        {
            db = _db;
        }

        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}