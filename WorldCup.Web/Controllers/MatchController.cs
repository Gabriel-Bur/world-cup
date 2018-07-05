using AutoMapper;
using System.Collections.Generic;
using System.Web.Mvc;
using WorldCup.Data.Repositories;
using WorldCup.Domain.Entities;
using WorldCup.Web.Models;

namespace WorldCup.Web.Controllers
{
    public class MatchController : Controller
    {

        private readonly MatchRepository _repo;

        public MatchController()
        {
            _repo = new MatchRepository();
        }


        public ActionResult Play(int id)
        {
            var matchToView = Mapper.Map<Match, ModelViewMatch>(_repo.GetById(id));

            return View(matchToView);

        }

        [HttpPost]
        public ActionResult Play(int id, ModelViewMatch match)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var updateMatch = Mapper.Map<ModelViewMatch, Match>(match);
                    updateMatch.Play();
                    _repo.Update(updateMatch);

                    return RedirectToAction("Index");
                }
                catch
                {
                    return View(match);
                }
            }
            return View(match);
        }


        // GET: Match
        public ActionResult Index()
        {
            var allMatches = Mapper.Map<IEnumerable<Match>, IEnumerable<ModelViewMatch>>(_repo.GetAll());

            return View(allMatches);
        }

        // GET: Match/Details/5
        public ActionResult Details(int id)
        {
            var match = Mapper.Map<Match, ModelViewMatch>(_repo.GetById(id));

            return View(match);
        }

        // GET: Match/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Match/Create
        [HttpPost]
        public ActionResult Create(ModelViewMatch match)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var newMatch = Mapper.Map<ModelViewMatch, Match>(match);
                    _repo.Add(newMatch);

                    return RedirectToAction("Index");
                }
                catch
                {
                    return View(match);
                }
            }
            return View(match);
        
        }

        // GET: Match/Edit/5
        public ActionResult Edit(int id)
        {
            var match = Mapper.Map<Match, ModelViewMatch>(_repo.GetById(id));

            return View(match);
        }

        // POST: Match/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ModelViewMatch match)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var updateMatch = Mapper.Map<ModelViewMatch, Match>(match);
                    _repo.Update(updateMatch);

                    return RedirectToAction("Index");
                }
                catch
                {
                    return View(match);
                }
            }
            return View(match);
        }

        // GET: Match/Delete/5
        public ActionResult Delete(int id)
        {

            var matchToDelete = _repo.GetById(id);

            if(matchToDelete == null)
            {
                return HttpNotFound();
            }

            _repo.Remove(matchToDelete);

            return RedirectToAction("Index");
        }

    }
}
