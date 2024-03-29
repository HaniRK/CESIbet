﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Cesibet.ValueConverters
{
    public class ButtonVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var val = (Visibility)value;
            if (val == Visibility.Hidden)
                return Visibility.Visible;
            else
                return Visibility.Hidden;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
