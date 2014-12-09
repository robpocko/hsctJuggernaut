using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jabberwocky.EF.Library.Models
{
    public class JuggernautUser
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Given Name must be no longer than 50 characters")]
        public string GivenName { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Surname must be no longer than 50 characters")]
        public string Surname { get; set; }

        [Required]
        [MaxLength(15, ErrorMessage = "Username must be no longer than 15 characters")]
        public string UserName { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        [Required]
        public DateTime ActiveFrom { get; set; }

        public DateTime? ActiveUntil { get; set; }
    }
}
