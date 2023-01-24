using ASP_Projekt_DOTA.Date;
using System.ComponentModel.DataAnnotations;

namespace ASP_Projekt_DOTA.Models
{
    public class Character
    {
        [Key]
        public int CharacterId { get; set; }

        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public int ForceAttributes { get; set; }
        public int AgilityAttributes { get; set; }
        public int IntelligenceAttributes { get; set; }
        public CharacterRole Role { get; set; }
        public string Bio { get; set; }        


    }
}
