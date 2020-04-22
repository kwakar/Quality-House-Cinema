using Microsoft.EntityFrameworkCore;
using QualityCinemaAccess.Context;
using QualityCinemaAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QualityCinemaAccess.Repositories
{
    public class MovieRepository
    {
        private readonly QualityCinemaDbContext _context;
        private readonly DbSet<MovieEntity> _movieEntities;


        public MovieRepository()
        {
            _context = new QualityCinemaDbContext();
            _movieEntities = _context.Movie;
        }
    }
}