using System;
using System.Globalization;
using System.Windows.Data;
using Solitaire.Common.Models;

namespace Solitaire.Common.Wpf.Converters
{

    public class CardSuitStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var cardValue = (Card.Suits) value;
            return Enum.GetName(typeof (Card.Suits), cardValue);
        }

        public object ConvertBack(object value, Type targetType, object parameter,
            CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }

}