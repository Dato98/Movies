using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using Movies.Models;
using Newtonsoft.Json;
using Services.Contracts;

namespace Movies.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUOW _service;
        public HomeController(IUOW service)
        {
            _service = service;
        }
        public string Index()
        {
            /*Movie movie = new Movie();
            movie.DirectorId = 4;
            movie.Thumb = "..";
            movie.Title = "test - title";
            movie.Description = "test - description";

            _service.Movie.Create(movie);
            _service.Commit();*/

            var movie = _service.Movie.GetMovieWithDirector();

            
            return movie.Director.Firstname;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
