using BGDatabase.Models;
using BGDatabase.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BGDatabase.Controllers
{
    public class GamesController : Controller
    {
        //GameStoreDataContext context = new GameStoreDataContext();
        GameRepository repository = new GameRepository();

        // GET: Games
        public ActionResult Index()
        {
            return View(repository.GetAll());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost()]
        public ActionResult Create(BoardGame game)
        {
            if (!ModelState.IsValid) return View(game);

            repository.Add(game);
            repository.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}