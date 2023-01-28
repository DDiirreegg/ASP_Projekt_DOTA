namespace ASP_Projekt_DOTA.Models
{
    public class Decoration_Character
    {
        public int DecorationId { get; set; }
        public Decoration Decoration { get; set; }

        public int CharacterId { get; set; }
        public Character Character { get; set; }
    }
}
