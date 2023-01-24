using System.ComponentModel.DataAnnotations;

namespace ASP_Projekt_DOTA.Models
{
    public class Item
    {
        [Key]
        public int ItemId { get; set; }

        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string ItemStats { get; set; }
        public int ItemCost { get; set; }
    }
}
