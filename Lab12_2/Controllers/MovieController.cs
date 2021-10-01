using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab12_2.Models;

namespace Lab12_2.Controllers
{
    [Route("api/movie")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        [HttpGet("test")]
        public string test()
        {
            return "Hello";
        }

        [HttpGet("allmovies")]
        public List<Movie> getAllMovies()
        { 
            return DAL.GetAllMovies();
        }

        [HttpGet("getmovie")]
        public Movie getMovie(int id)
        {
            return DAL.GetMovie(id);
        }

        [HttpGet("getmoviegenre")]
        public List<Movie> getMovieGenre(string gen)
        {
            List<Movie> movies = DAL.GetMovieGenre(gen);
            return movies;
        }
        [HttpGet("genrelist")]
        public List<string> GetMovieGenres()
        {
            return DAL.GetGenre();
        }
    }
}
