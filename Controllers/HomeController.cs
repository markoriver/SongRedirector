using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SongRedirector.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILinkProvider linkProvider;

        public HomeController(ILinkProvider linkProvider)
        {
            this.linkProvider = linkProvider;
        }
        public IActionResult Index()
        {
            string uri = linkProvider.GetSongLink();
            return Redirect(uri);
        }

    }
}
