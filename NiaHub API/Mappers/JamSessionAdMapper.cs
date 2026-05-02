using NiaHub_API.DTOs;
using NiaHub_API.Models.Ads;
using NiaHub_API.Models.Users;

namespace NiaHub_API.Mappers
{
    public static class JamSessionAdMapper
    {
        public static JamSessionAdDto ToDto(JamSessionAd ad)
        {
            return new JamSessionAdDto
            {
                Id = ad.Id,
                Title = ad.Title,
                ShortDescription = ad.ShortDescription,
                DetailedDesciption = ad.DetailedDescription,

                CreatorUsername = ad.Creator?.Username,

                City = ad.Location?.City,
                VenueName = ad.Location?.VenueName,

                Recurrence = ad.Schedule?.Recurrence,
                StartTime = ad.Schedule?.StartTime ?? TimeSpan.Zero,
                DurationMinutes = ad.Schedule?.DurationMinutes ?? 0,

                Styles = ad.Music?.Styles?.Select(s => s.ToString()).ToList(),

                InstrumentsNeeded = ad.ParticipantRequirements?.InstrumentsNeeded,
                MinimumLevel = ad.ParticipantRequirements?.MinimumLevel.ToString(),

                EquipmentProvided = ad.Equipment?.Provided,

                MaxParticipants = ad.MaxParticipants,
                Compensation = ad.Compensation

            };
        }
    }
}
