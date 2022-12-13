using Microsoft.UI.Xaml.Data;
using System;

namespace GrandPrixRadio.Converters;

public class SyncOffsetConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, string language)
    {
        TimeSpan offset = (TimeSpan)value;
        string prefix = (offset < TimeSpan.Zero) ? "-" : (offset > TimeSpan.Zero) ? "+" : " ";

        return $"{prefix}{Math.Abs(offset.Minutes):d2}:{Math.Abs(offset.Seconds):d2} sec.";
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        throw new NotImplementedException();
    }
}
