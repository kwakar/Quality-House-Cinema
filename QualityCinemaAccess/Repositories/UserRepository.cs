using Microsoft.EntityFrameworkCore;
using QualityCinemaAccess.Context;
using QualityCinemaAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QualityCinemaAccess.Repositories
{
    public class UserRepository
    {
        private readonly QualityCinemaDbContext _context;
        private readonly DbSet<UserEntity> _userEntities;

        public UserRepository()
        {
            _context = new QualityCinemaDbContext();
            _userEntities = _context.User;
        }

        public bool AnyUsers()
        {
            return _userEntities.Any();
        }

        public UserEntity GetUserById(int id)
        {
            return _userEntities.FirstOrDefault(x => x.UserId == id);
        }

        public UserEntity GetUserByUserEmail(string userName)
        {
            return _userEntities.FirstOrDefault(x => x.DisplayName == userName);
        }

        public UserEntity GetUserByPassword(string userName)
        {
            return _userEntities.FirstOrDefault(x => x.Password == userName);
        }

        public UserEntity GetUserByYearOfBirth(short Year)
        {
            return _userEntities.FirstOrDefault(x => x.YearOfBirth == Year);
        }


        //Invalid user id for negative tests
        public int GetInvalidUserId()
        {
            var allUsers =
                from users in _userEntities
                select users;

            int lastUserNumber = allUsers.LastOrDefault().UserId;
            int invalidUserId = lastUserNumber + 100;

            return invalidUserId;
        }

        //Checks if the user exist in the DB
        public bool ValidUserCheck(int userId)
        {
            var existingUser =
                from users in _userEntities
                where users.UserId == userId
                select users;

            if (existingUser == null)
                return false;
            else
                return true;
        }

        public int CreateNewUser()
        {
            string email = $"{Guid.NewGuid().ToString().Substring(0, 8)}@test123.com";
            string displayName = $"{Guid.NewGuid().ToString().Substring(0, 8)}";
            string password = $"P@ss{Guid.NewGuid().ToString().Substring(0, 4)}";
            short yearOfBirth = 1992;

            List<UserEntity> newUser = new List<UserEntity>()
            {
                new UserEntity(){

                    UserId = 0,
                    Email = email,
                    DisplayName = displayName,
                    Password = password,
                    YearOfBirth = yearOfBirth
                }
            };

            _userEntities.AddRange(newUser);
            _context.SaveChanges();

            var userId = newUser.First().UserId;
            return userId;
        }

    }
}