using Company.Reposatory.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace Company.web.Controllers
{
    public class DepartmentController1 : Controller
    {
        private readonly IDepartmentReposatory _departmentReposatory;

        public DepartmentController1(IDepartmentReposatory departmentReposatory)
        {
            _departmentReposatory = departmentReposatory;
        }
        public IActionResult Index()
        {
          var departments =_departmentReposatory.GetAll();

            return View(departments);
        }
    }
}
