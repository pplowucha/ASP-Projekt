﻿using SportsCompetitions.Models;
using SportsCompetitionsMVC.Models;
using SportsCompetitionsMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsCompetitionsMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            List<DisplayEventViewModel> vm = new List<DisplayEventViewModel>();
            using (var db = new ApplicationDbContext())
            {
                DateTime today = DateTime.Now;

             
                var min = db.SingleCompetition.OrderByDescending(cv => cv.StartDate).Take(3);

                //var allCompetitions = db.SingleCompetition.Select((s => s.OrderByD=> x.Datescending(x e).FirstOrDefault());
                foreach (var item in min)
                {
                    
                    DisplayEventViewModel _event = new DisplayEventViewModel();
                    _event.Title = item.Title;
                    //_event.ModeratorName = (item as SingleCompetition).ModeratorId;
                    _event.Category = item.Category.ToString();
                    //_event.CompetitorsCount = item.CompetitorsId.Count;
                    _event.Image = item.Image;
                    _event.StartDate = item.StartDate;

                    vm.Add(_event);


                }
                for (int i = 0; i < 3; i++)
                {


                }


            }

            return View(vm);
        }
    }
}