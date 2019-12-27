﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace SteamFriendsManager.Converter
{
    [ValueConversion(typeof(bool), typeof(Visibility))]
    public class BooleanToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter,
            CultureInfo culture)
        {
            return (bool?) value ?? false ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter,
            CultureInfo culture)
        {
            return ((Visibility?) value ?? Visibility.Collapsed) == Visibility.Visible;
        }
    }
}