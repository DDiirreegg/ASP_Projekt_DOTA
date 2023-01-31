using System.ComponentModel.DataAnnotations;

namespace ASP_Projekt_DOTA.Models
{
    public class Cart
    {
        [Key]
        public int DecorId { get; set; }
        public Decoration Decoration { get; set; }
        public double Price { get; set; }
        public string ShopDecorId { get; set; }
    }
}
