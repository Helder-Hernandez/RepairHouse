﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RepairHouse.Controllers
{
    public class LogoutController : Controller
    {
        // GET: Logout
        public ActionResult Index()
        {
            Session[Cons.USER_CURRENT_SESSION] = null;
            return RedirectToAction("Index", "Home");
        }
    }
}