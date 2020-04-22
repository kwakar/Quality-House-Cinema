using Newtonsoft.Json;

namespace QualityCinemaAuto
{
    public class AddMovie
    {
        public AddMovie()
        {
        }

        [JsonProperty("Name")]
        public string Name { set; get; }

        [JsonProperty("Description")]
        public string Description { set; get; }

        [JsonProperty("ReleaseDate")]
        public string ReleaseDate { set; get; }

        [JsonProperty("RunningTime")]
        public string RunningTime { set; get; }

        [JsonProperty("Genre")]
        public string Genre { set; get; }

        [JsonProperty("Position")]
        public string Position { set; get; }

        public AddMovie(AddMovie other)
        {
            this.Name = other.Name;
            this.Description = other.Description;
            this.ReleaseDate = other.ReleaseDate;
            this.RunningTime = other.RunningTime;
            this.Genre = other.Genre;
            this.Position = other.Position;
        }
    }
}
