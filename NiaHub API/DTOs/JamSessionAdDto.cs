using NiaHub_API.Models.Ads;

namespace NiaHub_API.DTOs
{
    public class JamSessionAdDto
    {
        public Guid Id { get; set; }

        public string Title { get; set; } = string.Empty;
        public string ShortDescription { get; set; } = string.Empty;
        public string DetailedDesciption { get; set; } = string.Empty;

        // Creator
        public string CreatorUsername { get; set; } = string.Empty;

        // Location
        public string City { get; set; } = string.Empty;
        public string VenueName { get; set; } = string.Empty;

        // Schedule
        public string Recurrence { get; set; } = string.Empty;
        public TimeSpan StartTime { get; set; }
        public int DurationMinutes { get; set; }

        // Music
        public List<string> Styles { get; set; }

        // Requirements
        public List<string> InstrumentsNeeded { get; set; } 
        public string? MinimumLevel { get; set; }

        public List<string> EquipmentProvided { get; set; }

        public int? MaxParticipants { get; set; }
        public string? Compensation { get; set; }
    }
}
