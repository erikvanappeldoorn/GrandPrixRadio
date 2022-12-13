namespace GrandPrixRadio;

internal static class UriLocator
{
    internal static string GrandPrixRadioStreamHighPls { get; } = "https://playerservices.streamtheworld.com/pls/GRAND_PRIX_RADIO.pls";

    internal static string GrandPrixRadioStreamLowPls { get; } = "https://playerservices.streamtheworld.com/pls/GRAND_PRIX_RADIOAAC.pls";

    internal static string NowPlayingUri { get; } = "https://grandprixradio.nl/soundtracks/grand-prix-radio.json";

    internal static string NowOnAirUri { get; } = "https://grandprixradio.nl/programming-broadcast/grand-prix-radio.json";
}
