using System;
using System.Globalization;
using System.Windows.Data;
using Solitaire.Common.Models;

namespace Solitaire.Common.Wpf.Converters
{

    public class CardValueStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var cardValue = (Card.Values) value;
            string cardValueStr;

            if (cardValue < Card.Values.Jack)
            {
                var cardIntValue = (int) cardValue;
                cardValueStr = cardIntValue.ToString(CultureInfo.InvariantCulture);
            }
            else
            {
                cardValueStr = Enum.GetName(typeof (Card.Values), cardValue);
                if (cardValueStr != null)
                {
                    cardValueStr = cardValueStr.Substring(0, 1).ToUpper();
                }
            }

            return cardValueStr;
        }

        public object ConvertBack(object value, Type targetType, object parameter,
            CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }

}