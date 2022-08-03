using ChocoStorageAPI.Enums;
using System.ComponentModel.DataAnnotations;

namespace ChocoStorageAPI.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(32)]
        public string? Name { get; set; }
        [MaxLength(32)]
        public string? SurName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string UserName { get; set; }
        public UserTypes Role { get; set; }

    }
}
