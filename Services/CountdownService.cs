using System;
using System.Collections.Generic;
using System.Linq;
using GrandPrixRadio.Models;

namespace GrandPrixRadio.Services
{
    public class CountdownService : ICountdownService
    {
        private readonly List<RaceEvent> raceEvents = new List<RaceEvent>();

        public CountdownService()
        {
            InitializeEvents();
        }
        public RaceEvent GetNextRaceEvent(DateTime now)
        {
            return raceEvents.Where(r => r.R > now).OrderBy(r => r.Id).FirstOrDefault();
        }

        private void InitializeEvents()
        {
            raceEvents.Add(new RaceEvent
            {
                Id = 1,
                FullName = "Formula 1 Gulf Air Bahrain Grand Prix 2023",
                FP1 = new DateTime(2023, 03, 03, 12, 30, 0),
                FP2 = new DateTime(2023, 03, 03, 16, 0, 0),
                FP3 = new DateTime(2023, 03, 04, 12, 30, 0),
                Q = new DateTime(2023, 03, 04, 16, 0, 0),
                R = new DateTime(2023, 03, 05, 16, 0, 0),
                FlagImageName = "/Assets/Flags/bah.png"
            });

            raceEvents.Add(new RaceEvent
            {
                Id = 2,
                FullName = "Formula 1 STC Saudi Arabian Grand Prix 2023",
                FP1 = new DateTime(2023, 03, 17, 14, 30, 0),
                FP2 = new DateTime(2023, 03, 17, 18, 0, 0),
                FP3 = new DateTime(2023, 03, 18, 14, 30, 0),
                Q = new DateTime(2023, 03, 18, 18, 0, 0),
                R = new DateTime(2023, 03, 19, 18, 0, 0),
                FlagImageName = "/Assets/Flags/sau.png"
            });

            raceEvents.Add(new RaceEvent
            {
                Id = 3,
                FullName = "Formula 1 Rolex Australian Grand Prix 2023",
                FP1 = new DateTime(2023, 03, 31, 03, 30, 0),
                FP2 = new DateTime(2023, 03, 31, 07, 0, 0),
                FP3 = new DateTime(2023, 04, 01, 03, 30, 0),
                Q = new DateTime(2023, 04, 01, 07, 0, 0),
                R = new DateTime(2023, 04, 02, 07, 0, 0),
                FlagImageName = "/Assets/Flags/aus.png"
            });

           

            raceEvents.Add(new RaceEvent
            {
                Id = 5,
                FullName = "Formula 1 Azerbaijan Grand Prix 2023",
                FP1 = new DateTime(2023, 04, 28, 11, 30, 0),
                FP2 = new DateTime(2023, 04, 28, 15, 0, 0),
                FP3 = new DateTime(2023, 04, 29, 11, 30, 0),
                Q = new DateTime(2023, 04, 29, 15, 20, 0),
                R = new DateTime(2023, 04, 30, 13, 0, 0),
                FlagImageName = "/Assets/Flags/aze.png",
                HasSprintRace= true,
            });

            raceEvents.Add(new RaceEvent
            {
                Id = 6,
                FullName = "Formula 1 Crypto.com Miami Grand Prix 2023",
                FP1 = new DateTime(2023, 05, 05, 19, 30, 0),
                FP2 = new DateTime(2023, 05, 05, 23, 0, 0),
                FP3 = new DateTime(2023, 05, 06, 18, 30, 0),
                Q = new DateTime(2023, 05, 06, 22, 0, 0),
                R = new DateTime(2023, 05, 07, 21, 30, 0),
                FlagImageName = "/Assets/Flags/usa.png"
            });

            raceEvents.Add(new RaceEvent
            {
                Id = 7,
                FullName = "Formula 1 Gran Premio Dell'Emilia-Romagna 2023",
                FP1 = new DateTime(2023, 05, 19, 13, 30, 0),
                FP2 = new DateTime(2023, 05, 19, 17, 0, 0),
                FP3 = new DateTime(2023, 05, 20, 12, 30, 0),
                Q = new DateTime(2023, 05, 20, 16, 0, 0),
                R = new DateTime(2023, 05, 21, 15, 0, 0),
                FlagImageName = "/Assets/Flags/ita.png",
            });

            raceEvents.Add(new RaceEvent
            {
                Id = 8,
                FullName = "Formula 1 Grand Prix de Monaco 2023",
                FP1 = new DateTime(2023, 05, 26, 13, 30, 0),
                FP2 = new DateTime(2023, 05, 26, 17, 0, 0),
                FP3 = new DateTime(2023, 05, 27, 12, 30, 0),
                Q = new DateTime(2023, 05, 27, 16, 0, 0),
                R = new DateTime(2023, 05, 28, 15, 0, 0),
                FlagImageName = "/Assets/Flags/mon.png"
            });

            raceEvents.Add(new RaceEvent
            {
                Id = 9,
                FullName = "Formula 1 Gran Premio de Espana 2023",
                FP1 = new DateTime(2023, 06, 2, 13, 30, 0),
                FP2 = new DateTime(2023, 06, 2, 17, 0, 0),
                FP3 = new DateTime(2023, 06, 3, 12, 30, 0),
                Q = new DateTime(2023, 06, 3, 16, 0, 0),
                R = new DateTime(2023, 06, 4, 15, 0, 0),
                FlagImageName = "/Assets/Flags/spa.png"
            });

            raceEvents.Add(new RaceEvent
            {
                Id = 10,
                FullName = "Formula 1 Grand Prix du Canada 2023",
                FP1 = new DateTime(2023, 06, 16, 19, 30, 0),
                FP2 = new DateTime(2023, 06, 16, 23, 0, 0),
                FP3 = new DateTime(2023, 06, 17, 18, 30, 0),
                Q = new DateTime(2023, 06, 17, 22, 0, 0),
                R = new DateTime(2023, 06, 18, 20, 0, 0),
                FlagImageName = "/Assets/Flags/can.png"
            });

            raceEvents.Add(new RaceEvent
            {
                Id = 11,
                FullName = "Formula 1 Grosser Preis von Österreich 2023",
                FP1 = new DateTime(2023, 06, 30, 13, 30, 0),
                FP2 = new DateTime(2023, 06, 30, 17, 0, 0),
                FP3 = new DateTime(2023, 07, 1, 12, 30, 0),
                Q = new DateTime(2023, 07, 1, 16, 30, 0),
                R = new DateTime(2023, 07, 2, 15, 0, 0),
                FlagImageName = "/Assets/Flags/oos.png",
                HasSprintRace = true
            });

            raceEvents.Add(new RaceEvent
            {
                Id = 12,
                FullName = "Formula 1 Aramco British Grand Prix 2023",
                FP1 = new DateTime(2023, 07, 07, 13, 30, 0),
                FP2 = new DateTime(2023, 07, 07, 17, 0, 0),
                FP3 = new DateTime(2023, 07, 08, 12, 30, 0),
                Q = new DateTime(2023, 07, 08, 15, 0, 0),
                R = new DateTime(2023, 07, 09, 16, 0, 0),
                FlagImageName = "/Assets/Flags/uk.png"
            });

            raceEvents.Add(new RaceEvent
            {
                Id = 13,
                FullName = "Formula 1 Hungarian Grand Prix 2023",
                FP1 = new DateTime(2023, 07, 21, 13, 30, 0),
                FP2 = new DateTime(2023, 07, 21, 17, 0, 0),
                FP3 = new DateTime(2023, 07, 22, 12, 30, 0),
                Q = new DateTime(2023, 07, 22, 16, 0, 0),
                R = new DateTime(2023, 07, 23, 15, 0, 0),
                FlagImageName = "/Assets/Flags/hun.png"
            });

            raceEvents.Add(new RaceEvent
            {
                Id = 14,
                FullName = "Formula 1 Belgian Grand Prix 2023",
                FP1 = new DateTime(2023, 07, 28, 13, 30, 0),
                FP2 = new DateTime(2023, 07, 28, 17, 0, 0),
                FP3 = new DateTime(2023, 07, 29, 12, 30, 0),
                Q = new DateTime(2023, 07, 29, 16, 30, 0),
                R = new DateTime(2023, 07, 30, 15, 0, 0),
                FlagImageName = "/Assets/Flags/bel.png",
                HasSprintRace= true
            });

            raceEvents.Add(new RaceEvent
            {
                Id = 15,
                FullName = "Formula 1 Heineken Dutch Grand Prix 2023",
                FP1 = new DateTime(2023, 08, 25, 12,30, 0),
                FP2 = new DateTime(2023, 08, 25, 16, 0, 0),
                FP3 = new DateTime(2023, 08, 26, 11, 30, 0),
                Q = new DateTime(2023, 08, 26, 15, 0, 0),
                R = new DateTime(2023, 08, 27, 15, 0, 0),
                FlagImageName = "/Assets/Flags/net.png"
            });

            raceEvents.Add(new RaceEvent
            {
                Id = 16,
                FullName = "Formula 1 Gran Premio d’Italia 2023",
                FP1 = new DateTime(2023, 09, 01, 13, 30, 0),
                FP2 = new DateTime(2023, 09, 01, 17, 0, 0),
                FP3 = new DateTime(2023, 09, 02, 12, 30, 0),
                Q = new DateTime(2023, 09, 02, 15, 0, 0),
                R = new DateTime(2023, 09, 03, 15, 0, 0),
                FlagImageName = "/Assets/Flags/ita.png"
            });

            raceEvents.Add(new RaceEvent
            {
                Id = 17,
                FullName = "Formula 1 Singapore Airlines Singapore Grand Prix 2023",
                FP1 = new DateTime(2023, 09, 15, 11, 30, 0),
                FP2 = new DateTime(2023, 09, 15, 15, 0, 0),
                FP3 = new DateTime(2023, 09, 16, 11, 30, 0),
                Q = new DateTime(2023, 09, 16, 15, 0, 0),
                R = new DateTime(2023, 09, 17, 14, 0, 0),
                FlagImageName = "/Assets/Flags/sin.png"
            });

            raceEvents.Add(new RaceEvent
            {
                Id = 18,
                FullName = "Formula 1 Lenovo Japanese Grand Prix 2023",
                FP1 = new DateTime(2023, 09, 22, 4, 30, 0),
                FP2 = new DateTime(2023, 09, 22, 8, 0, 0),
                FP3 = new DateTime(2023, 09, 23, 4, 30, 0),
                Q = new DateTime(2023, 09, 23, 8, 0, 0),
                R = new DateTime(2023, 09, 24, 7, 0, 0),
                FlagImageName = "/Assets/Flags/jap.png"
            });

            raceEvents.Add(new RaceEvent
            {
                Id = 19,
                FullName = "Formula 1 Qatar Grand Prix 2023",
                FP1 = new DateTime(2023, 10, 6, 12, 30, 0),
                FP2 = new DateTime(2023, 10, 6, 16, 0, 0),
                FP3 = new DateTime(2023, 10, 7, 12, 30, 0),
                Q = new DateTime(2023, 10, 7, 16, 30, 0),
                R = new DateTime(2023, 10, 8, 16, 0, 0),
                FlagImageName = "/Assets/Flags/qat.png",
                HasSprintRace= true
            });

            raceEvents.Add(new RaceEvent
            {
                Id = 20,
                FullName = "Formula 1 Lenovo United States Grand Prix 2023",
                FP1 = new DateTime(2023, 10, 20, 19, 30, 0),
                FP2 = new DateTime(2023, 10, 20, 23, 0, 0),
                FP3 = new DateTime(2023, 10, 21, 20, 0, 0),
                Q = new DateTime(2023, 10, 22, 0, 0, 0),
                R = new DateTime(2023, 10, 22, 21, 0, 0),
                FlagImageName = "/Assets/Flags/usa.png",
                HasSprintRace= true
            });

            raceEvents.Add(new RaceEvent
            {
                Id = 21,
                FullName = "Formula 1 Gran Premio de la Ciudad de Mexico 2023",
                FP1 = new DateTime(2023, 10, 27, 20, 30, 0),
                FP2 = new DateTime(2023, 10, 28, 0, 0, 0),
                FP3 = new DateTime(2023, 10, 28, 19, 30, 0),
                Q = new DateTime(2023, 10, 28, 23, 0, 0),
                R = new DateTime(2023, 10, 29, 21, 0, 0),
                FlagImageName = "/Assets/Flags/mex.png"
            });

            raceEvents.Add(new RaceEvent
            {
                Id = 22,
                FullName = "Formula 1 Rolex Grande Premio de Sao Paulo 2023",
                FP1 = new DateTime(2023, 11, 3, 15, 30, 0),
                FP2 = new DateTime(2023, 11, 3, 19, 0, 0),
                FP3 = new DateTime(2023, 11, 4, 15, 30, 0),
                Q = new DateTime(2023, 11, 4, 19, 30, 0),
                R = new DateTime(2023, 11, 5, 18, 0, 0),
                FlagImageName = "/Assets/Flags/bra.png",
                HasSprintRace = true
            });

            raceEvents.Add(new RaceEvent
            {
                Id = 23,
                FullName = "Formula 1 Heineken Silver Las Vegas Grand Prix 2023",
                FP1 = new DateTime(2023, 11, 17, 3, 30, 0),
                FP2 = new DateTime(2023, 11, 17, 7, 0, 0),
                FP3 = new DateTime(2023, 11, 18, 3, 30, 0),
                Q = new DateTime(2023, 11, 18, 7, 0, 0),
                R = new DateTime(2023, 11, 19, 7, 0, 0),
                FlagImageName = "/Assets/Flags/usa.png",
            });

            raceEvents.Add(new RaceEvent
            {
                Id = 24,
                FullName = "Formula 1 Etihad Airways Abu Dhabi Grand Prix 2023",
                FP1 = new DateTime(2023, 11, 24, 10, 30, 0),
                FP2 = new DateTime(2023, 11, 24, 14, 0, 0),
                FP3 = new DateTime(2023, 11, 25, 11, 30, 0),
                Q = new DateTime(2023, 11, 25, 15, 0, 0),
                R = new DateTime(2023, 11, 26, 14, 0, 0),
                FlagImageName = "/Assets/Flags/uae.png"
            });
        }
    }
}
