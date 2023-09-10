using Cinema_CRUD.Data.Enums;
using Cinema_CRUD.Data.Services;
using Cinema_CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema_CRUD.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieService _movieService;
        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }
        public IActionResult Index()
        {
            return View( _movieService.GetAll());
        }
        public IActionResult  Details(int movieId)
        {
            var movie = _movieService.GetById(movieId);
            if (movie is null)
                return NotFound();
            return View(movie);
        }
        public IActionResult FilterByName(string MovieName)
        {
            if (string.IsNullOrEmpty(MovieName))
                return RedirectToAction("Index");
            var Movies = _movieService.SearchByName(MovieName);
            if (Movies.Count() > 0)
                return View("Index", Movies);
            return RedirectToAction("Index");
        }
        public IActionResult FilterByCategory(MovieCategory MovieCategory)
        {
            var Movies = _movieService.SearchByCategory(MovieCategory);
                return View("Index", Movies);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Movie movie)
        {
            /* if (!ModelState.IsValid)
                 return View(ModelState);*/
            if (Request.Form.Files.Count <= 0)
            {
                ModelState.AddModelError("image", "Image Is Required");
                return View(movie);
            }
            var file = Request.Form.Files.FirstOrDefault();
            using (var dataStream = new MemoryStream())
            {
                 file.CopyTo(dataStream);
                movie.image = dataStream.ToArray();
            }
            _movieService.Add(movie);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int movieId)
        {
            var movie = _movieService.GetById(movieId);
            if (movie is null)
                return NotFound();
            return View(movie);
        }
        [HttpPost]
        public IActionResult Edit(int ID,Movie newMovie)
        {
            if (!ModelState.IsValid)
                return View(ModelState);
            var movie = _movieService.GetById(ID);
            if (movie is null)
                return NotFound();
            if (movie.ID != newMovie.ID)
                return NotFound();
            if (Request.Form.Files.Count > 0)
            {
                var file = Request.Form.Files.FirstOrDefault();
                using (var dataStream = new MemoryStream())
                {
                    file.CopyTo(dataStream);
                    newMovie.image = dataStream.ToArray();
                }
            }
            else
            {
                newMovie.image = movie.image;
            }
            _movieService.Update(ID, newMovie);
            return RedirectToAction("Index");
        }
        
    }
}
