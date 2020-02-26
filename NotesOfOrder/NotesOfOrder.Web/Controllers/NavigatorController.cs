using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace NotesOfOrder.Web.Controllers
{
    public class NavigatorController : Controller
    {
        private readonly ILogger<NavigatorController> _logger;

        public NavigatorController(ILogger<NavigatorController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
