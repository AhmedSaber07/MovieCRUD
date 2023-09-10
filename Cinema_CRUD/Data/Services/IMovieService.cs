using Cinema_CRUD.Data.Enums;
using Cinema_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema_CRUD.Data.Services
{
    public interface IMovieService
    {
        IEnumerable<Movie> GetAll();
        Movie GetById(int MovieId);
        List<MovieCategory> GetAvailableMoviesByCategory();
        void Add(Movie movie);
        IEnumerable<Movie> SearchByName(string name);
        IEnumerable<Movie> SearchByCategory(MovieCategory category);
        void Update(int MovieId, Movie newMovie);
        void Delete(int MovieId);
    }
}
