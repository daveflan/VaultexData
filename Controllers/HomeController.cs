using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VaultexModels;

namespace VaultexData.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string organisationnumber = "";

            var model = new EmployeeOrganisationDataViewModel(organisationnumber);
            
            return View(model);
        }

    }
}