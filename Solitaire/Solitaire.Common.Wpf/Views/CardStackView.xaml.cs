using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Windows;
using System.Windows.Controls;
using Solitaire.Common.Models;

namespace Solitaire.Common.Wpf.Views
{
    /// <summary>
    /// Interaction logic for CardStackView.xaml
    /// </summary>
    public partial class CardStackView : UserControl
    {
        public static readonly DependencyProperty CardProperty = DependencyProperty.Register(
            "Cards", typeof (ObservableCollection<Card>), typeof (CardStackView),
            new PropertyMetadata(CardsChanged));

        private static void CardsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var sender = d as CardStackView;
            if (sender != null)
            {
                sender.AddCollectionChangedEvent();
            }
        }

        public ObservableCollection<Card> Cards
        {
            get { return (ObservableCollection<Card>)GetValue(CardProperty); }
            set { SetValue(CardProperty, value); }
        }

        public CardStackView()
        {
            InitializeComponent();
        }

        public void DrawCards()
        {
            LayoutRoot.Children.Clear();
            int i = 0;
            foreach (var card in Cards)
            {
                var cardView = new CardView
                {
                    DataContext = card
                };
                Grid.SetColumn(cardView, i++);
                LayoutRoot.Children.Add(cardView);
            }
        }

        public void AddCollectionChangedEvent()
        {
            Cards.CollectionChanged -= CardsOnCollectionChanged;
            Cards.CollectionChanged += CardsOnCollectionChanged;
        }

        private void CardsOnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            DrawCards();
        }
    }
}
