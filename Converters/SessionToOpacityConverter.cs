using GrandPrixRadio.Services;
using Microsoft.UI.Xaml.Data;
using System;

namespace GrandPrixRadio.Converters;

internal class SessionToOpacityConverter : IValueConverter
{
    private ICountdownService countdownService = new CountdownService();

    public object Convert(object value, Type targetType, object parameter, string language)
    {
        var session = parameter as String;
        var nextEvent = countdownService.GetNextRaceEvent(DateTime.Now);
        var nextSession = nextEvent.NextSession;
        if (nextSession.SessionName == session)
        {
            return 1.0;
        }

        return 0.5;
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        throw new NotImplementedException();
    }
}
