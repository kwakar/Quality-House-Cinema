using System;
using System.ComponentModel.DataAnnotations;

namespace QualityCinemaAccess.Entities
{
    public class UserEntity
    {
        [Key]
        public int UserId { get; set; }

        public string DisplayName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
        
        public Int16 YearOfBirth { get; set; }
    }
}