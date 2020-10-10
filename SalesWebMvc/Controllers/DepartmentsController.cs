using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace SalesWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {



            List<Department> listaDepto = new List<Department>();
            listaDepto.Add(new Department { Id = 1, Name = "Electronics" });
            listaDepto.Add(new Department { Id = 2, Name = "Fashion" });

            return View(listaDepto);
        }
    }
}
