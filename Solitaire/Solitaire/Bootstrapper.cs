using System.Windows;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.PubSubEvents;
using Microsoft.Practices.Prism.UnityExtensions;
using Microsoft.Practices.Unity;
using Solitaire.OverflowCardStack;
using Solitaire.Common.Models;
using Solitaire.Foundations;
using Solitaire.Tableaus;
using Solitaire.Common.Factories;

namespace Solitaire
{
    public class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<PrismAppShell>();
        }

        protected override void InitializeModules()
        {
            base.InitializeModules();
            Application.Current.MainWindow = (PrismAppShell)Shell;
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();
            var moduleCatalog = (ModuleCatalog)ModuleCatalog;
            moduleCatalog.AddModule(typeof(OverflowCardStackModule));
            moduleCatalog.AddModule(typeof(FoundationsModule));
            moduleCatalog.AddModule(typeof(TableausModule));
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();

            Container.RegisterType<IEventAggregator, EventAggregator>(new ContainerControlledLifetimeManager());

            var deckFactory = new StandardDeckFactory();
            var deck = deckFactory.CreateDeck();
            Container.RegisterInstance<IDeck>(deck, new ContainerControlledLifetimeManager());

            Container.RegisterType<ISolitaireGameInstance, SolitaireGameInstance>(new ContainerControlledLifetimeManager());
        }
    }
}
