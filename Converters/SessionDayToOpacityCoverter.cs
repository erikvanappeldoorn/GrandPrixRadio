using GrandPrixRadio.Services;
using Microsoft.UI.Xaml.Data;
using System;

namespace GrandPrixRadio.Converters;

internal class SessionDayToOpacityConverter : IValueConverter
{
    private ICountdownService countdownService = new CountdownService();

    public object Convert(object value, Type targetType, object parameter, string language)
    {
        var sessionday = Int32.Parse(parameter.ToString());
        var nextEvent = countdownService.GetNextRaceEvent(DateTime.Now);
        var nextSession = nextEvent.NextSession;
        if (nextSession.SessionDay == sessionday)
        {
            return 1.0;
        }

        return 0.6;
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        throw new NotImplementedException();
    }
}
