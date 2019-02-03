using MovieApp.Core.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace MovieApp.Core.Store
{
    public class MovieRepository
    {
        public IList<Movie> Movies { get; }

        public MovieRepository()
        {
            var currentAssembly = GetType().GetTypeInfo().Assembly;
            var stream = currentAssembly.GetManifestResourceStream("MovieApp.Core.Data.movies.json");
            using (StreamReader reader = new StreamReader(stream))
            {
                JObject moviesSearch = JObject.Parse(reader.ReadToEnd());
                Movies = JsonConvert.DeserializeObject<List<Movie>>(moviesSearch["results"].ToString());
            }
        }
    }
}
