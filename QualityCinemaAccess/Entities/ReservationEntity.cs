using System.ComponentModel.DataAnnotations;

namespace QualityCinemaAccess.Entities
{
    public class ReservationEntity
    {
        [Key]
        public int ReservationId { get; set; }

        public int ScreeningId { get; set; }

        public int UserId { get; set; }

        public byte Seats { get; set; }
    }
}