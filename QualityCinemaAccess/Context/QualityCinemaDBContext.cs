using Microsoft.EntityFrameworkCore;
using QualityCinemaAccess.Entities;
using QualityCinemaAccess.Repositories;

namespace QualityCinemaAccess.Context
{
    public class QualityCinemaDbContext : DbContext
    {
        public DbSet<UserEntity> User { get; set; }

        public DbSet<ReservationEntity> Reservation { get; set; }

        public DbSet<ScreeningEntity> Screening { get; set; }

        public DbSet<MovieEntity> Movie { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=192.168.5.86,49170;Initial Catalog=Test;User ID=db_manager;Password=QCinem@123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;");
        }

    }
}