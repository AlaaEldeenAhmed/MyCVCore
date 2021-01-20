using BusinessLayer.Entities;
using BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyCVCore.Models;
using MyCVCore.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyCVCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork<Owner> _owner;
        private readonly IUnitOfWork<Projects> _projects;

        public HomeController(IUnitOfWork<Owner> Owner, IUnitOfWork<Projects> Projects)
        {
            _owner = Owner;
            _projects = Projects;
        }

        public IActionResult Index()
        {
            var homeviewmodel = new HomeViewModel
            {
                Owner = _owner.Entity.GetAll().First(),
                Projects = _projects.Entity.GetAll().ToList()
            };
            return View(homeviewmodel);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Portfolio()
        {
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
