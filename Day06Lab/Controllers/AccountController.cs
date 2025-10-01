using Microsoft.AspNetCore.Mvc;
using Day06Lab.Models;
using System.Text.RegularExpressions;

namespace Day06Lab.Controllers
{
    public class AccountController : Controller
    {
        private static List<Account> accounts = new List<Account>();
        public IActionResult Index()
        {
            return View(accounts);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Account model)
        {
            if (ModelState.IsValid)
            {
                accounts.Add(model); 
                return RedirectToAction("Index");
            }
            //Account model = new Account();
            return View(model);
        }
        [AcceptVerbs("GET","POST")]
        public IActionResult VerifyPhone(string Phone)
        {
            Regex _isPhone = new Regex(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$");
            if ( !_isPhone.IsMatch(Phone) )
            {
                return Json($"So din thoai {Phone} khong dung dinh dang , vd 0355880362 hoac 035.588.0362");
            }
            return Json(true);
        }
    }
}
