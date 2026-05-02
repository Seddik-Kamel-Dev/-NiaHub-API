
using NiaHub_API.Models.Users;

namespace NiaHub_API.Models.Ads
{
    public class JamSessionAd
    {
        public Guid Id { get; set; }

        public Guid CreatorId { get; set; }
        public User Creator { get; set; } = null!;

        public string Title { get; set; } = string.Empty;
        public AdType Type { get; set; }
        public string ShortDescription { get; set; } = string.Empty;
        public string DetailedDescription { get; set; } = string.Empty;

        public LocationInfo Location { get; set; } = new();
        public ScheduleInfo Schedule { get; set; } = new();
        public MusicInfo Music { get; set; } = new();

        public ParticipantRequirements? ParticipantRequirements { get; set; }
        public WorkOrganization? WorkOrganization { get; set; }
        public EventDetails? EventDetails { get; set; }
        public EquipmentInfo? Equipment { get; set; }

        public ContactInfo Contact { get; set; } = new();

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? ExactDate { get; internal set; }
        public int? MaxParticipants { get; internal set; }
        public string? Compensation { get; internal set; }
    }

    public class LocationInfo
    {
        public string City { get; set; } = string.Empty;
        public string? VenueName { get; set; }
        public string? Address { get; set; }
        public VenueType? VenueType { get; set; }
    }

    public class ScheduleInfo
    {
        public DateTime? Date { get; set; }
        public string? Recurrence { get; set; } // ex: "Tous les dimanches"
        public TimeSpan StartTime { get; set; }
        public int? DurationMinutes { get; set; }
    }

    public class MusicInfo
    {
        public List<MusicStyle> Styles { get; set; } = new();
        public List<MusicType> Types { get; set; } = new();
        public string? Goal { get; set; } // Jam détente, scène, enregistrement
    }

    public class ParticipantRequirements
    {
        public List<string> InstrumentsNeeded { get; set; } = new();
        public string MinimumLevel { get; set; } = string.Empty;
        public int? NumberOfPeople { get; set; }
    }

    public class WorkOrganization
    {
        public WorkMethod? Method { get; set; }
        public string? Expectations { get; set; }
    }

    public class EventDetails
    {
        public string? EventType { get; set; } // ex: "Soirée célibataires"
        public string? Audience { get; set; }
        public string? Compensation { get; set; }
    }

    public class EquipmentInfo
    {
        public List<string> Provided { get; set; } = new();
        public List<string>? Required { get; set; }
    }

    public class ContactInfo
    {
        public string Name { get; set; } = string.Empty;
        public string? Email { get; set; }
        public string? Phone { get; set; }
    }

    public enum AdType
    {
        JamSession,
        MusicianSearch,
        Concert,
        OpenMic,
        BarEvent
    }

    public enum VenueType
    {
        Bar,
        Studio,
        Home,
        ConcertHall,
        Outdoor
    }

    public enum SkillLevel
    {
        Beginner,
        Intermediate,
        Advanced,
        Professional
    }

    public enum MusicStyle
    {
        Rock,
        Jazz,
        Reggae,
        Blues,
        Funk,
        Pop,
        Classical,
        Afro,
        Electro,
        Other,
        HardRock
    }

    public enum MusicType
    {
        Composition,
        Cover,
        Improvisation,
        Mixed
    }

    public enum WorkMethod
    {
        ByEar,
        SheetMusic,
        ChordsGrid,
        FreeJam
    }
}
