﻿using RepairHouse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using RepairHouse.Dtos;

namespace RepairHouse.Controllers
{
    public class HomeController : Controller
    {
        private casa_reparadoraEntities db = new casa_reparadoraEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult IndexCliente()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}