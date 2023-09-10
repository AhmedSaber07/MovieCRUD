using Cinema_CRUD.Data.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema_CRUD.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieApiController : ControllerBase
    {
        private readonly IMovieService _movieService;
        public MovieApiController(IMovieService movieService)
        {
            _movieService = movieService;
        }
        [HttpDelete]
        public IActionResult Delete(int movieId)
        {
            var movie = _movieService.GetById(movieId);
            if (movie is null)
                return NotFound();
            _movieService.Delete(movieId);
            return Ok();
        }
        [HttpGet]
        public IActionResult GetAvailableMovieCategory()
        {
            return Ok(_movieService.GetAvailableMoviesByCategory().Select(category=>category.ToString()).ToList());
        }
    }
}
