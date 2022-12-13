using Microsoft.UI.Xaml.Data;
using System;

namespace GrandPrixRadio.Converters;

internal class SessionTimeConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, string language)
    {
        var sessionDateTime = value as DateTime?;
        return sessionDateTime.Value.ToString("HH:mm");
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        throw new NotImplementedException();
    }
}
