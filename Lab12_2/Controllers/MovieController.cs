﻿using Microsoft.AspNetCore.Http;
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
    }
}