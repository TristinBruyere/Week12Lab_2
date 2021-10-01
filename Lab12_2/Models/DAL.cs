using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;
using MySql.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace Lab12_2.Models
{
    public class DAL
    {
        public static MySqlConnection DB;
        public static List<Movie> GetAllMovies()
        {
            return DB.GetAll<Movie>().ToList();
        }
        public static Movie GetMovie(int id)
        {
            return DB.Get<Movie>(id);
        }
        public static List<Movie> GetMovieGenre(string genre)
        {
            var myparams = new { gen = genre };
            string sql = "select * from movie where genre = @gen";
            return DB.Query<Movie>(sql, myparams).ToList();
        }
        public static List<string> GetGenre()
        {
            List<Movie> movies = DAL.GetAllMovies();
            List<string> genres = new List<string>();
            foreach (Movie movie in movies)
            {
                genres.Add(movie.genre);
            }
            return genres;
        }
        public static List<Movie> SearchByMovieName(string name)
        {
            var mypararms = new { search = $"%{name}%" };
            List<Movie> movies = DB.Query<Movie>("select * from movie where name like @search", mypararms).ToList();
            return movies;
        }
    }
}
