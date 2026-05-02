using NiaHub_API.Models.Ads;
using NiaHub_API.Models.Users;

namespace NiaHub_API.Repository
{
    public static class FakeData
    {
        private static List<User> users = new List<User>
        {
            new User
            {
                Id = Guid.NewGuid(),
                Username = "Kamel",
                Email = "kamel@niahub.com",
                Instruments = new List<InstrumentType> { InstrumentType.Drums },
                Level = Models.Users.SkillLevel.Intermediate.ToString(),
                Bio = "Batteur passionné"
            },
            new User
            {
                Id = Guid.NewGuid(),
                Username = "asso_espoir",
                Email = "contact@espoircoeur.com",
                Bio = "Association caritative"
            },
            new User
            {
                Id = Guid.NewGuid(),
                Username = "bar_le_duc",
                Email = "contact@barleduc.com",
                Bio = "Bar convivial organisant des événements"
            }
        };

            public static List<JamSessionAd> Ads = new();

            public static void SeedAds()
            {
                if (Ads.Any()) return;

                var kamel = users.First(u => u.Username == "Kamel");
                var asso = users.First(u => u.Username == "asso_espoir");
                var bar = users.First(u => u.Username == "bar_le_duc");

            // 1️⃣ Session répétition classique
            Ads.Add(new JamSessionAd
            {
                Id = Guid.NewGuid(),
                CreatorId = kamel.Id,
                Creator = kamel,

                Title = "Session répétition morceau classique",
                Type = AdType.MusicianSearch,
                ShortDescription = "Batteur intermédiaire cherche musiciens pour répéter des classiques tous styles.",

                Location = new LocationInfo
                {
                    City = "Mulhouse",
                    VenueName = "Studio aménagé chez moi"
                },

                Schedule = new ScheduleInfo
                {
                    Recurrence = "À définir",
                    DurationMinutes = 60
                },

                ExactDate = null,
                MaxParticipants = 5,

                Music = new MusicInfo
                {
                    Styles = new List<MusicStyle> { MusicStyle.Rock, MusicStyle.Jazz },
                    Types = new List<MusicType> { MusicType.Cover }
                },

                ParticipantRequirements = new ParticipantRequirements
                {
                    InstrumentsNeeded = new List<string> { "Basse", "Guitare", "Synthé" },
                    MinimumLevel = Models.Ads.SkillLevel.Intermediate.ToString()
                }
            });

                // 2️⃣ Travail au feeling
                Ads.Add(new JamSessionAd
                {
                    Id = Guid.NewGuid(),
                    CreatorId = kamel.Id,
                    Creator = kamel,

                    Title = "Travail au feeling",
                    Type = AdType.MusicianSearch,
                    ShortDescription = "Batteur cherche bassiste pour jam libre sans morceaux définis.",

                    Location = new LocationInfo
                    {
                        City = "Mulhouse",
                        VenueName = "Chez moi"
                    },

                    Schedule = new ScheduleInfo
                    {
                        StartTime = new TimeSpan(18, 0, 0),
                        DurationMinutes = 60
                    },

                    ExactDate = new DateTime(2026, 4, 23),
                    MaxParticipants = 2,

                    Music = new MusicInfo
                    {
                        Styles = new List<MusicStyle> { MusicStyle.Rock },
                        Types = new List<MusicType> { MusicType.Improvisation }
                    },

                    ParticipantRequirements = new ParticipantRequirements
                    {
                        InstrumentsNeeded = new List<string> { "Basse" },
                        MinimumLevel = Models.Ads.SkillLevel.Intermediate.ToString(),
                    }
                });

                // 3️⃣ Soirée associative
                Ads.Add(new JamSessionAd
                {
                    Id = Guid.NewGuid(),
                    CreatorId = asso.Id,
                    Creator = asso,

                    Title = "Animation soirée associative",
                    Type = AdType.MusicianSearch,
                    ShortDescription = "Recherche musiciens pour animer une soirée caritative (rémunération au chapeau).",

                    Location = new LocationInfo
                    {
                        City = "Strasbourg",
                        VenueName = "Association l'espoir du coeur"
                    },

                    Schedule = new ScheduleInfo
                    {
                        StartTime = new TimeSpan(20, 0, 0),
                        DurationMinutes = 60
                    },

                    ExactDate = new DateTime(2026, 4, 23),
                    MaxParticipants = 5,
                    Compensation = "Au chapeau",

                    Music = new MusicInfo
                    {
                        Styles = new List<MusicStyle>
                    {
                        MusicStyle.Pop,
                        MusicStyle.Rock,
                        MusicStyle.Jazz
                    },
                        Types = new List<MusicType>
                    {
                        MusicType.Composition,
                        MusicType.Cover
                    }
                    },

                    ParticipantRequirements = new ParticipantRequirements
                    {
                        InstrumentsNeeded = new List<string>
                    {
                        "Basse", "Batterie", "Synthé", "Guitare"
                    }
                    },

                    Equipment = new EquipmentInfo
                    {
                        Provided = new List<string>
                    {
                        "Sono", "Table de mixage"
                    }
                    }
                });

                // 4️⃣ Recherche synthé
                Ads.Add(new JamSessionAd
                {
                    Id = Guid.NewGuid(),
                    CreatorId = kamel.Id,
                    Creator = kamel,

                    Title = "Recherche joueur de synthé",
                    Type = AdType.MusicianSearch,
                    ShortDescription = "Groupe amateur cherche synthé pour jam reggae.",
                    DetailedDescription = "Nous cherchons un bon joueur de sythé pour venir nous accompager, nous sommes un groupe très dynamique et investit dans ce que nous faisons. Nous recherchons une personne sérieuse et fiable. Nous pouvons répéter au bar café le Timosa, il sera fermé au public à ce moment",

                    Location = new LocationInfo
                    {
                        City = "Paris",
                        VenueName = "Bar café le Timosa"
                    },

                    Schedule = new ScheduleInfo
                    {
                        Recurrence = "Tous les dimanches",
                        StartTime = new TimeSpan(16, 0, 0),
                        DurationMinutes = 120
                    },

                    MaxParticipants = null,

                    Music = new MusicInfo
                    {
                        Styles = new List<MusicStyle> { MusicStyle.Reggae },
                        Types = new List<MusicType> { MusicType.Composition }
                    },

                    ParticipantRequirements = new ParticipantRequirements
                    {
                        InstrumentsNeeded = new List<string> { "Synthé" },
                        MinimumLevel = Models.Ads.SkillLevel.Intermediate.ToString()    
                    }
                });

                // 5️⃣ Bar recherche musiciens
                Ads.Add(new JamSessionAd
                {
                    Id = Guid.NewGuid(),
                    CreatorId = bar.Id,
                    Creator = bar,

                    Title = "Bar recherche musiciens amateurs",
                    Type = AdType.MusicianSearch,
                    ShortDescription = "Bar cherche musiciens pour jouer en soirée devant public.",

                    Location = new LocationInfo
                    {
                        City = "Nancy",
                        VenueName = "Bar Le Duc"
                    },

                    Schedule = new ScheduleInfo
                    {
                        StartTime = new TimeSpan(21, 0, 0)
                    },

                    ExactDate = new DateTime(2026, 5, 1),

                    Music = new MusicInfo
                    {
                        Styles = new List<MusicStyle> { MusicStyle.Rock },
                        Types = new List<MusicType>
                        {
                            MusicType.Composition,
                            MusicType.Cover
                        }
                    },

                    Equipment = new EquipmentInfo
                    {
                        Provided = new List<string>
                        {
                            "Sono",
                            "Batterie acoustique",
                            "Jeux de lumière",
                            "Table de mixage"
                        }
                    },

                    ParticipantRequirements = new ParticipantRequirements
                    {
                        InstrumentsNeeded = new List<string> { "batterie, bass, guitare" },
                        MinimumLevel = Models.Ads.SkillLevel.Intermediate.ToString()
                    }
                });
            // Recherche d'un chanteur
                Ads.Add(new JamSessionAd
                {
                    Id = Guid.NewGuid(),
                    CreatorId = kamel.Id,
                    Creator = kamel,

                    Title = "Recherche d'une voix",
                    Type = AdType.OpenMic,
                    ShortDescription = "Groupe amateur cherche un chanteur de de hardrock pour éventuellement monter un groupe de musique",

                    Location = new LocationInfo
                    {
                        City = "Marseille",
                        VenueName = "Dans un studio "
                    },

                    Schedule = new ScheduleInfo
                    {
                        Recurrence = "Tous les vendredi",
                        StartTime = new TimeSpan(20, 0, 0),
                        DurationMinutes = 120
                    },

                    MaxParticipants = 1,

                    Music = new MusicInfo
                    {
                        Styles = new List<MusicStyle> { MusicStyle.HardRock },
                        Types = new List<MusicType> { MusicType.Composition }
                    },

                    ParticipantRequirements = new ParticipantRequirements
                    {
                        MinimumLevel = Models.Ads.SkillLevel.Advanced.ToString()
                    }
                });
            // Jam Session Basel 
            Ads.Add(new JamSessionAd
            {
                Id = Guid.NewGuid(),
                CreatorId = kamel.Id,
                Creator = kamel,

                Title = "Jam session",
                Type = AdType.JamSession,
                ShortDescription = "Every Sunday during the summer, come join our jam session on the banks of the Rhine in Basel",
                DetailedDescription = "🎵 Join us for a vibrant afternoon of music! 🎵\r\nSing and play your favorite pop and rock hits in a friendly and open environment. Whether you're a musician, singer, or just love listening to live music - everyone is welcome!\r\n\r\n🎶 Jam Agenda:\r\n1️⃣ 15:00–16:30 – Vocal warm- up, Jam & Learn New Songs Together with Jenny\r\n\r\nLearn new songs together. If you want to bring along a song, please print a few copies with tabs and lyrics. We will also play songs from our songbook.\r\n2️⃣ 16:30–17:00 – Open Mic & Break/Social Time\r\n\r\nPerform your own song or favorite cover.\r\nGrab a drink and connect with fellow participants. A great chance to make new music friends! 🎶\r\n3️⃣ 17:00–19:00 – Jam\r\n\r\nWe play songs from the songbook and simply jam \U0001f973🎉\r\n🎸 What to Bring:\r\n\r\nYour voice or any instrument: ukulele, saxophone, harmonica, violin, guitar, flute, percussion, etc.\r\nA music stand for the songbook (optional).\r\nOr just come to listen and enjoy drinks from the bar!\r\nNote: A piano and printed songbooks with chords and lyrics are available for everyone.\r\n\r\n🎤 Musical Styles:\r\nPop | Rock | Soul | Folk | Reggae | Country | Indie\r\n🎶 Expect hits from Adele, Queen, Nirvana, The Beatles, RHCP, Amy Winehouse, U2, Bob Dylan, Bob Marley, Radiohead, and more!\r\n\r\n📢 Invite your friends—musicians and music lovers alike!\r\nLet’s create a warm and vibrant musical atmosphere together.\r\n\r\n📹 New to the Group?\r\nCheck out our 2025 annual review video 2025: https://www.youtube.com/watch?v=bJ6DF6obcIU\r\n\r\nNote: Participants join from various platforms, including our LoLa Jam Session WhatsApp group.",

                Location = new LocationInfo
                {
                    City = "Bâle",
                    VenueName = "Outside, along the Rhine"
                },

                Schedule = new ScheduleInfo
                {
                    Recurrence = "Every Sunday",
                    StartTime = new TimeSpan(14, 0, 0),
                    DurationMinutes = 240
                },

                MaxParticipants = 1,

                Music = new MusicInfo
                {
                    Styles = new List<MusicStyle> { MusicStyle.Pop, MusicStyle.Reggae, MusicStyle.Blues },
                    Types = new List<MusicType> { MusicType.Cover }
                },

                ParticipantRequirements = new ParticipantRequirements
                {
                    MinimumLevel = Models.Ads.SkillLevel.Beginner.ToString(),
                }
            });
            // Jam session Djembe
            Ads.Add(new JamSessionAd
            {
                Id = Guid.NewGuid(),
                CreatorId = kamel.Id,
                Creator = kamel,

                Title = "Jam session musique trad africaine",
                Type = AdType.JamSession,
                ShortDescription = "Joueurs amateurs de djembé, nous proposons de jouer ensemble",

                Location = new LocationInfo
                {
                    City = "Mulhouse",
                    VenueName = "Maison des berges"
                },

                Schedule = new ScheduleInfo
                {
                    Date = new DateTime(2026, 4, 26),
                    StartTime = new TimeSpan(14, 0, 0),
                    DurationMinutes = 120
                },

                MaxParticipants = 10,

                Music = new MusicInfo
                {

                    Styles = new List<MusicStyle> { MusicStyle.Afro},
                    Types = new List<MusicType> { MusicType.Cover }
                },

                ParticipantRequirements = new ParticipantRequirements
                {
                    MinimumLevel = Models.Ads.SkillLevel.Beginner.ToString(),
                },

                 Equipment = new EquipmentInfo
                 {
                     Provided = new List<string>
                        {
                            "DunDun",
                            "4 djembés"
                        }
                 },
            });
        }
    }

}
