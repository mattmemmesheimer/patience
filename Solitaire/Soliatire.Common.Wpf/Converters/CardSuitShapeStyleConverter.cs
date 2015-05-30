using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using Solitaire.Common.Models;

namespace Soliatire.Common.Wpf.Converters
{

    public class CardSuitShapeStyleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var suit = (Card.Suits) value;
            var styleName = string.Empty;
            switch (suit)
            {
                case Card.Suits.Diamonds:
                    styleName = "DiamondsShapeStyle";
                    break;
                case Card.Suits.Hearts:
                    styleName = "HeartsShapeStyle";
                    break;
                case Card.Suits.Clubs:
                    styleName = "ClubsShapeStyle";
                    break;
                case Card.Suits.Spades:
                    styleName = "SpadesShapeStyle";
                    break;
            }
            var style = (Style) Application.Current.Resources[styleName];
            if (style != null)
            {
                return style;
            }
            return Binding.DoNothing;
        }

        public object ConvertBack(object value, Type targetType, object parameter,
            CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }

}