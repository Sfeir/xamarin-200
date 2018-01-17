using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApp.Core.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Overview { get; set; }
        
        public DateTime ReleaseDate { get; set; }
    }
}
