using System.ComponentModel.DataAnnotations;

namespace ASP_Projekt_DOTA.Models
{
    public class Decoration
    {
        [Key]
        public int DecorationId { get; set; }

        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string CharacterName { get; set; }
        public double DecorationPrice { get; set; }

    }
}
