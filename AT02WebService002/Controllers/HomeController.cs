/*
   DESIGNER: Claudinei Pereira de Sousa (ID: 100647340)
   Date: 25/10/2023   
   Project Name: (Assignment 02 Web Services) 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AT02WebService002.Models;
using static AT02WebService002.Models.MovieModel;
using static System.Net.Mime.MediaTypeNames;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Net;
using AT02WebService002;
using System.Web.Optimization;

namespace AT02WebService002.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            

            return View();
        }
        public ActionResult Movie()
        {
           

            return View();
        }

        [HttpPost]
        public ActionResult Movie(string mTitle)
        {
            if (mTitle == null)
            {
                mTitle = "Spider Man 3";
            }
           TempData["Title"] = mTitle;
            return View();
            
        }
        
        public JsonResult GetMovie()
        {
            MovieModel movies = new MovieModel();

            if (TempData["Title"] == null)
            {
                TempData["Title"] = "Spider Man 3";
            }
            string mTitle = TempData["Title"].ToString();
            return Json(movies.GetMovieSearch(mTitle), JsonRequestBehavior.AllowGet);
        }

    }
}
