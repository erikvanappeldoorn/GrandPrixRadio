using System;
using System.Collections.Generic;
using System.Linq;
using GrandPrixRadio.Models;

namespace GrandPrixRadio.Services;

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
            FullName = "Formula 1 Gulf Air Bahrain Grand Prix 2022",
            FP1 = new DateTime(2022, 03, 18, 13, 0, 0),
            FP2 = new DateTime(2022, 03, 18, 16, 0, 0),
            FP3 = new DateTime(2022, 03, 19, 13, 0, 0),
            Q = new DateTime(2022, 03, 19, 16, 0, 0),
            R = new DateTime(2022, 03, 20, 16, 0, 0),
            FlagImageName = "/Assets/Flags/bah.png",
            HasSprintRace = false,
        });

        raceEvents.Add(new RaceEvent
        {
            Id = 2,
            FullName = "Formula 1 STC Saudi Arabian Grand Prix 2022",
            FP1 = new DateTime(2022, 03, 25, 15, 0, 0),
            FP2 = new DateTime(2022, 03, 25, 18, 0, 0),
            FP3 = new DateTime(2022, 03, 26, 15, 0, 0),
            Q = new DateTime(2022, 03, 26, 18, 0, 0),
            R = new DateTime(2022, 03, 27, 19, 0, 0),
            FlagImageName = "/Assets/Flags/sau.png"
        });

        raceEvents.Add(new RaceEvent
        {
            Id = 3,
            FullName = "Formula 1 Heineken Australian Grand Prix 2022",
            FP1 = new DateTime(2022, 04, 08, 05, 0, 0),
            FP2 = new DateTime(2022, 04, 08, 08, 0, 0),
            FP3 = new DateTime(2022, 04, 09, 05, 0, 0),
            Q = new DateTime(2022, 04, 09, 08, 0, 0),
            R = new DateTime(2022, 04, 10, 07, 0, 0),
            FlagImageName = "/Assets/Flags/aus.png"
        });

        raceEvents.Add(new RaceEvent
        {
            Id = 4,
            FullName = "Formula 1 Rolex Gran Premio Dell'Emilia Romagna 2022",
            FP1 = new DateTime(2022, 04, 22, 13, 30, 0),
            FP2 = new DateTime(2022, 04, 22, 17, 0, 0),
            FP3 = new DateTime(2022, 04, 23, 12, 30, 0),
            Q = new DateTime(2022, 04, 23, 16, 30, 0),
            R = new DateTime(2022, 04, 24, 15, 0, 0),
            FlagImageName = "/Assets/Flags/ita.png",
            HasSprintRace = true
        });

        raceEvents.Add(new RaceEvent
        {
            Id = 5,
            FullName = "Formula 1 Crypto.com Miami Grand Prix 2022",
            FP1 = new DateTime(2022, 05, 06, 20, 30, 0),
            FP2 = new DateTime(2022, 05, 06, 23, 30, 0),
            FP3 = new DateTime(2022, 05, 07, 19, 0, 0),
            Q = new DateTime(2022, 05, 07, 22, 0, 0),
            R = new DateTime(2022, 05, 08, 21, 30, 0),
            FlagImageName = "/Assets/Flags/usa.png"
        });

        raceEvents.Add(new RaceEvent
        {
            Id = 6,
            FullName = "Formula 1 Pirelli Gran Premio de Espana 2022",
            FP1 = new DateTime(2022, 05, 20, 14, 0, 0),
            FP2 = new DateTime(2022, 05, 20, 17, 0, 0),
            FP3 = new DateTime(2022, 05, 21, 13, 0, 0),
            Q = new DateTime(2022, 05, 21, 16, 0, 0),
            R = new DateTime(2022, 05, 22, 15, 0, 0),
            FlagImageName = "/Assets/Flags/spa.png"
        });

        raceEvents.Add(new RaceEvent
        {
            Id = 7,
            FullName = "Formula 1 Grand Prix de Monaco 2022",
            FP1 = new DateTime(2022, 05, 27, 14, 0, 0),
            FP2 = new DateTime(2022, 05, 27, 17, 0, 0),
            FP3 = new DateTime(2022, 05, 28, 13, 0, 0),
            Q = new DateTime(2022, 05, 28, 16, 0, 0),
            R = new DateTime(2022, 05, 29, 15, 0, 0),
            FlagImageName = "/Assets/Flags/mon.png"
        });

        raceEvents.Add(new RaceEvent
        {
            Id = 8,
            FullName = "Formula 1 Azerbaijan Grand Prix 2022",
            FP1 = new DateTime(2022, 06, 10, 13, 0, 0),
            FP2 = new DateTime(2022, 06, 10, 16, 0, 0),
            FP3 = new DateTime(2022, 06, 11, 13, 0, 0),
            Q = new DateTime(2022, 06, 11, 16, 0, 0),
            R = new DateTime(2022, 06, 12, 13, 0, 0),
            FlagImageName = "/Assets/Flags/aze.png"
        });

        raceEvents.Add(new RaceEvent
        {
            Id = 9,
            FullName = "Formula 1 Grand Prix de Canada 2022",
            FP1 = new DateTime(2022, 06, 17, 20, 0, 0),
            FP2 = new DateTime(2022, 06, 17, 23, 0, 0),
            FP3 = new DateTime(2022, 06, 18, 19, 0, 0),
            Q = new DateTime(2022, 06, 18, 22, 0, 0),
            R = new DateTime(2022, 06, 19, 20, 0, 0),
            FlagImageName = "/Assets/Flags/can.png"
        });

        raceEvents.Add(new RaceEvent
        {
            Id = 10,
            FullName = "Formula 1 British Grand Prix 2022",
            FP1 = new DateTime(2022, 07, 01, 14, 0, 0),
            FP2 = new DateTime(2022, 07, 01, 17, 0, 0),
            FP3 = new DateTime(2022, 07, 02, 13, 0, 0),
            Q = new DateTime(2022, 07, 02, 16, 0, 0),
            R = new DateTime(2022, 07, 03, 16, 0, 0),
            FlagImageName = "/Assets/Flags/uk.png"
        });


        raceEvents.Add(new RaceEvent
        {
            Id = 11,
            FullName = "Formula 1 Grosser Preis von Österreich 2022",
            FP1 = new DateTime(2022, 07, 08, 13, 30, 0),
            FP2 = new DateTime(2022, 07, 08, 17, 0, 0),
            FP3 = new DateTime(2022, 07, 09, 12, 30, 0),
            Q = new DateTime(2022, 07, 09, 16, 30, 0),
            R = new DateTime(2022, 07, 10, 15, 0, 0),
            FlagImageName = "/Assets/Flags/oos.png",
            HasSprintRace = true
        });

        raceEvents.Add(new RaceEvent
        {
            Id = 12,
            FullName = "Formula 1 Grand Prix de France 2022",
            FP1 = new DateTime(2022, 07, 22, 14, 0, 0),
            FP2 = new DateTime(2022, 07, 22, 17, 0, 0),
            FP3 = new DateTime(2022, 07, 23, 13, 0, 0),
            Q = new DateTime(2022, 07, 23, 16, 0, 0),
            R = new DateTime(2022, 07, 24, 15, 0, 0),
            FlagImageName = "/Assets/Flags/fra.png"
        });


        raceEvents.Add(new RaceEvent
        {
            Id = 13,
            FullName = "Formula 1 Magyar Nagydij 2022",
            FP1 = new DateTime(2022, 07, 29, 14, 0, 0),
            FP2 = new DateTime(2022, 07, 29, 17, 0, 0),
            FP3 = new DateTime(2022, 07, 30, 13, 0, 0),
            Q = new DateTime(2022, 07, 30, 16, 0, 0),
            R = new DateTime(2022, 07, 31, 15, 0, 0),
            FlagImageName = "/Assets/Flags/hun.png"
        });

        raceEvents.Add(new RaceEvent
        {
            Id = 14,
            FullName = "Formula 1 Rolex Belgian Grand Prix 2022",
            FP1 = new DateTime(2022, 08, 26, 14, 0, 0),
            FP2 = new DateTime(2022, 08, 26, 17, 0, 0),
            FP3 = new DateTime(2022, 08, 27, 13, 0, 0),
            Q = new DateTime(2022, 08, 27, 16, 0, 0),
            R = new DateTime(2022, 08, 28, 15, 0, 0),
            FlagImageName = "/Assets/Flags/bel.png"
        });

        raceEvents.Add(new RaceEvent
        {
            Id = 15,
            FullName = "Formula 1 Heineken Dutch Grand Prix 2022",
            FP1 = new DateTime(2022, 09, 02, 12,30, 0),
            FP2 = new DateTime(2022, 09, 02, 16, 0, 0),
            FP3 = new DateTime(2022, 09, 03, 12, 0, 0),
            Q = new DateTime(2022, 09, 03, 15, 0, 0),
            R = new DateTime(2022, 09, 04, 15, 0, 0),
            FlagImageName = "/Assets/Flags/net.png"
        });

        raceEvents.Add(new RaceEvent
        {
            Id = 16,
            FullName = "Formula 1 Pirelli Gran Premio d’Italia 2022",
            FP1 = new DateTime(2022, 09, 09, 14, 0, 0),
            FP2 = new DateTime(2022, 09, 09, 17, 0, 0),
            FP3 = new DateTime(2022, 09, 10, 13, 0, 0),
            Q = new DateTime(2022, 09, 10, 16, 0, 0),
            R = new DateTime(2022, 09, 11, 15, 0, 0),
            FlagImageName = "/Assets/Flags/ita.png"
        });

        raceEvents.Add(new RaceEvent
        {
            Id = 17,
            FullName = "Formula 1 Singapore Airlines Singapore Grand Prix 2022",
            FP1 = new DateTime(2022, 09, 30, 12, 0, 0),
            FP2 = new DateTime(2022, 09, 30, 15, 0, 0),
            FP3 = new DateTime(2022, 10, 01, 12, 0, 0),
            Q = new DateTime(2022, 10, 01, 15, 0, 0),
            R = new DateTime(2022, 10, 02, 14, 0, 0),
            FlagImageName = "/Assets/Flags/sin.png"
        });

        raceEvents.Add(new RaceEvent
        {
            Id = 18,
            FullName = "Formula 1 Japanese Grand Prix 2022",
            FP1 = new DateTime(2022, 10, 07, 5, 0, 0),
            FP2 = new DateTime(2022, 10, 07, 8, 0, 0),
            FP3 = new DateTime(2022, 10, 08, 5, 0, 0),
            Q = new DateTime(2022, 10, 08, 9, 0, 0),
            R = new DateTime(2022, 10, 09, 7, 0, 0),
            FlagImageName = "/Assets/Flags/jap.png"
        });

        raceEvents.Add(new RaceEvent
        {
            Id = 19,
            FullName = "Formula 1 Aramco United States Grand Prix 2022",
            FP1 = new DateTime(2022, 10, 21, 21, 0, 0),
            FP2 = new DateTime(2022, 10, 22, 0, 0, 0),
            FP3 = new DateTime(2022, 10, 22, 21, 0, 0),
            Q = new DateTime(2022, 10, 23, 0, 0, 0),
            R = new DateTime(2022, 10, 23, 21, 0, 0),
            FlagImageName = "/Assets/Flags/usa.png"
        });

        raceEvents.Add(new RaceEvent
        {
            Id = 20,
            FullName = "Formula 1 Gran Premio de la Ciudad de Mexico 2022",
            FP1 = new DateTime(2022, 10, 28, 20, 0, 0),
            FP2 = new DateTime(2022, 10, 28, 23, 0, 0),
            FP3 = new DateTime(2022, 10, 29, 19, 0, 0),
            Q = new DateTime(2022, 10, 29, 22, 0, 0),
            R = new DateTime(2022, 10, 30, 21, 0, 0),
            FlagImageName = "/Assets/Flags/mex.png"
        });

        raceEvents.Add(new RaceEvent
        {
            Id = 21,
            FullName = "Formula 1 Heineken Grande Premio de Sao Paulo 2022",
            FP1 = new DateTime(2022, 11, 11, 16, 30, 0),
            FP2 = new DateTime(2022, 11, 11, 20, 0, 0),
            FP3 = new DateTime(2022, 11, 12, 16, 30, 0),
            Q = new DateTime(2022, 11, 12, 20, 30, 0),
            R = new DateTime(2022, 11, 13, 19, 0, 0),
            FlagImageName = "/Assets/Flags/bra.png",
            HasSprintRace = true
        });


        raceEvents.Add(new RaceEvent
        {
            Id = 22,
            FullName = "Formula 1 Etihad Airways Abu Dhabi Grand Prix 2022",
            FP1 = new DateTime(2022, 11, 18, 11, 0, 0),
            FP2 = new DateTime(2022, 11, 18, 14, 0, 0),
            FP3 = new DateTime(2022, 11, 19, 12, 0, 0),
            Q = new DateTime(2022, 11, 19, 15, 0, 0),
            R = new DateTime(2022, 11, 20, 14, 0, 0),
            FlagImageName = "/Assets/Flags/uae.png"
        });

        raceEvents.Add(new RaceEvent
        {
            Id = 23,
            FullName = "Formula 1 Gulf Air Bahrain Grand Prix 2023",
            FP1 = new DateTime(2023, 3, 3, 13, 0, 0),
            FP2 = new DateTime(2023, 3, 3, 16, 0, 0),
            FP3 = new DateTime(2023, 3, 4, 13, 0, 0),
            Q = new DateTime(2023, 3, 4, 16, 0, 0),
            R = new DateTime(2023, 3, 5, 16, 0, 0),
            FlagImageName = "/Assets/Flags/bah.png"
        });
    }
}
