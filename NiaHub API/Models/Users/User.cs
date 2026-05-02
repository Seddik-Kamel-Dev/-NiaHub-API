
namespace NiaHub_API.Models.Users
{
    public class User
    {
        public Guid Id { get; set; }

        public string Username { get; set; }
        public string Email { get; set; }

        // Profil musical
        public List<InstrumentType> Instruments { get; set; } = new();
        public string Level { get; set; } = string.Empty;
         
        // Social (future-proof)
        public string Bio { get; set; }

        // Métadonnées
        public DateTime CreatedAt { get; set; }
    }

    public enum SkillLevel
    {
        Beginner,
        Intermediate,
        Advanced,
        Professional
    }

    public enum InstrumentType
    {
        Guitar,
        Bass,
        Drums,
        Piano,
        Vocals,
        DJ,
        Violin,
        Saxophone,
        Other
    }
}
