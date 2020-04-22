using Microsoft.EntityFrameworkCore;
using QualityCinemaAccess.Context;
using QualityCinemaAccess.Entities;
using System.Collections.Generic;
using System.Linq;

namespace QualityCinemaAccess.Repositories
{

    public class ReservationRepository
    {
        private readonly QualityCinemaDbContext _context;
        private readonly DbSet<ReservationEntity> _reservationEntities;

        public ReservationRepository()
        {
            _context = new QualityCinemaDbContext();
            _reservationEntities = _context.Reservation;
        }

        
        public void ReservationFromThisUserCheck(int userId)
        {
            var reservationRepository = new ReservationRepository();

            bool dBContainsReservationsFromUserId = reservationRepository.DBContainsReservationFromUserId(userId);

            if (dBContainsReservationsFromUserId == true)
            {
                reservationRepository.DeleteAllReservationsFromUserId(userId);
            }
        }


        private bool DBContainsReservationFromUserId(int userId)
        {
            var thisUserReservations =
                from reservaton in _reservationEntities
                where reservaton.UserId == userId
                select reservaton;

            var selectedReservations = thisUserReservations.Any();

            return selectedReservations;
        }


        public void DeleteAllReservationsFromUserId(int userId)
        {
            var deleteReservation =
                from reservations in _reservationEntities
                where reservations.UserId == userId
                select reservations;

            _reservationEntities.RemoveRange(deleteReservation);
            _context.SaveChanges();
        }


        public void CreateNewReservation(int userId, int screeningID)
        {
            List<ReservationEntity> newReservation = new List<ReservationEntity>()
            {
                new ReservationEntity(){
                    ScreeningId = screeningID,
                    UserId = userId,
                    Seats = 2}
            };

            _reservationEntities.AddRange(newReservation);
            _context.SaveChanges();
        }


        public int CreateNewReservationWith2Seats(int userId, int screeningID)
        {
            List<ReservationEntity> newReservation = new List<ReservationEntity>()
            {
                new ReservationEntity(){
                    ScreeningId = screeningID,
                    UserId = userId,
                    Seats = 2}
            };

            _reservationEntities.AddRange(newReservation);
            _context.SaveChanges();

            int createdReservation = newReservation.FirstOrDefault().ReservationId;
            return createdReservation;
        }


        public byte SeatsLeftCheck(int userId, int screeningId)
        {
            var selectedScreenings =
                from reservations in _reservationEntities
                where reservations.ScreeningId == screeningId
                && reservations.UserId == userId
                select reservations;

            var numberOfSeatsReserved = selectedScreenings.FirstOrDefault().Seats;

            if (selectedScreenings == null)
                return 0;
            else
                return numberOfSeatsReserved;
        }
    }
}