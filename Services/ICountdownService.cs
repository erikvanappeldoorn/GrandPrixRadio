using GrandPrixRadio.Models;
using System;

namespace GrandPrixRadio.Services;

public interface ICountdownService
{
    RaceEvent GetNextRaceEvent(DateTime now);
}
