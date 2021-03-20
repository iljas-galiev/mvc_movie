using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcMovie.Models
{
    public class MovieSearchViewModel
    {
        public List<Movie> Movies { get; set; }

        public SelectList Genres { get; set; }
        public SelectList Qualities { get; set; }
        public SelectList Years { get; set; }

        public string MovieGenre { get; set; }

        public string MovieQuality { get; set; }

        public string MovieYear { get; set; }

        public string SearchString { get; set; }
    }
}
