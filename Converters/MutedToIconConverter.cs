using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Data;
using System;

namespace GrandPrixRadio.Converters;

internal class MutedToIconConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, string language)
    {
        bool muted = System.Convert.ToBoolean(value);
        return muted ? new SymbolIcon(Symbol.Mute) : new SymbolIcon(Symbol.Volume);
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        throw new NotImplementedException();
    }
}
