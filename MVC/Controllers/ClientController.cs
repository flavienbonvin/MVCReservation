﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using DTO;

namespace MVC.Controllers
{
    public class ClientController : Controller
    {
        // GET: Client
        public ActionResult Index()
        {
            AccessWebAPI access = new AccessWebAPI();

            return View(access.getClients());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Client client)
        {
            AccessWebAPI access = new AccessWebAPI();

            access.PostClient(client);

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            AccessWebAPI access = new AccessWebAPI();
            Client client = access.getClientById(id);
            return View(client);
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            AccessWebAPI access = new AccessWebAPI();
            access.DeleteClient(id);
            return RedirectToAction("Index");
        }


    }
}