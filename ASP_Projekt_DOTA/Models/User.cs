using System.ComponentModel.DataAnnotations;

namespace ASP_Projekt_DOTA.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Nickname { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }
    }
}
