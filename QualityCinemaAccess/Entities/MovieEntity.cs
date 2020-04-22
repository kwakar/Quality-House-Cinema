using System;
using System.ComponentModel.DataAnnotations;

namespace QualityCinemaAccess.Entities
{
    public class MovieEntity
    {
        [Key]
        public int MovieId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ReleaseDate { get; set; }

        public byte RunningTime { get; set; }

        public string Genre { get; set; }
        
        public bool Released { get; set; }

        public byte[] Cover { get; set; }

        public bool ShowOnHome { get; set; }

        public byte PositionOnHome { get; set; }

        public string Trailer { get; set; }
    }
}