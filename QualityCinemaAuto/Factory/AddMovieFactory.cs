using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace QualityCinemaAuto
{
    class AddMovieFactory
    {
        List<AddMovie> _movies;
        int _currentMovieIndex = 0;

        public AddMovieFactory()
        {
            var jsonMovieData = File.ReadAllText(@"Factory\AddMovieFactory.json");
            _movies = JsonConvert.DeserializeObject<List<AddMovie>>(jsonMovieData);
        }

        public AddMovie GetMovieData()
        {
            var returnIndex = _currentMovieIndex;
            _currentMovieIndex++;

            if (_currentMovieIndex >= _movies.Count)
            {
                returnIndex = 0;
            }

            return new AddMovie(_movies[returnIndex]);
        }

        public AddMovie CreateMovie()
        {
            var movie = GetMovieData();
            return movie;

            //return new AddMovie
            //{
            //    Name = "Venom 2",
            //    Description = "bab",
            //    ReleaseDate = "02/10/2020",
            //    RunningTime = "120",
            //    Genre = "Action",
            //    Position = "1"
            //};
        }
    }
}
