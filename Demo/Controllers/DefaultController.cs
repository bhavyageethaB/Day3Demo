using Demo.viewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{
    public class DefaultController : Controller
    {
       // GET: Default
        //public string Index(string id, string Name)
        //{
        //    return "Hi This is" + Name + "and your id is" + id;
        //}

        public ActionResult print(string id)
        {
            TempData["value"] = id;
            TempData.Keep("value");
            return View();
        }

        public ActionResult Thank()
        {
            return View();
        }


        public ActionResult EmpDep()
        {
            EmpDept ed = new EmpDept { EmpId=11,EmpName="Bhavya",DeptName="FS"};

            return View(ed);
        }
    }
}