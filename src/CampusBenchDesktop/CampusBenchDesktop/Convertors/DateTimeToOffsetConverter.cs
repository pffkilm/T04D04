namespace CampusBenchDesktop.Convertors;

using System;
using System.Globalization;
using Avalonia.Data.Converters;

public class DateTimeToOffsetConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is DateTime dt)
            return new DateTimeOffset(dt);
        return null;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is DateTimeOffset dto)
            return dto.DateTime;
        return DateTime.Now;
    }
}