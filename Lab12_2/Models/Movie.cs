using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Lab12_2.Models
{
    [Table("movie")]
    public class Movie
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string genre { get; set; }
        public string mainactor { get; set; }
    }
}
