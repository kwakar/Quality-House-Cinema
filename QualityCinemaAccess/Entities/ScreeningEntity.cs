using System;
using System.ComponentModel.DataAnnotations;

namespace QualityCinemaAccess.Entities
{
    public class ScreeningEntity
    {
        [Key]
        public int ScreeningId { get; set; }

        public int MovieId { get; set; }

        public DateTime DateTime { get; set; }

        public short Seats { get; set; }
    }
}