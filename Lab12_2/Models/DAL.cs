using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;
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
    }
}
