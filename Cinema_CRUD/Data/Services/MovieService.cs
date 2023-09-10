using Cinema_CRUD.Data.Enums;
using Cinema_CRUD.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema_CRUD.Data.Services
{
    public class MovieService : IMovieService
    {
        private readonly ApplicationDbContext _context;
        private static List<MovieCategory> MovieAvailable;
        public MovieService(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
        }
        public List<MovieCategory> GetAvailableMoviesByCategory()
        {
            MovieAvailable = _context.Movies.Select(e=>e.movieCategory).Distinct().ToList();
            return MovieAvailable;
        }

        public IEnumerable<Movie> SearchByName(string? name)
        {
            
            return _context.Movies.Where(n=>n.Name.ToLower().Contains(name.ToLower())).ToList();
        }
        public IEnumerable<Movie> SearchByCategory(MovieCategory category)
        {
            return _context.Movies.Where(c => c.movieCategory == category).ToList();
        }
        public void Delete(int MovieId)
        {
            var movie = _context.Movies.FirstOrDefault(e => e.ID == MovieId);
            _context.Movies.Remove(movie);
            _context.SaveChanges();
        }

        public IEnumerable<Movie> GetAll()
        {
            return _context.Movies.ToList();
        }

        public Movie GetById(int MovieId)
        {
            return  _context.Movies.FirstOrDefault(e => e.ID == MovieId);
        }

        public void Update(int MovieId, Movie newMovie)
        {
            var movie = GetById(MovieId);
            if (movie != null)
            {
                movie.Name = newMovie.Name;
                movie.Description = newMovie.Description;
                movie.movieCategory = newMovie.movieCategory;
                movie.image = newMovie.image;
                movie.Price = newMovie.Price;
                movie.StartDate = newMovie.StartDate;
                movie.EndDate = newMovie.EndDate;
                _context.SaveChanges();
            }
        }
    }
}
