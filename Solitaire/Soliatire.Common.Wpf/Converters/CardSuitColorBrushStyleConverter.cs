using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using Solitaire.Common.Models;

namespace Soliatire.Common.Wpf.Converters
{
    public class CardSuitColorBrushStyleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var suit = (Card.Suits)value;
            string brushName = String.Empty;
            switch (suit)
            {
                case Card.Suits.Diamonds:
                    brushName = "DiamondsColorBrush";
                    break;
                case Card.Suits.Hearts:
                    brushName = "HeartsColorBrush";
                    break;
                case Card.Suits.Clubs:
                    brushName = "ClubsColorBrush";
                    break;
                case Card.Suits.Spades:
                    brushName = "SpadesColorBrush";
                    break;
            }
            var brush = (SolidColorBrush)Application.Current.Resources[brushName];
            if (brush != null)
            {
                return brush;
            }
            return Binding.DoNothing;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }
}
