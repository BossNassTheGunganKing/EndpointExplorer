using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Data;
using System;

namespace EndpointExplorer.Converters;

public class StringNotEmptyToVisibilityConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, string language)
    {
        return (value is string s && !string.IsNullOrEmpty(s)) ? Visibility.Visible : Visibility.Collapsed;
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        throw new NotImplementedException();
    }
}