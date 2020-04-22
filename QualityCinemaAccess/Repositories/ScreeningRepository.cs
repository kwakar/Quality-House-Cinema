using Microsoft.EntityFrameworkCore;
using QualityCinemaAccess.Context;
using QualityCinemaAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QualityCinemaAccess.Repositories
{
    public class ScreeningRepository
    {
        private readonly QualityCinemaDbContext _context;
        private readonly DbSet<ScreeningEntity> _sreeningEntities;


        public ScreeningRepository()
        {
            _context = new QualityCinemaDbContext();
            _sreeningEntities = _context.Screening;
        }


        public int SelectAvailableScreeningId()
        {
            DateTime currentDateTime = DateTime.Now;
            DateTime maxDateTime = currentDateTime.AddDays(6);

            var availableSreenings =
                from screenings in _sreeningEntities
                where screenings.DateTime > currentDateTime
                && screenings.DateTime < maxDateTime
                select screenings;

            var selectedScreening = availableSreenings.FirstOrDefault().ScreeningId;

            return selectedScreening;
        }


        public bool EnoughtSeatsNumberCheck(int screeningId)
        {
            var availableSeats =
                from screenings in _sreeningEntities
                where screenings.ScreeningId == screeningId
                & screenings.Seats > 1
                select screenings.Seats;

            if (availableSeats != null)
                return true;
            else
                return false;
        }


        public void CreateMoreSeatsForThisScreening(int screeningId)
        {
            var selectedScreening =
                from screenings in _sreeningEntities
                where screenings.ScreeningId == screeningId
                select screenings.Seats;

            short numberOfSeats = 100;

            var update = _context.Update(_sreeningEntities.FirstOrDefault());
            update.Member("Seats").CurrentValue = numberOfSeats;
        }


        public int GetInvalidScreeningID()
        {
            var allScreenings =
                from screenings in _sreeningEntities
                select screenings;

            var lastScreeningId = allScreenings.FirstOrDefault().ScreeningId;

            int invalidScreeningId = lastScreeningId + 100;

            return invalidScreeningId;
        }


        public int CreateNewScreeningWith4Seats(int movieId)
        {
            List<ScreeningEntity> newScreening = new List<ScreeningEntity>()
            {

                new ScreeningEntity(){
                    MovieId = movieId,
                    DateTime = DateTime.Parse(DateTime.Now.ToString("dd.MM.yyyy")),
                    Seats = 4}
            };

            _sreeningEntities.AddRange(newScreening);
            _context.SaveChanges();

            int screeningId = newScreening.FirstOrDefault().ScreeningId;
            return screeningId;
        }

        public void DeleteScreening(int screeningId)
        {
            var deleteScreening =
                from screenings in _sreeningEntities
                where screenings.ScreeningId == screeningId
                select screenings;

            _sreeningEntities.RemoveRange(deleteScreening);
            _context.SaveChanges();
        }

        public ScreeningEntity GetScreeningById(int id)
        {
            return _sreeningEntities.FirstOrDefault(x => x.ScreeningId == id);
        }
    }
}